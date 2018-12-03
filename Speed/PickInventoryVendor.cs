using Bunifu.Framework.UI;
using System.Application.Common;
using System.Framework;
using System.DataLayer.Entities;
using System.DataLayer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed
{
    public partial class PickInventoryVendor : Form
    {
        public mode mode;
        public string sernolist = "";
        public PickInventoryVendor(mode pmode, string pSernoList)
        {
            InitializeComponent();
            mode = pmode;
            sernolist = APConfig.sqlArrayFormat(pSernoList);
            loadData();
        }

        private void loadData()
        {
            dgvItem.Rows.Clear();
            string info = "";
            DataGridViewRowCollection rows = dgvItem.Rows;

            InventoryInfo view = new InventoryInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            view.Conditions += " AND "+view.getCondition(InventoryInfo.ncConditions.sernolist.ToString(), sernolist);
            view.OrderBy = view.getOptionOrderBy(InventoryInfo.ncOrderBy.ODBstatus.ToString()) ;
            view.load();
            while(!view.IsEof)
            {
                rows.Add(new Object[] { view.INV_SERNO, view.INV_STATUS, view.INV_VENDOR, view.INV_NAME,view.INV_INAMT,view.INV_INDTTM.ToShortDateString(),view.INV_OUTAMT,view.INV_OUTDTTM.ToShortDateString() });
                view.next();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvItem.SelectedRows[0];
            string status = row.Cells["dgvItem_Status"].Value.ToString();
            if (status == InventoryStatus.已出貨.ToString())
            {
                this.Hide();
                InventoryExportEdit form = new InventoryExportEdit(mode, row.Cells["dgvItem_Serno"].Value.ToString());
                form.ShowDialog();
                this.Close();
            }
            else if (status == InventoryStatus.庫存中.ToString())
            {
                this.Hide();
                InventoryImportEdit form = new InventoryImportEdit(mode, row.Cells["dgvItem_Serno"].Value.ToString());
                form.ShowDialog();
                this.Close();
            }
            else if (status == InventoryStatus.已退貨.ToString())
            {
                this.Hide();
                InventoryReturnEdit form = new InventoryReturnEdit(mode, row.Cells["dgvItem_Serno"].Value.ToString());
                form.ShowDialog();
                this.Close();
            }
            else
            {
                APConfig.SweetAlert(ShowBoxType.alert, "請聯繫Hugo!");
                this.Close();
            }
        }
    }
}
