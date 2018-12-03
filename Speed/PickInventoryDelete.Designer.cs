namespace Speed
{
    partial class PickInventoryDelete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickInventoryDelete));
            this.btnMemberAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.dgvInventory = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvInventory_Serno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventory_Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvInventory_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventory_Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventory_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventory_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventory_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInventory_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
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
            this.panelBar.Size = new System.Drawing.Size(736, 32);
            this.panelBar.TabIndex = 63;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(702, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 23);
            this.lblClose.TabIndex = 64;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvInventory_Serno,
            this.dgvInventory_Checkbox,
            this.dgvInventory_Status,
            this.dgvInventory_Vendor,
            this.dgvInventory_Name,
            this.dgvInventory_Type,
            this.dgvInventory_Color,
            this.dgvInventory_Size});
            this.dgvInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvInventory.DoubleBuffered = true;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(193)))));
            this.dgvInventory.HeaderForeColor = System.Drawing.Color.White;
            this.dgvInventory.Location = new System.Drawing.Point(0, 30);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 50;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(736, 397);
            this.dgvInventory.TabIndex = 66;
            this.dgvInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellDoubleClick);
            // 
            // dgvInventory_Serno
            // 
            this.dgvInventory_Serno.HeaderText = "Serno";
            this.dgvInventory_Serno.Name = "dgvInventory_Serno";
            this.dgvInventory_Serno.Visible = false;
            // 
            // dgvInventory_Checkbox
            // 
            this.dgvInventory_Checkbox.HeaderText = "";
            this.dgvInventory_Checkbox.Name = "dgvInventory_Checkbox";
            this.dgvInventory_Checkbox.Width = 30;
            // 
            // dgvInventory_Status
            // 
            this.dgvInventory_Status.HeaderText = "狀態";
            this.dgvInventory_Status.Name = "dgvInventory_Status";
            // 
            // dgvInventory_Vendor
            // 
            this.dgvInventory_Vendor.HeaderText = "商品供應商";
            this.dgvInventory_Vendor.Name = "dgvInventory_Vendor";
            // 
            // dgvInventory_Name
            // 
            this.dgvInventory_Name.HeaderText = "商品型號";
            this.dgvInventory_Name.Name = "dgvInventory_Name";
            this.dgvInventory_Name.Width = 200;
            // 
            // dgvInventory_Type
            // 
            this.dgvInventory_Type.HeaderText = "商品類別";
            this.dgvInventory_Type.Name = "dgvInventory_Type";
            // 
            // dgvInventory_Color
            // 
            this.dgvInventory_Color.HeaderText = "商品顏色";
            this.dgvInventory_Color.Name = "dgvInventory_Color";
            // 
            // dgvInventory_Size
            // 
            this.dgvInventory_Size.HeaderText = "商品尺寸";
            this.dgvInventory_Size.Name = "dgvInventory_Size";
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 30;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "刪 除";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 30;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnDelete.IdleForecolor = System.Drawing.Color.White;
            this.btnDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(113)))));
            this.btnDelete.Location = new System.Drawing.Point(328, 438);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 42);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Checked = true;
            this.ckbAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAll.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckbAll.Location = new System.Drawing.Point(12, 452);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(58, 23);
            this.ckbAll.TabIndex = 68;
            this.ckbAll.Text = "全選";
            this.ckbAll.UseVisualStyleBackColor = true;
            this.ckbAll.CheckedChanged += new System.EventHandler(this.ckbAll_CheckedChanged);
            // 
            // PickInventoryDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(736, 487);
            this.Controls.Add(this.ckbAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.btnMemberAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PickInventoryDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberEdit";
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnMemberAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label lblClose;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInventory;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventory_Serno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvInventory_Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventory_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventory_Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventory_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventory_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventory_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInventory_Size;
        private System.Windows.Forms.CheckBox ckbAll;
    }
}