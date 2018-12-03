namespace Speed
{
    partial class InventoryExportEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryExportEdit));
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.txtImportAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtImportComment = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.dpkImportDTTM = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dpkExportDTTM = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExportComment = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExportAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlDealer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnItemPick = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnItemDel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnItemAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnOK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtColor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtType = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvItem_Serno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_Dealer = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label2.Text = "出貨單";
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
            // txtImportAmount
            // 
            this.txtImportAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtImportAmount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtImportAmount.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtImportAmount.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txtImportAmount.BorderThickness = 2;
            this.txtImportAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImportAmount.Enabled = false;
            this.txtImportAmount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportAmount.ForeColor = System.Drawing.Color.Black;
            this.txtImportAmount.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtImportAmount.isPassword = false;
            this.txtImportAmount.Location = new System.Drawing.Point(117, 213);
            this.txtImportAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtImportAmount.Name = "txtImportAmount";
            this.txtImportAmount.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtImportAmount.Size = new System.Drawing.Size(160, 30);
            this.txtImportAmount.TabIndex = 3;
            this.txtImportAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(37, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 19);
            this.label11.TabIndex = 71;
            this.label11.Text = "進貨金額:";
            // 
            // txtImportComment
            // 
            this.txtImportComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtImportComment.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtImportComment.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtImportComment.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txtImportComment.BorderThickness = 2;
            this.txtImportComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImportComment.Enabled = false;
            this.txtImportComment.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportComment.ForeColor = System.Drawing.Color.Black;
            this.txtImportComment.isPassword = false;
            this.txtImportComment.Location = new System.Drawing.Point(117, 253);
            this.txtImportComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtImportComment.Name = "txtImportComment";
            this.txtImportComment.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtImportComment.Size = new System.Drawing.Size(450, 30);
            this.txtImportComment.TabIndex = 4;
            this.txtImportComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(37, 259);
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
            this.dgvItem_Serno,
            this.dgvItem_Code,
            this.dgvItem_Name,
            this.dgvItem_Type,
            this.dgvItem_Color,
            this.dgvItem_Amount,
            this.dgvItem_Dealer,
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
            this.dgvItem.Location = new System.Drawing.Point(41, 460);
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
            this.dgvItem.Size = new System.Drawing.Size(533, 202);
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
            this.label4.Location = new System.Drawing.Point(321, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 91;
            this.label4.Text = "進貨日期:";
            // 
            // dpkImportDTTM
            // 
            this.dpkImportDTTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dpkImportDTTM.BorderRadius = 0;
            this.dpkImportDTTM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpkImportDTTM.ForeColor = System.Drawing.Color.DimGray;
            this.dpkImportDTTM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkImportDTTM.FormatCustom = null;
            this.dpkImportDTTM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dpkImportDTTM.Location = new System.Drawing.Point(402, 211);
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
            this.lblTotalAmt.Location = new System.Drawing.Point(420, 677);
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
            this.label3.Location = new System.Drawing.Point(321, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "商品型號:";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtCode.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCode.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txtCode.BorderThickness = 2;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtCode.isPassword = false;
            this.txtCode.Location = new System.Drawing.Point(117, 127);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtCode.Size = new System.Drawing.Size(160, 30);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtName.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(402, 127);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtName.Size = new System.Drawing.Size(160, 30);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dpkExportDTTM
            // 
            this.dpkExportDTTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dpkExportDTTM.BorderRadius = 0;
            this.dpkExportDTTM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpkExportDTTM.ForeColor = System.Drawing.Color.DimGray;
            this.dpkExportDTTM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkExportDTTM.FormatCustom = null;
            this.dpkExportDTTM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dpkExportDTTM.Location = new System.Drawing.Point(402, 331);
            this.dpkExportDTTM.Name = "dpkExportDTTM";
            this.dpkExportDTTM.Size = new System.Drawing.Size(160, 35);
            this.dpkExportDTTM.TabIndex = 119;
            this.dpkExportDTTM.Value = new System.DateTime(2018, 6, 30, 3, 42, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(317, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 120;
            this.label5.Text = "出貨日期:";
            // 
            // txtExportComment
            // 
            this.txtExportComment.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtExportComment.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtExportComment.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtExportComment.BorderThickness = 2;
            this.txtExportComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExportComment.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExportComment.ForeColor = System.Drawing.Color.Black;
            this.txtExportComment.isPassword = false;
            this.txtExportComment.Location = new System.Drawing.Point(117, 374);
            this.txtExportComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtExportComment.Name = "txtExportComment";
            this.txtExportComment.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtExportComment.Size = new System.Drawing.Size(450, 30);
            this.txtExportComment.TabIndex = 13;
            this.txtExportComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 118;
            this.label6.Text = "出貨備註:";
            // 
            // txtExportAmount
            // 
            this.txtExportAmount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtExportAmount.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtExportAmount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtExportAmount.BorderThickness = 2;
            this.txtExportAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExportAmount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExportAmount.ForeColor = System.Drawing.Color.Black;
            this.txtExportAmount.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtExportAmount.isPassword = false;
            this.txtExportAmount.Location = new System.Drawing.Point(117, 333);
            this.txtExportAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtExportAmount.Name = "txtExportAmount";
            this.txtExportAmount.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtExportAmount.Size = new System.Drawing.Size(160, 30);
            this.txtExportAmount.TabIndex = 12;
            this.txtExportAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(37, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 117;
            this.label7.Text = "出貨金額:";
            // 
            // ddlDealer
            // 
            this.ddlDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ddlDealer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlDealer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDealer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlDealer.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.ddlDealer.ForeColor = System.Drawing.Color.DimGray;
            this.ddlDealer.FormattingEnabled = true;
            this.ddlDealer.Items.AddRange(new object[] {
            "劉居政",
            "劉奇信"});
            this.ddlDealer.Location = new System.Drawing.Point(117, 293);
            this.ddlDealer.Name = "ddlDealer";
            this.ddlDealer.Size = new System.Drawing.Size(160, 27);
            this.ddlDealer.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(37, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 122;
            this.label8.Text = "出貨人員:";
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
            this.btnItemPick.Location = new System.Drawing.Point(188, 72);
            this.btnItemPick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnItemPick.Name = "btnItemPick";
            this.btnItemPick.Size = new System.Drawing.Size(80, 42);
            this.btnItemPick.TabIndex = 10;
            this.btnItemPick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnItemPick.Click += new System.EventHandler(this.btnItemPick_Click);
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
            this.btnClear.Location = new System.Drawing.Point(488, 412);
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
            this.btnItemDel.Location = new System.Drawing.Point(403, 412);
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
            this.btnItemAdd.Location = new System.Drawing.Point(318, 412);
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
            this.btnOK.Location = new System.Drawing.Point(270, 710);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 41);
            this.btnOK.TabIndex = 64;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtColor.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtColor.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtColor.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txtColor.BorderThickness = 2;
            this.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColor.Enabled = false;
            this.txtColor.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.Black;
            this.txtColor.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtColor.isPassword = false;
            this.txtColor.Location = new System.Drawing.Point(402, 169);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtColor.Size = new System.Drawing.Size(160, 30);
            this.txtColor.TabIndex = 129;
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(322, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 130;
            this.label9.Text = "商品顏色:";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtType.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.txtType.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtType.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txtType.BorderThickness = 2;
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.Enabled = false;
            this.txtType.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtType.isPassword = false;
            this.txtType.Location = new System.Drawing.Point(117, 170);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtType.Size = new System.Drawing.Size(160, 30);
            this.txtType.TabIndex = 127;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(37, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 128;
            this.label10.Text = "商頻類別:";
            // 
            // dgvItem_Serno
            // 
            this.dgvItem_Serno.HeaderText = "Serno";
            this.dgvItem_Serno.Name = "dgvItem_Serno";
            this.dgvItem_Serno.ReadOnly = true;
            this.dgvItem_Serno.Visible = false;
            // 
            // dgvItem_Code
            // 
            this.dgvItem_Code.HeaderText = "供應商";
            this.dgvItem_Code.Name = "dgvItem_Code";
            this.dgvItem_Code.ReadOnly = true;
            this.dgvItem_Code.Width = 150;
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
            // dgvItem_Amount
            // 
            this.dgvItem_Amount.HeaderText = "出貨金額";
            this.dgvItem_Amount.Name = "dgvItem_Amount";
            this.dgvItem_Amount.ReadOnly = true;
            this.dgvItem_Amount.Width = 130;
            // 
            // dgvItem_Dealer
            // 
            this.dgvItem_Dealer.HeaderText = "出貨人員";
            this.dgvItem_Dealer.Name = "dgvItem_Dealer";
            this.dgvItem_Dealer.ReadOnly = true;
            // 
            // dgvItem_ImportDTTM
            // 
            this.dgvItem_ImportDTTM.HeaderText = "出貨日期";
            this.dgvItem_ImportDTTM.Name = "dgvItem_ImportDTTM";
            this.dgvItem_ImportDTTM.ReadOnly = true;
            // 
            // dgvItem_Comment
            // 
            this.dgvItem_Comment.HeaderText = "出貨備註";
            this.dgvItem_Comment.Name = "dgvItem_Comment";
            this.dgvItem_Comment.ReadOnly = true;
            // 
            // InventoryExportEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(602, 759);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ddlDealer);
            this.Controls.Add(this.dpkExportDTTM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExportComment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtExportAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnItemPick);
            this.Controls.Add(this.lblTotalAmt);
            this.Controls.Add(this.dpkImportDTTM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnItemDel);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.txtImportComment);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtImportAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryExportEdit";
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
        private Bunifu.Framework.UI.BunifuMetroTextbox txtImportAmount;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtImportComment;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvItem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnItemDel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnItemAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker dpkImportDTTM;
        private System.Windows.Forms.Label lblTotalAmt;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnItemPick;
        private Bunifu.Framework.UI.BunifuDatepicker dpkExportDTTM;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtExportComment;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtExportAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlDealer;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtColor;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Serno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Dealer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_ImportDTTM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItem_Comment;
    }
}