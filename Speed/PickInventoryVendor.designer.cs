namespace Speed
{
    partial class PickInventoryVendor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMemberAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.dgvItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvItem_Serno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_INAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_INDTTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_OUTAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_OUTDTTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnMemberAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMemberAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMemberAdd.BorderRadius = 0;
            this.btnMemberAdd.ButtonText = "Add";
            this.btnMemberAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMemberAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnMemberAdd.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemberAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMemberAdd.Iconimage = null;
            this.btnMemberAdd.Iconimage_right = null;
            this.btnMemberAdd.Iconimage_right_Selected = null;
            this.btnMemberAdd.Iconimage_Selected = null;
            this.btnMemberAdd.IconMarginLeft = 0;
            this.btnMemberAdd.IconMarginRight = 0;
            this.btnMemberAdd.IconRightVisible = true;
            this.btnMemberAdd.IconRightZoom = 0D;
            this.btnMemberAdd.IconVisible = true;
            this.btnMemberAdd.IconZoom = 90D;
            this.btnMemberAdd.IsTab = false;
            this.btnMemberAdd.Location = new System.Drawing.Point(363, 612);
            this.btnMemberAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnMemberAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnMemberAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMemberAdd.selected = false;
            this.btnMemberAdd.Size = new System.Drawing.Size(109, 46);
            this.btnMemberAdd.TabIndex = 45;
            this.btnMemberAdd.Text = "Add";
            this.btnMemberAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMemberAdd.Textcolor = System.Drawing.Color.White;
            this.btnMemberAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.Gray;
            this.panelBar.Controls.Add(this.lblClose);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(802, 32);
            this.panelBar.TabIndex = 63;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(775, 6);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 23);
            this.lblClose.TabIndex = 64;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItem_Serno,
            this.dgvItem_Status,
            this.dgvItem_Vendor,
            this.dgvItem_Name,
            this.dgvItem_INAMT,
            this.dgvItem_INDTTM,
            this.dgvItem_OUTAMT,
            this.dgvItem_OUTDTTM});
            this.dgvItem.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItem.DoubleBuffered = true;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.dgvItem.HeaderForeColor = System.Drawing.Color.White;
            this.dgvItem.Location = new System.Drawing.Point(0, 32);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowHeadersWidth = 50;
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(802, 436);
            this.dgvItem.TabIndex = 89;
            this.dgvItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellDoubleClick);
            // 
            // dgvItem_Serno
            // 
            this.dgvItem_Serno.HeaderText = "序號";
            this.dgvItem_Serno.Name = "dgvItem_Serno";
            this.dgvItem_Serno.ReadOnly = true;
            this.dgvItem_Serno.Visible = false;
            // 
            // dgvItem_Status
            // 
            this.dgvItem_Status.HeaderText = "狀態";
            this.dgvItem_Status.Name = "dgvItem_Status";
            this.dgvItem_Status.ReadOnly = true;
            // 
            // dgvItem_Vendor
            // 
            this.dgvItem_Vendor.HeaderText = "商品供應商";
            this.dgvItem_Vendor.Name = "dgvItem_Vendor";
            this.dgvItem_Vendor.ReadOnly = true;
            this.dgvItem_Vendor.Width = 150;
            // 
            // dgvItem_Name
            // 
            this.dgvItem_Name.HeaderText = "商品名稱";
            this.dgvItem_Name.Name = "dgvItem_Name";
            this.dgvItem_Name.ReadOnly = true;
            this.dgvItem_Name.Width = 150;
            // 
            // dgvItem_INAMT
            // 
            this.dgvItem_INAMT.HeaderText = "進貨金額";
            this.dgvItem_INAMT.Name = "dgvItem_INAMT";
            this.dgvItem_INAMT.ReadOnly = true;
            // 
            // dgvItem_INDTTM
            // 
            this.dgvItem_INDTTM.HeaderText = "進貨日期";
            this.dgvItem_INDTTM.Name = "dgvItem_INDTTM";
            this.dgvItem_INDTTM.ReadOnly = true;
            // 
            // dgvItem_OUTAMT
            // 
            this.dgvItem_OUTAMT.HeaderText = "出貨金額";
            this.dgvItem_OUTAMT.Name = "dgvItem_OUTAMT";
            this.dgvItem_OUTAMT.ReadOnly = true;
            // 
            // dgvItem_OUTDTTM
            // 
            this.dgvItem_OUTDTTM.HeaderText = "出貨日期";
            this.dgvItem_OUTDTTM.Name = "dgvItem_OUTDTTM";
            this.dgvItem_OUTDTTM.ReadOnly = true;
            // 
            // PickInventoryVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(802, 468);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.btnMemberAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PickInventoryVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberEdit";
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnMemberAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label lblClose;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Serno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_INAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_INDTTM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_OUTAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_OUTDTTM;
    }
}