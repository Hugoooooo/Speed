using Bunifu.Framework.UI;
using System.Application.Common;
using System.Framework;
using System.Framework.Common;
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
    public partial class PhraseEdit : Form
    {
        public mode mode;
        public string serno;
        public bool isItem;

        public PhraseEdit(mode pmode, string pcategory, string pserno = "")
        {
            InitializeComponent();
            APConfig.loadEnum<PhraseCategory>(ddlCategory, pcategory);
            serno = pserno;
            mode = pmode;
            isItem = (pcategory == PhraseCategory.商品資訊.ToString());
            ItemShowColumns(isItem);
            initView();
        }
        private void ItemShowColumns(bool isItem)
        {
            //判斷是否為商品
            if (isItem)
            {
                txtType.Enabled = true;
                txtColor.Enabled = true;
                txtSize.Enabled = true;
                lblSize.ForeColor = System.Drawing.Color.Black;
                lblType.ForeColor = System.Drawing.Color.Black;
                lblColor.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                txtType.Enabled = false;
                txtColor.Enabled = false;
                txtSize.Enabled = false;
                lblSize.ForeColor = System.Drawing.Color.Gray;
                lblType.ForeColor = System.Drawing.Color.Gray;
                lblColor.ForeColor = System.Drawing.Color.Gray;
            }
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
            }
            else if (mode == mode.Edit)
            {
                btnOK.ButtonText = "修改";
                btnOK.IdleFillColor = Color.FromArgb(255, 161, 0);
                btnOK.IdleLineColor = Color.FromArgb(255, 161, 0);
                btnOK.ActiveFillColor = Color.FromArgb(255, 161, 0);
                btnOK.ActiveLineColor = Color.FromArgb(255, 161, 0);
                ddlCategory.Enabled = false;
                PhraseInfo view = new PhraseInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.serno.ToString(), serno);
                if (view.load())
                {
                    txtName.Text = view.PHS_NAME;
                    txtIndex.Text = view.PHS_INDEX.ToString();
                    txtType.Text = view.PHS_TYPE;
                    txtColor.Text = view.PHS_COLOR;
                    txtSize.Text = view.PHS_SIZE;
                    APConfig.getSelectIndex(ddlCategory,view.PHS_CATEGORY);
                }
            }
            else if (mode == mode.View)
            {
                DisableControls();
                btnOK.ButtonText = "確認";
                PhraseInfo view = new PhraseInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.serno.ToString(), serno);
                if (view.load())
                {
                    txtName.Text = view.PHS_NAME;
                    txtIndex.Text = view.PHS_INDEX.ToString();
                    txtType.Text = view.PHS_TYPE;
                    txtColor.Text = view.PHS_COLOR;
                    txtSize.Text = view.PHS_SIZE;
                    APConfig.getSelectIndex(ddlCategory, view.PHS_CATEGORY);
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (mode == mode.Add && check())
            {
                Phrase ent = new Phrase(APConfig.Conn);
                ent.PHS_SERNO = My.GenSerNo();
                ent.PHS_CATEGORY = ddlCategory.SelectedItem.ToString();
                ent.PHS_NAME = txtName.Text;
                ent.PHS_INDEX = txtIndex.Text;
                ent.PHS_TYPE = txtType.Text;
                ent.PHS_COLOR = txtColor.Text;
                ent.PHS_SIZE = txtSize.Text;
                ent.PHS_MODIFIEDBY = APConfig.AccountName;
                ent.PHS_MODIFIEDDTTM = DateTime.Now;
                ent.insert();
                APConfig.SweetAlert(ShowBoxType.alert, "新增完成");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (mode == mode.Edit && check())
            {
                Phrase ent = new Phrase(APConfig.Conn);
                ent.PHS_SERNO = serno;
                ent.ModifyFields = string.Format("{0};{1};{2};{3},{4},{5},{6}"
                    , Phrase.ncFields.PHS_NAME.ToString()
                    , Phrase.ncFields.PHS_INDEX.ToString()
                    , Phrase.ncFields.PHS_TYPE.ToString()
                    , Phrase.ncFields.PHS_SIZE.ToString()
                    , Phrase.ncFields.PHS_COLOR.ToString()
                    , Phrase.ncFields.PHS_MODIFIEDBY.ToString()
                    , Phrase.ncFields.PHS_MODIFIEDDTTM.ToString());
                ent.PHS_NAME = txtName.Text;
                ent.PHS_INDEX = txtIndex.Text;
                ent.PHS_TYPE = txtType.Text;
                ent.PHS_COLOR = txtColor.Text;
                ent.PHS_SIZE = txtSize.Text;
                ent.PHS_MODIFIEDBY = APConfig.AccountName;
                ent.PHS_MODIFIEDDTTM = DateTime.Now;
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
        private bool check()
        {
            string msg = "";
            bool isEmpty = false;


            if (string.IsNullOrEmpty(txtName.Text))
            {
                msg = "欄位不能為空值!";
                isEmpty = true;
            }

            if (!isEmpty)
            {
                PhraseInfo view = new PhraseInfo(APConfig.Conn);
                view.Conditions = " 1=1 ";
                view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.category.ToString(), ddlCategory.SelectedItem.ToString());
                view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.EQname.ToString(), txtName.Text);
                if (isItem)
                {
                    view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.EQsize.ToString(), txtSize.Text);
                    view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.EQtype.ToString(), txtType.Text);
                    view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.EQcolor.ToString(), txtColor.Text);
                }
                if (view.calculateCount() > 0)
                    msg = "項目已存在!請確認!";
            }

            if (!string.IsNullOrEmpty(msg))
            {
                APConfig.SweetAlert(ShowBoxType.alert, msg);
            }
            return string.IsNullOrEmpty(msg) ? true : false;
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

        private void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            isItem = (ddlCategory.SelectedItem.ToString() == PhraseCategory.商品資訊.ToString());
            ItemShowColumns(isItem);
        }
    }
}
