namespace Speed
{
    partial class InventoryImportEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryImportEdit));
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.txtAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComment = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.dpkImportDTTM = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnItemDel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnItemAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnOK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ddlVendor = new System.Windows.Forms.ComboBox();
            this.btnItemPick = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtType = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSize = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvItem_Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_ImportDTTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(103, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "進貨單";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelBar.Controls.Add(this.lblClose);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(602, 32);
            this.panelBar.TabIndex = 66;
            this.panelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseDown);
            this.panelBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseMove);
            this.panelBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseUp);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(572, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 23);
            this.lblClose.TabIndex = 64;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtAmount.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAmount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtAmount.BorderThickness = 2;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtAmount.isPassword = false;
            this.txtAmount.Location = new System.Drawing.Point(117, 246);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtAmount.Size = new System.Drawing.Size(160, 30);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(37, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 71;
            this.label11.Text = "進貨金額:";
            // 
            // txtComment
            // 
            this.txtComment.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtComment.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtComment.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtComment.BorderThickness = 2;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.ForeColor = System.Drawing.Color.Black;
            this.txtComment.isPassword = false;
            this.txtComment.Location = new System.Drawing.Point(117, 286);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Name = "txtComment";
            this.txtComment.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtComment.Size = new System.Drawing.Size(450, 30);
            this.txtComment.TabIndex = 4;
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComment_KeyDown);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(37, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 19);
            this.label17.TabIndex = 80;
            this.label17.Text = "進貨備註:";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvItem_Vendor,
            this.dgvItem_Name,
            this.dgvItem_Type,
            this.dgvItem_Color,
            this.dgvItem_Size,
            this.dgvItem_Amount,
            this.dgvItem_ImportDTTM,
            this.dgvItem_Comment});
            this.dgvItem.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItem.DoubleBuffered = true;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.HeaderBgColor = System.Drawing.Color.Gray;
            this.dgvItem.HeaderForeColor = System.Drawing.Color.White;
            this.dgvItem.Location = new System.Drawing.Point(36, 376);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowHeadersWidth = 50;
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(533, 281);
            this.dgvItem.TabIndex = 87;
            this.dgvItem.DoubleClick += new System.EventHandler(this.dgvItem_DoubleClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(317, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 91;
            this.label4.Text = "進貨日期:";
            // 
            // dpkImportDTTM
            // 
            this.dpkImportDTTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dpkImportDTTM.BorderRadius = 0;
            this.dpkImportDTTM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpkImportDTTM.ForeColor = System.Drawing.Color.DimGray;
            this.dpkImportDTTM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkImportDTTM.FormatCustom = null;
            this.dpkImportDTTM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dpkImportDTTM.Location = new System.Drawing.Point(402, 245);
            this.dpkImportDTTM.Name = "dpkImportDTTM";
            this.dpkImportDTTM.Size = new System.Drawing.Size(160, 35);
            this.dpkImportDTTM.TabIndex = 91;
            this.dpkImportDTTM.Value = new System.DateTime(2018, 6, 30, 3, 42, 0, 0);
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmt.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmt.Location = new System.Drawing.Point(420, 670);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(90, 19);
            this.lblTotalAmt.TabIndex = 96;
            this.lblTotalAmt.Text = "總金額: 0 元";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "商品供應商:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "商品型號:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(117, 166);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtName.Size = new System.Drawing.Size(160, 30);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 30;
            this.btnClear.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "清除";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 30;
            this.btnClear.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.IdleForecolor = System.Drawing.Color.White;
            this.btnClear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.Location = new System.Drawing.Point(483, 328);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 42);
            this.btnClear.TabIndex = 113;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnItemDel
            // 
            this.btnItemDel.ActiveBorderThickness = 1;
            this.btnItemDel.ActiveCornerRadius = 30;
            this.btnItemDel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnItemDel.ActiveForecolor = System.Drawing.Color.White;
            this.btnItemDel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnItemDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnItemDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItemDel.BackgroundImage")));
            this.btnItemDel.ButtonText = "刪除";
            this.btnItemDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemDel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnItemDel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnItemDel.IdleBorderThickness = 1;
            this.btnItemDel.IdleCornerRadius = 30;
            this.btnItemDel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnItemDel.IdleForecolor = System.Drawing.Color.White;
            this.btnItemDel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnItemDel.Location = new System.Drawing.Point(397, 328);
            this.btnItemDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.Size = new System.Drawing.Size(80, 42);
            this.btnItemDel.TabIndex = 112;
            this.btnItemDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnItemDel.Click += new System.EventHandler(this.btnItemDel_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.ActiveBorderThickness = 1;
            this.btnItemAdd.ActiveCornerRadius = 30;
            this.btnItemAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnItemAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnItemAdd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnItemAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnItemAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.BackgroundImage")));
            this.btnItemAdd.ButtonText = "新增";
            this.btnItemAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemAdd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnItemAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnItemAdd.IdleBorderThickness = 1;
            this.btnItemAdd.IdleCornerRadius = 30;
            this.btnItemAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnItemAdd.IdleForecolor = System.Drawing.Color.White;
            this.btnItemAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(117)))));
            this.btnItemAdd.Location = new System.Drawing.Point(311, 328);
            this.btnItemAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(80, 42);
            this.btnItemAdd.TabIndex = 111;
            this.btnItemAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(32, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.ActiveBorderThickness = 1;
            this.btnOK.ActiveCornerRadius = 30;
            this.btnOK.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnOK.ActiveForecolor = System.Drawing.Color.White;
            this.btnOK.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.ButtonText = "待";
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOK.IdleBorderThickness = 1;
            this.btnOK.IdleCornerRadius = 30;
            this.btnOK.IdleFillColor = System.Drawing.Color.Gray;
            this.btnOK.IdleForecolor = System.Drawing.Color.White;
            this.btnOK.IdleLineColor = System.Drawing.Color.Gray;
            this.btnOK.Location = new System.Drawing.Point(265, 702);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 41);
            this.btnOK.TabIndex = 64;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ddlVendor
            // 
            this.ddlVendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ddlVendor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVendor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlVendor.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.ddlVendor.ForeColor = System.Drawing.Color.DimGray;
            this.ddlVendor.FormattingEnabled = true;
            this.ddlVendor.Items.AddRange(new object[] {
            "全部",
            "未處理",
            "未完成已付款",
            "已完成未付款",
            "已完成"});
            this.ddlVendor.Location = new System.Drawing.Point(116, 129);
            this.ddlVendor.Name = "ddlVendor";
            this.ddlVendor.Size = new System.Drawing.Size(160, 27);
            this.ddlVendor.TabIndex = 114;
            // 
            // btnItemPick
            // 
            this.btnItemPick.ActiveBorderThickness = 1;
            this.btnItemPick.ActiveCornerRadius = 30;
            this.btnItemPick.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnItemPick.ActiveForecolor = System.Drawing.Color.White;
            this.btnItemPick.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnItemPick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnItemPick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItemPick.BackgroundImage")));
            this.btnItemPick.ButtonText = "選取";
            this.btnItemPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemPick.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnItemPick.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnItemPick.IdleBorderThickness = 1;
            this.btnItemPick.IdleCornerRadius = 30;
            this.btnItemPick.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnItemPick.IdleForecolor = System.Drawing.Color.White;
            this.btnItemPick.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.btnItemPick.Location = new System.Drawing.Point(183, 72);
            this.btnItemPick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnItemPick.Name = "btnItemPick";
            this.btnItemPick.Size = new System.Drawing.Size(80, 42);
            this.btnItemPick.TabIndex = 115;
            this.btnItemPick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnItemPick.Click += new System.EventHandler(this.btnItemPick_Click);
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtType.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtType.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtType.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtType.BorderThickness = 2;
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.Enabled = false;
            this.txtType.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.isPassword = false;
            this.txtType.Location = new System.Drawing.Point(402, 166);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtType.Size = new System.Drawing.Size(160, 30);
            this.txtType.TabIndex = 116;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(321, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 117;
            this.label5.Text = "商品類別:";
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSize.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtSize.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSize.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtSize.BorderThickness = 2;
            this.txtSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSize.Enabled = false;
            this.txtSize.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.Black;
            this.txtSize.isPassword = false;
            this.txtSize.Location = new System.Drawing.Point(402, 206);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtSize.Size = new System.Drawing.Size(160, 30);
            this.txtSize.TabIndex = 120;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(321, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 121;
            this.label6.Text = "商品尺寸:";
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtColor.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtColor.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtColor.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtColor.BorderThickness = 2;
            this.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColor.Enabled = false;
            this.txtColor.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.Black;
            this.txtColor.isPassword = false;
            this.txtColor.Location = new System.Drawing.Point(117, 206);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtColor.Size = new System.Drawing.Size(160, 30);
            this.txtColor.TabIndex = 118;
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 119;
            this.label7.Text = "商品顏色:";
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
            this.dgvItem_Name.HeaderText = "商品型號";
            this.dgvItem_Name.Name = "dgvItem_Name";
            this.dgvItem_Name.ReadOnly = true;
            this.dgvItem_Name.Width = 150;
            // 
            // dgvItem_Type
            // 
            this.dgvItem_Type.HeaderText = "商品類別";
            this.dgvItem_Type.Name = "dgvItem_Type";
            this.dgvItem_Type.ReadOnly = true;
            // 
            // dgvItem_Color
            // 
            this.dgvItem_Color.HeaderText = "商品顏色";
            this.dgvItem_Color.Name = "dgvItem_Color";
            this.dgvItem_Color.ReadOnly = true;
            // 
            // dgvItem_Size
            // 
            this.dgvItem_Size.HeaderText = "商品尺寸";
            this.dgvItem_Size.Name = "dgvItem_Size";
            this.dgvItem_Size.ReadOnly = true;
            // 
            // dgvItem_Amount
            // 
            this.dgvItem_Amount.HeaderText = "進貨金額";
            this.dgvItem_Amount.Name = "dgvItem_Amount";
            this.dgvItem_Amount.ReadOnly = true;
            this.dgvItem_Amount.Width = 130;
            // 
            // dgvItem_ImportDTTM
            // 
            this.dgvItem_ImportDTTM.HeaderText = "進貨日期";
            this.dgvItem_ImportDTTM.Name = "dgvItem_ImportDTTM";
            this.dgvItem_ImportDTTM.ReadOnly = true;
            // 
            // dgvItem_Comment
            // 
            this.dgvItem_Comment.HeaderText = "進貨備註";
            this.dgvItem_Comment.Name = "dgvItem_Comment";
            this.dgvItem_Comment.ReadOnly = true;
            // 
            // InventoryImportEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(602, 781);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnItemPick);
            this.Controls.Add(this.ddlVendor);
            this.Controls.Add(this.lblTotalAmt);
            this.Controls.Add(this.dpkImportDTTM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnItemDel);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryImportEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MemberEdit";
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOK;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label lblClose;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAmount;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtComment;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvItem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnItemDel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnItemAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker dpkImportDTTM;
        private System.Windows.Forms.Label lblTotalAmt;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlVendor;
        private Bunifu.Framework.UI.BunifuThinButton2 btnItemPick;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSize;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtColor;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_ImportDTTM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Comment;
    }
}