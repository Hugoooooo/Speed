using System.Framework;
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
    public partial class PickInventoryItem : Form
    {
        public string itemName = "";
        public string itemType = "";
        public string itemColor = "";
        public string itemSize = "";

        public PickInventoryItem()
        {
            InitializeComponent();
            ItemSearch();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ItemSearch();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ItemSearch()
        {
            dgvItem.Rows.Clear();
            DataGridViewRowCollection rows = dgvItem.Rows;
            PhraseInfo view = new PhraseInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.category.ToString(), PhraseCategory.商品資訊.ToString());
            if(!string.IsNullOrEmpty(txtName.Text))
                view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.name.ToString(),txtName.Text);
            view.load();
            while (!view.IsEof)
            {
                rows.Add(new Object[] { view.PHS_NAME, view.PHS_TYPE,view.PHS_COLOR,view.PHS_SIZE });
                view.next();
            }
        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgvItem.SelectedRows[0];
            itemName = row.Cells[0].Value.ToString();
            itemType = row.Cells[1].Value.ToString();
            itemColor = row.Cells[2].Value.ToString();
            itemSize = row.Cells[3].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
