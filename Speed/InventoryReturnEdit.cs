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
    public partial class InventoryReturnEdit : Form
    {
        public mode mode;
        public string serno;
        public Inventory Inventory { get; set; }
        public InventoryReturnEdit(mode pmode, string pserno = "")
        {
            InitializeComponent();
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
                dpkReturnDTTM.Value = DateTime.Today;
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
                    txtAmount.Text = view.INV_INAMT.ToString();
                    txtComment.Text = view.INV_INCOMMENT;
                    dpkDTTM.Value = view.INV_INDTTM;

                    txtReturnAmount.Text = view.INV_RETURNAMT.ToString();
                    dpkReturnDTTM.Value = view.INV_RETURNDTTM;
                    txtReturnComment.Text = view.INV_RETURNCOMMENT;
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
                    txtColor.Text = view.INV_COLOR;
                    txtType.Text = view.INV_TYPE;
                    txtAmount.Text = view.INV_INAMT.ToString();
                    txtComment.Text = view.INV_INCOMMENT;
                    dpkDTTM.Value = view.INV_INDTTM;

                    txtReturnAmount.Text = view.INV_RETURNAMT.ToString();
                    dpkReturnDTTM.Value = view.INV_RETURNDTTM;
                    txtReturnComment.Text = view.INV_RETURNCOMMENT;
                }
            }
        }
        private bool checkAdd()
        {
            string msg = "";
            if (mode == mode.Add && dgvItem.RowCount<=0)
                msg = "商品資訊無法為空!";
            else if (mode == mode.Edit && string.IsNullOrEmpty(txtReturnAmount.Text))
                msg = "退金額無法為空!";
            else if (dpkReturnDTTM.Value<dpkDTTM.Value)
                msg = "退貨日期無法小於進貨日期!";


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
                msg = "請選取庫存!";
            else if (string.IsNullOrEmpty(txtReturnAmount.Text))
                msg = "請輸入退貨金額";
            else if (!int.TryParse(txtReturnAmount.Text,out int n))
                msg = "退貨金額欄位請輸入數字";
            else if (dpkReturnDTTM.Value < dpkDTTM.Value)
                msg = "出貨日期無法小於進貨日期!";

            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                if (serno == row.Cells["dgvItem_Serno"].Value.ToString())
                {
                    msg = "該筆資料已存在列表!";
                    break;
                }
            }

            if (!string.IsNullOrEmpty(msg))
            {
                APConfig.SweetAlert(ShowBoxType.alert, msg);
                return;
            }
            #endregion
            DataGridViewRowCollection rows = dgvItem.Rows;
            rows.Add(new Object[] { serno,txtCode.Text,txtName.Text,txtType.Text,txtColor.Text,txtReturnAmount.Text, dpkReturnDTTM.Value.ToShortDateString(),txtReturnComment.Text });
            clearPage();
            loadRowColor();
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
            txtReturnAmount.Text = row.Cells["dgvItem_Amount"].Value.ToString();
            txtReturnComment.Text = row.Cells["dgvItem_Comment"].Value.ToString();
            dpkReturnDTTM.Value = Convert.ToDateTime(row.Cells["dgvItem_ImportDTTM"].Value);
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
                    ent.ModifyFields = string.Format("{0};{1};{2};{3};{4};{5}"
                            , Inventory.ncFields.INV_STATUS.ToString()
                            , Inventory.ncFields.INV_RETURNAMT.ToString()
                            , Inventory.ncFields.INV_RETURNDTTM.ToString()
                            , Inventory.ncFields.INV_RETURNCOMMENT.ToString()
                            , Inventory.ncFields.INV_MODIFIEDBY.ToString()
                            , Inventory.ncFields.INV_MODIFIEDDTTM.ToString());
                    ent.INV_STATUS = InventoryStatus.已退貨.ToString();
                    ent.INV_RETURNAMT = Convert.ToInt32(row.Cells["dgvItem_Amount"].Value);
                    ent.INV_RETURNCOMMENT = row.Cells["dgvItem_Comment"].Value.ToString();
                    ent.INV_RETURNDTTM = DateTime.Parse(row.Cells["dgvItem_ImportDTTM"].Value.ToString());
                    ent.INV_MODIFIEDBY = APConfig.AccountName;
                    ent.INV_MODIFIEDDTTM = DateTime.Now;
                    count += ent.update();
                }
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("退貨完成!\r\n新增 {0} 件退貨單",count.ToString()));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (mode == mode.Edit && checkAdd())
            {
                Inventory ent = new Inventory(APConfig.Conn);
                ent.INV_SERNO = serno;
                ent.ModifyFields = string.Format("{0};{1};{2};{3};{4}"
                            , Inventory.ncFields.INV_RETURNAMT.ToString()
                            , Inventory.ncFields.INV_RETURNDTTM.ToString()
                            , Inventory.ncFields.INV_RETURNCOMMENT.ToString()
                            , Inventory.ncFields.INV_MODIFIEDBY.ToString()
                            , Inventory.ncFields.INV_MODIFIEDDTTM.ToString());
                ent.INV_RETURNAMT = Convert.ToInt32(txtReturnAmount.Text);
                ent.INV_RETURNDTTM = DateTime.Parse(dpkReturnDTTM.Value.ToString());
                ent.INV_RETURNCOMMENT = txtReturnComment.Text;
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
            clearPage();
        }
        private void clearPage()
        {
            serno = "";
            txtCode.Text = "";
            txtName.Text = "";
            txtType.Text = "";
            txtColor.Text = "";
            txtAmount.Text = "";
            txtComment.Text = "";
            txtReturnAmount.Text = "";
            txtReturnComment.Text = "";
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
            List<string> curPostList = new List<string>();
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["dgvItem_Serno"].Value.ToString()))
                    curPostList.Add(row.Cells["dgvItem_Serno"].Value.ToString());
            }
            using (var form = new PickInventoryReturn(string.Join(",", curPostList)))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    loadData(form.itemserno);
                }
            }
        }

        private void loadData(string pserno)
        {
            if (string.IsNullOrEmpty(pserno))
                APConfig.SweetAlert(ShowBoxType.alert, "載入失敗!聯繫Hugo!");
            else
            {
                InventoryInfo view = new InventoryInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(InventoryInfo.ncConditions.serno.ToString(), pserno);
                if (view.load())
                {
                    serno = view.INV_SERNO;
                    txtCode.Text = view.INV_VENDOR;
                    txtName.Text = view.INV_NAME;
                    txtColor.Text = view.INV_COLOR;
                    txtType.Text = view.INV_TYPE;
                    txtAmount.Text = view.INV_INAMT.ToString();
                    dpkDTTM.Value = view.INV_INDTTM;
                    txtComment.Text = view.INV_INCOMMENT;
                }

            }
        }
        private void loadRowColor()
        {
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells["dgvItem_Code"].Value.ToString()))
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
    }
}
