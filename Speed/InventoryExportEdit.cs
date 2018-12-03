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
    public partial class InventoryExportEdit : Form
    {
        public mode mode;
        public string serno;
        public Inventory Inventory { get; set; }
        public InventoryExportEdit(mode pmode, string pserno = "")
        {
            InitializeComponent();
            APConfig.loadPhrase(ddlDealer, PhraseCategory.負責人.ToString());
            serno = pserno;
            mode = pmode;
            initView();
        }
        private void initView()
        {
            if (mode == mode.Add)
            {
                btnOK.ButtonText = "新增";
                btnOK.IdleFillColor = Color.FromArgb(33, 166, 117);
                btnOK.IdleLineColor = Color.FromArgb(33, 166, 117);
                btnOK.ActiveFillColor = Color.FromArgb(33, 166, 117);
                btnOK.ActiveLineColor = Color.FromArgb(33, 166, 117);
                dpkExportDTTM.Value = DateTime.Today;
                ddlDealer.SelectedIndex = 0;
            }
            else if (mode == mode.Edit)
            {
                btnOK.ButtonText = "修改";
                btnOK.IdleFillColor = Color.FromArgb(255, 161, 0);
                btnOK.IdleLineColor = Color.FromArgb(255, 161, 0);
                btnOK.ActiveFillColor = Color.FromArgb(255, 161, 0);
                btnOK.ActiveLineColor = Color.FromArgb(255, 161, 0);
                btnItemAdd.Visible = false;
                btnItemDel.Visible = false;
                btnClear.Visible = false;
                lblTotalAmt.Visible = false;
                txtCode.Enabled = false;
                InventoryInfo view = new InventoryInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.serno.ToString(), serno);
                view.load();
                if (view.load())
                {
                    txtCode.Text = view.INV_VENDOR;
                    txtName.Text = view.INV_NAME;
                    txtType.Text = view.INV_TYPE;
                    txtColor.Text = view.INV_COLOR;
                    txtImportAmount.Text = view.INV_INAMT.ToString();
                    txtImportComment.Text = view.INV_INCOMMENT;
                    dpkImportDTTM.Value = view.INV_INDTTM;
                    ddlDealer.SelectedIndex = APConfig.getSelectIndex(ddlDealer, view.INV_OUTDEALER);
                    txtExportAmount.Text = view.INV_OUTAMT.ToString();
                    dpkExportDTTM.Value = view.INV_OUTDTTM;
                    txtExportComment.Text = view.INV_OUTCOMMENT;
                }
            }
            else if (mode == mode.View)
            {
                DisableControls();
                btnOK.ButtonText = "確認";
                btnItemAdd.Visible = false;
                btnItemDel.Visible = false;
                btnClear.Visible = false;
                lblTotalAmt.Visible = false;
                InventoryInfo view = new InventoryInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.serno.ToString(), serno);
                view.load();
                if (view.load())
                {
                    txtCode.Text = view.INV_VENDOR;
                    txtName.Text = view.INV_NAME;
                    txtType.Text = view.INV_TYPE;
                    txtColor.Text = view.INV_COLOR;
                    txtImportAmount.Text = view.INV_INAMT.ToString();
                    txtImportComment.Text = view.INV_INCOMMENT;
                    dpkImportDTTM.Value = view.INV_INDTTM;
                    ddlDealer.SelectedIndex = APConfig.getSelectIndex(ddlDealer, view.INV_OUTDEALER);
                    txtExportAmount.Text = view.INV_OUTAMT.ToString();
                    dpkExportDTTM.Value = view.INV_OUTDTTM;
                    txtExportComment.Text = view.INV_OUTCOMMENT;
                }
            }
        }
        private bool checkAdd()
        {
            string msg = "";
            if (mode == mode.Add && dgvItem.RowCount<=0)
                msg = "商品資訊無法為空!";
            else if (mode == mode.Edit && string.IsNullOrEmpty(txtExportAmount.Text))
                msg = "商品金額無法為空!";
            else if (dpkExportDTTM.Value<dpkImportDTTM.Value)
                msg = "出貨日期無法小於進貨日期!";


            if (!string.IsNullOrEmpty(msg))
            {
                APConfig.SweetAlert(ShowBoxType.alert, msg);
            }
            return string.IsNullOrEmpty(msg) ? true : false;
        }
        private void loadTotalAmount()
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                total += int.Parse(row.Cells["dgvItem_Amount"].Value.ToString());
            }
            lblTotalAmt.Text = string.Format("出貨總金額: {0:n0}  元", total);
        }
        private void itemInfoAdd()
        {
            #region 判斷
            string msg = "";
            if (string.IsNullOrEmpty(serno))
                msg = "請選取進貨單!";
            else if (string.IsNullOrEmpty(txtExportAmount.Text))
                msg = "請輸入出貨金額";
            else if (!int.TryParse(txtExportAmount.Text,out int n))
                msg = "出貨金額欄位請輸入數字";
            else if (dpkExportDTTM.Value < dpkImportDTTM.Value)
                msg = "出貨日期無法小於進貨日期!";

            if (!string.IsNullOrEmpty(msg))
            {
                APConfig.SweetAlert(ShowBoxType.alert, msg);
                return;
            }
            #endregion
            DataGridViewRowCollection rows = dgvItem.Rows;
            rows.Add(new Object[] { serno,txtCode.Text,txtName.Text,txtType.Text,txtColor.Text,txtExportAmount.Text,ddlDealer.SelectedItem.ToString(), dpkExportDTTM.Value.ToShortDateString(),txtExportComment.Text });
            clearTextBox();
            loadTotalAmount();
        }
        private void DisableControls()
        {
            bool status = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is BunifuMetroTextbox)
                    ((BunifuMetroTextbox)ctrl).Enabled = status;
                else if (ctrl is BunifuCheckbox)
                    ((BunifuCheckbox)ctrl).Enabled = status;
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).Enabled = status;
            }
        }
        private void dgvItem_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvItem.SelectedRows[0];
            ddlDealer.SelectedIndex = APConfig.getSelectIndex(ddlDealer, row.Cells["dgvItem_Dealer"].Value.ToString());
            txtExportAmount.Text = row.Cells["dgvItem_Amount"].Value.ToString();
            dpkExportDTTM.Value = Convert.ToDateTime(row.Cells["dgvItem_ImportDTTM"].Value);
            txtExportComment.Text = row.Cells["dgvItem_Comment"].Value.ToString();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (mode == mode.Add && checkAdd())
            {
                int count = 0;
                foreach (DataGridViewRow row in dgvItem.Rows)
                {
                    Inventory ent = new Inventory(APConfig.Conn);
                    ent.INV_SERNO = row.Cells["dgvItem_Serno"].Value.ToString();
                    ent.ModifyFields = string.Format("{0};{1};{2};{3};{4};{5};{6}"
                        , Inventory.ncFields.INV_OUTDEALER.ToString()
                        , Inventory.ncFields.INV_OUTAMT.ToString()
                        , Inventory.ncFields.INV_OUTDTTM.ToString()
                        , Inventory.ncFields.INV_OUTCOMMENT.ToString()
                        , Inventory.ncFields.INV_MODIFIEDBY.ToString()
                        , Inventory.ncFields.INV_MODIFIEDDTTM.ToString()
                        , Inventory.ncFields.INV_STATUS.ToString());
                    ent.INV_OUTDEALER = row.Cells["dgvItem_Dealer"].Value.ToString();
                    ent.INV_OUTAMT = Convert.ToInt32(row.Cells["dgvItem_Amount"].Value.ToString());
                    ent.INV_OUTDTTM = DateTime.Parse(row.Cells["dgvItem_ImportDTTM"].Value.ToString());
                    ent.INV_OUTCOMMENT = row.Cells["dgvItem_Comment"].Value.ToString();
                    ent.INV_MODIFIEDBY = APConfig.AccountName;
                    ent.INV_MODIFIEDDTTM = DateTime.Now;
                    ent.INV_STATUS = InventoryStatus.已出貨.ToString();
                    count += ent.update();
                }
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("出貨完成!\r\n新增 {0} 件出貨單",count.ToString()));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (mode == mode.Edit && checkAdd())
            {
                Inventory ent = new Inventory(APConfig.Conn);
                ent.INV_SERNO = serno;
                ent.ModifyFields = string.Format("{0};{1};{2};{3};{4};{5}"
                        , Inventory.ncFields.INV_OUTDEALER.ToString()
                        , Inventory.ncFields.INV_OUTAMT.ToString()
                        , Inventory.ncFields.INV_OUTDTTM.ToString()
                        , Inventory.ncFields.INV_OUTCOMMENT.ToString()
                        , Inventory.ncFields.INV_MODIFIEDBY.ToString()
                        , Inventory.ncFields.INV_MODIFIEDDTTM.ToString());
                ent.INV_OUTDEALER = ddlDealer.SelectedItem.ToString();
                ent.INV_OUTAMT = Convert.ToInt32(txtExportAmount.Text);
                ent.INV_OUTDTTM = DateTime.Parse(dpkExportDTTM.Value.ToString());
                ent.INV_OUTCOMMENT = txtExportComment.Text;
                ent.INV_MODIFIEDBY = APConfig.AccountName;
                ent.INV_MODIFIEDDTTM = DateTime.Now;
                ent.update();
                APConfig.SweetAlert(ShowBoxType.alert, "修改完成");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (mode == mode.View)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                return;
        }
        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            itemInfoAdd();
        }
        private void btnItemDel_Click(object sender, EventArgs e)
        {
            if (APConfig.SweetAlert(ShowBoxType.confirm, "是否確定要刪除?"))
            {
                foreach (DataGridViewRow row in dgvItem.SelectedRows)
                {
                    dgvItem.Rows.RemoveAt(row.Index);
                }
            }
            loadTotalAmount();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }
        private void clearTextBox()
        {
            serno = "";
            txtCode.Text = "";
            txtName.Text = "";
            txtImportAmount.Text = "";
            txtImportComment.Text = "";
            ddlDealer.SelectedIndex = 0;
            txtExportAmount.Text = "";
            txtExportComment.Text = "";
            //dpkImportDTTM.Value = DateTime.Today;
            //dpkExportDTTM.Value = DateTime.Today;
            btnItemPick.Focus();
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #region 移動介面 (Border Style = none)
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panelBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panelBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        #endregion

        private void btnItemPick_Click(object sender, EventArgs e)
        {
            List<string> curList = new List<string>();
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["dgvItem_Serno"].Value.ToString()))
                    curList.Add(row.Cells["dgvItem_Serno"].Value.ToString());
            }
            using (var form = new PickInventoryImport(string.Join(",", curList)))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    serno = form.itemserno;
                    loadData();
                }
            }
        }

        private void loadData()
        {
            InventoryInfo view = new InventoryInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.serno.ToString(), serno);
            view.load();
            txtCode.Text = view.INV_VENDOR ;
            txtName.Text = view.INV_NAME;
            txtType.Text = view.INV_TYPE;
            txtColor.Text = view.INV_COLOR;
            txtImportAmount.Text = view.INV_INAMT.ToString();
            dpkImportDTTM.Value = view.INV_INDTTM;
            txtImportComment.Text = view.INV_INCOMMENT;
        }
    }
}
