using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Application.DataAccess.Common;
using System.Framework;
using System.DataLayer.Entities;
using System.DataLayer.Views;

namespace Speed
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            inventoryInitial();
            lblUser.Text = APConfig.AccountName;
            panelInventory.Visible = true;
        }
        
        #region Panel Phrase
        private void phraseInitial()
        {
            APConfig.loadEnum<PhraseCategory>(ddlPhraseCategory);
            dgvPhrase.Rows.Clear();
            txtPhraseName.Text = string.Empty;
            lblPhraseTotal.Text = "0";
        }
        private void phraseLoadData()
        {
            dgvPhrase.Rows.Clear();
            DataGridViewRowCollection rows = dgvPhrase.Rows;
            PhraseInfo view = new PhraseInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.category.ToString(), ddlPhraseCategory.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(txtPhraseName.Text))
                view.Conditions += " AND " + view.getCondition(PhraseInfo.ncConditions.name.ToString(), txtPhraseName.Text);
            if (view.load())
            {
                while (!view.IsEof)
                {
                    rows.Add(new Object[] { view.PHS_SERNO, view.PHS_NAME,view.PHS_TYPE,view.PHS_COLOR,view.PHS_SIZE, view.PHS_INDEX });
                    view.next();
                }
            }
            lblPhraseTotal.Text = view.calculateCount().ToString();
            dgvItemShowColumns(ddlPhraseCategory.SelectedItem.ToString() == PhraseCategory.商品資訊.ToString());
        }
        private void btnPhraseSearch_Click(object sender, EventArgs e)
        {
            phraseLoadData();
        }

        private void dgvItemShowColumns(bool isItem)
        {
            if(isItem)
            {
                dgvPhrase.Columns[2].Visible = true;
                dgvPhrase.Columns[3].Visible = true;
                dgvPhrase.Columns[4].Visible = true;
            }
            else
            {
                dgvPhrase.Columns[2].Visible = false;
                dgvPhrase.Columns[3].Visible = false;
                dgvPhrase.Columns[4].Visible = false;
            }
        }
        private void btnPhraseAdd_Click(object sender, EventArgs e)
        {
            using (var form = new PhraseEdit(mode.Add, ddlPhraseCategory.SelectedItem.ToString()))
            {
                panelPhrase.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelPhrase.Visible = true;
                panelMask.Visible = false;
            }
            phraseLoadData();
        }
        private void btnPhraseModify_Click(object sender, EventArgs e)
        {
            if (this.dgvPhrase.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvPhrase.SelectedRows[0];
                using (var form = new PhraseEdit(mode.Edit, ddlPhraseCategory.SelectedItem.ToString(), row.Cells["dgvPhrase_Serno"].Value.ToString()))
                {
                    panelPhrase.Visible = false;
                    panelMask.Visible = true;
                    var result = form.ShowDialog();
                    panelPhrase.Visible = true;
                    panelMask.Visible = false;
                }
                phraseLoadData();
            }
        }
        private void btnPhraseDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhrase.SelectedRows.Count > 0 && APConfig.SweetAlert(ShowBoxType.confirm, string.Format("是否確定要刪除{0}筆?", dgvPhrase.SelectedRows.Count)))
                {
                    List<string> sernolist = new List<string>();
                    string delSernoList = "";
                    foreach (DataGridViewRow row in dgvPhrase.SelectedRows)
                    {
                        sernolist.Add(string.Format("'{0}'", row.Cells["dgvPhrase_Serno"].Value.ToString()));
                    }
                    delSernoList = string.Join(",", sernolist);
                    Phrase ent = new Phrase(APConfig.Conn);
                    string sConditions = ent.getCondition(Phrase.ncConditions.sernolist.ToString(), delSernoList);
                    ent.deleteAll(sConditions);
                    phraseLoadData();
                    APConfig.SweetAlert(ShowBoxType.alert, "刪除完成");
                }
            }
            catch (Exception ex)
            {
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("刪除失敗 {0}", ex.Message));
            }
        }
        private void dgvPhrase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgvPhrase.SelectedRows[0];
            using (var form = new PhraseEdit(mode.View, ddlPhraseCategory.SelectedItem.ToString(), row.Cells["dgvPhrase_Serno"].Value.ToString()))
            {
                panelPhrase.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelPhrase.Visible = true;
                panelMask.Visible = false;
            }
        }
        private void ddlPhraseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            phraseLoadData();
        }
        #endregion

        #region Panel Inventory
        private void inventoryInitial()
        {
            dgvInventory.Rows.Clear();
            APConfig.loadPhrase(ddlInventoryDealer, PhraseCategory.負責人.ToString(), true);
            APConfig.loadPhrase(ddlInventoryVendor, PhraseCategory.供應商.ToString(), true);
            APConfig.loadEnum<InventoryStatus>(ddlInventoryStatus, "", true);
            txtInventoryName.Text = string.Empty;
            ckbInventoryINDTTM.Checked = false;
            ckbInventoryOUTDTTM.Checked = false;
            ckbInventoryRETURNDTTM.Checked = false;
            ddlInventoryVendor.SelectedIndex = 0;
            ddlInventoryDealer.SelectedIndex = 0;
            ddlInventoryStatus.SelectedIndex = 0;
            dpkInventoryINSDTTM.Value = DateTime.Today;
            dpkInventoryINEDTTM.Value = DateTime.Today;
            dpkInventoryOUTEDTTM.Value = DateTime.Today;
            dpkInventoryOUTSDTTM.Value = DateTime.Today;
            dpkInventoryRETURNSDTTM.Value = DateTime.Today;
            dpkInventoryRETURNEDTTM.Value = DateTime.Today;
            lblInventoryINAMT.Text = "0 元";
            lblInventoryOUTAMT.Text = "0 元";
            lblInventoryRETURNAMT.Text = "0 元";
            lblInventoryNETTotal.Text = "0 元";
            lblInventoryTotal.Text = "0";
            ddlInventoryPage.Items.Clear();
        }
        private void inventoryLoadData(int pageNum)
        {
            int importTotal = 0, exportTotal = 0, itemTotal = 0, netTotal = 0, returnTotal = 0;
            dgvInventory.Rows.Clear();
            DataGridViewRowCollection rows = dgvInventory.Rows;
            InventroyRPTInfo view = new InventroyRPTInfo(APConfig.Conn);
            view.Conditions = " 1=1 ";
            if (!string.IsNullOrEmpty(txtInventoryName.Text))
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.name.ToString(), txtInventoryName.Text);
            if (!string.IsNullOrEmpty(dpkInventoryINSDTTM.Value.ToString()) && ckbInventoryINDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.importSDTTM.ToString(), dpkInventoryINSDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryINEDTTM.Value.ToString()) && ckbInventoryINDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.importEDTTM.ToString(), dpkInventoryINEDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryOUTSDTTM.Value.ToString()) && ckbInventoryOUTDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.exportSDTTM.ToString(), dpkInventoryOUTSDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryOUTEDTTM.Value.ToString()) && ckbInventoryOUTDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.exportEDTTM.ToString(), dpkInventoryOUTEDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryRETURNSDTTM.Value.ToString()) && ckbInventoryRETURNDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.returnSDTTM.ToString(), dpkInventoryRETURNSDTTM.Value.ToString("yyyy/MM/dd"));
            if (!string.IsNullOrEmpty(dpkInventoryRETURNEDTTM.Value.ToString()) && ckbInventoryRETURNDTTM.Checked)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.returnEDTTM.ToString(), dpkInventoryRETURNEDTTM.Value.ToString("yyyy/MM/dd"));
            if (ddlInventoryVendor.SelectedIndex != 0)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.vendor.ToString(), ddlInventoryVendor.SelectedItem.ToString());
            if (ddlInventoryDealer.SelectedIndex != 0)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.dealer.ToString(), ddlInventoryDealer.SelectedItem.ToString());
            if (ddlInventoryStatus.SelectedIndex != 0)
                view.Conditions += " AND " + view.getCondition(InventroyRPTInfo.ncConditions.status.ToString(), ddlInventoryStatus.SelectedItem.ToString());

            view.condFormat(string.Format(" AND {0} ", view.Conditions));



            //組排序指令
            if (dgvInventory.SortedColumn is null)
                view.OrderBy = view.getOptionOrderBy(RosterDial_RInfo.ncSort.Default.ToString());
            else
            {
                string sortname = dgvInventory.SortedColumn.Name;
                string sortmode = APConfig.GetValueFromDescription<SortMode>(dgvInventory.SortOrder.ToString()).ToString();
                view.OrderBy = string.Format("{0} {1}", view.getOptionOrderBy(sortname), sortmode);
            }
            //查詢頁數初始化且自動跳轉至第一頁
            if (pageNum == 0)
            {
                APConfig.loadPage(ddlInventoryPage, view.calculatePage(APConfig.PageCount));
                return;
            }
            //塞入資料
            DataSet ds = APConfig.GoPage(view.SQLStatement, pageNum);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rows.Add(new Object[] { dr.ItemArray[4], dr.ItemArray[0], dr.ItemArray[1], dr.ItemArray[2], dr.ItemArray[3], dr.ItemArray[5], dr.ItemArray[6], dr.ItemArray[7], dr.ItemArray[8], dr.ItemArray[9], dr.ItemArray[10], dr.ItemArray[11], dr.ItemArray[12] });
            }
            //計算總合
            if (view.load())
            {
                while (!view.IsEof)
                {
                    importTotal += view.INTOTAL;
                    exportTotal += view.OUTTOTAL ;
                    netTotal += view.NET;
                    returnTotal += view.RETURNTOTAL;
                    itemTotal += Convert.ToInt32(view.STOCK);
                    view.next();
                }
            }
            lblInventoryTotal.Text = string.Format("{0}", itemTotal.ToString());
            lblInventoryINAMT.Text = string.Format("{0:n0} 元", importTotal);
            lblInventoryOUTAMT.Text = string.Format("{0:n0} 元", exportTotal);
            lblInventoryRETURNAMT.Text = string.Format("{0:n0} 元", returnTotal);
            lblInventoryNETTotal.Text = string.Format("{0:n0} 元", netTotal);
        }
        private void btnInventorySearch_Click(object sender, EventArgs e)
        {
            inventoryLoadData(0);
        }
        private void btnInventoryImportAdd_Click(object sender, EventArgs e)
        {
            using (var form = new InventoryImportEdit(mode.Add))
            {
                panelInventory.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelInventory.Visible = true;
                panelMask.Visible = false;
            }
            inventoryInitial();
        }
        private void btnInventoryExportAdd_Click(object sender, EventArgs e)
        {
            using (var form = new InventoryExportEdit(mode.Add))
            {
                panelInventory.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelInventory.Visible = true;
                panelMask.Visible = false;
            }
            inventoryInitial();
        }
        private void btnInventoryReturnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new InventoryReturnEdit(mode.Add))
            {
                panelInventory.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelInventory.Visible = true;
                panelMask.Visible = false;
            }
            inventoryInitial();
        }
        private void btnInventoryModify_Click(object sender, EventArgs e)
        {
            if (this.dgvInventory.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvInventory.SelectedRows[0];
                using (var form = new PickInventoryVendor(mode.Edit, row.Cells["dgvInventory_Serno"].Value.ToString()))
                {
                    panelInventory.Visible = false;
                    panelMask.Visible = true;
                    var result = form.ShowDialog();
                    panelInventory.Visible = true;
                    panelMask.Visible = false;
                }
                inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
            }
        }
        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventory.SelectedRows.Count > 0)
                {
                    List<string> sernolist = new List<string>();
                    string delSernoList = "";
                    foreach (DataGridViewRow row in dgvInventory.SelectedRows)
                    {
                        sernolist.Add(row.Cells["dgvInventory_Serno"].Value.ToString());
                    }
                    delSernoList = APConfig.sqlArrayFormat(string.Join(",", sernolist));

                    using (var form = new PickInventoryDelete(mode.View, delSernoList))
                    {
                        panelInventory.Visible = false;
                        panelMask.Visible = true;
                        var result = form.ShowDialog();
                        panelInventory.Visible = true;
                        panelMask.Visible = false;
                    }
                    inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
                }
            }
            catch (Exception ex)
            {
                APConfig.SweetAlert(ShowBoxType.alert, string.Format("刪除失敗 {0}", ex.Message));
            }

        }
        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgvInventory.SelectedRows[0];
            using (var form = new PickInventoryVendor(mode.View, row.Cells["dgvInventory_Serno"].Value.ToString()))
            {
                panelInventory.Visible = false;
                panelMask.Visible = true;
                var result = form.ShowDialog();
                panelInventory.Visible = true;
                panelMask.Visible = false;
            }
        }
        private void btnInventoryRight_Click(object sender, EventArgs e)
        {
            if (APConfig.nextPage(ref ddlInventoryPage))
                inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
        }
        private void btnInventoryLeft_Click(object sender, EventArgs e)
        {
            if (APConfig.prevPage(ref ddlInventoryPage))
                inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
        }
        private void ddlInventoryPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlInventoryPage.SelectedIndex == -1) return;
            inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
        }
        private void dgvInventory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 || dgvInventory.RowCount == 0) return;
            inventoryLoadData(ddlInventoryPage.SelectedIndex + 1);
        }
        #endregion

        #region Main
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (APConfig.SweetAlert(ShowBoxType.confirm, "確定要離開嗎?"))
            {
                this.Close();
                Environment.Exit(Environment.ExitCode);
            }
        }
        private void ShowMainPanel(Panel showPanel)
        {
            panelInventory.Visible = false;
            panelPhrase.Visible = false;

            showPanel.Visible = true;
        }

        private void btnPhrase_Click(object sender, EventArgs e)
        {
            panelStats.Height = btnPhrase.Height;
            panelStats.Top = btnPhrase.Top;
            ShowMainPanel(panelPhrase);
            lblBarTitle.Text = "交易參數";
            phraseInitial();
            phraseLoadData();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            panelStats.Height = btnInventory.Height;
            panelStats.Top = btnInventory.Top;
            ShowMainPanel(panelInventory);
            lblBarTitle.Text = "進銷存專區";
            inventoryInitial();
        }

        #endregion

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

        #region 備份
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            if (APConfig.SweetAlert(ShowBoxType.confirm, "是否確定要備份?"))
            {
                try
                {
                    SqlConnection conn = new SqlConnection(APConfig.Conn.getConnectionString());
                    SqlCommand cmd = new SqlCommand(string.Empty, conn);
                    conn.Open();

                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_BackupData";

                    SqlParameter result = cmd.Parameters.Add("@result", SqlDbType.Int);
                    result.Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    if (Convert.ToInt32(result.Value) == 1)
                        APConfig.SweetAlert(ShowBoxType.alert, "備份成功!");
                    else
                        APConfig.SweetAlert(ShowBoxType.alert, "備份失敗!");


                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    APConfig.SweetAlert(ShowBoxType.alert, string.Format("備份失敗!{0}", ex.Message));
                }
            }
        }
        #endregion

    }
}
