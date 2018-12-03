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
    public partial class PickInventoryDelete : Form
    {
        public mode mode;
        public string sernolist = "";
        public PickInventoryDelete(mode pmode, string pSernoList)
        {
            InitializeComponent();
            mode = pmode;
            sernolist = pSernoList;
            loadData();
        }

        private void loadData()
        {
            dgvInventory.Rows.Clear();
            string info = "";
            DataGridViewRowCollection rows = dgvInventory.Rows;

            InventoryInfo view = new InventoryInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            view.Conditions += " AND "+view.getCondition(InventoryInfo.ncConditions.sernolist.ToString(), sernolist);
            view.load();
            while(!view.IsEof)
            {
                rows.Add(new Object[] { view.INV_SERNO, true, view.INV_STATUS, view.INV_VENDOR,view.INV_NAME,view.INV_TYPE,view.INV_COLOR,view.INV_SIZE});
                view.next();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2)
                return;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dgvInventory.EndEdit();
                List<string> sernolist = new List<string>();
                string delSernoList = "";
                foreach (DataGridViewRow row in dgvInventory.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                    if ((bool)chk.Value)
                        sernolist.Add(row.Cells["dgvInventory_Serno"].Value.ToString());
                }
                delSernoList = APConfig.sqlArrayFormat(string.Join(",", sernolist));
                Inventory ent = new Inventory(APConfig.Conn);
                string sConditions = ent.getCondition(Inventory.ncConditions.sernolist.ToString(), delSernoList);
                ent.deleteAll(sConditions);
                APConfig.SweetAlert(ShowBoxType.alert, "刪除完成");
                this.Close();
            }
            catch (Exception ex)
            {
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("刪除失敗 {0}", ex.Message));
            }
        }

        private void ckbAll_CheckedChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                chk.Value = ckbAll.Checked;
            }
        }
    }
}
