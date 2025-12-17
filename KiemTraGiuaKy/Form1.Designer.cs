namespace KiemTraGiuaKy
{
    partial class Form1
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
            this.lblTinhHinh = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtSoCaNhiemMoi = new System.Windows.Forms.TextBox();
            this.txtTenDP = new System.Windows.Forms.TextBox();
            this.txtMaDP = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSoCaNhiemMoi = new System.Windows.Forms.Label();
            this.lblTenDP = new System.Windows.Forms.Label();
            this.lblMaDP = new System.Windows.Forms.Label();
            this.dgvTinhHinhDP = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colMaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaNhiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhHinhDP)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTinhHinh
            // 
            this.lblTinhHinh.AutoSize = true;
            this.lblTinhHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhHinh.ForeColor = System.Drawing.Color.Blue;
            this.lblTinhHinh.Location = new System.Drawing.Point(323, 59);
            this.lblTinhHinh.Name = "lblTinhHinh";
            this.lblTinhHinh.Size = new System.Drawing.Size(382, 38);
            this.lblTinhHinh.TabIndex = 0;
            this.lblTinhHinh.Text = "Tình hình dịch Covid-19";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnCapNhat);
            this.grbThongTin.Controls.Add(this.btnThem);
            this.grbThongTin.Controls.Add(this.cbbTrangThai);
            this.grbThongTin.Controls.Add(this.txtSoCaNhiemMoi);
            this.grbThongTin.Controls.Add(this.txtTenDP);
            this.grbThongTin.Controls.Add(this.txtMaDP);
            this.grbThongTin.Controls.Add(this.lblTrangThai);
            this.grbThongTin.Controls.Add(this.lblSoCaNhiemMoi);
            this.grbThongTin.Controls.Add(this.lblTenDP);
            this.grbThongTin.Controls.Add(this.lblMaDP);
            this.grbThongTin.Location = new System.Drawing.Point(21, 115);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(348, 287);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin địa phương";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(223, 248);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 23);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật ";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(126, 248);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "1"});
            this.cbbTrangThai.Location = new System.Drawing.Point(126, 194);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(205, 24);
            this.cbbTrangThai.TabIndex = 8;
            // 
            // txtSoCaNhiemMoi
            // 
            this.txtSoCaNhiemMoi.Location = new System.Drawing.Point(126, 148);
            this.txtSoCaNhiemMoi.Name = "txtSoCaNhiemMoi";
            this.txtSoCaNhiemMoi.Size = new System.Drawing.Size(100, 22);
            this.txtSoCaNhiemMoi.TabIndex = 7;
            // 
            // txtTenDP
            // 
            this.txtTenDP.Location = new System.Drawing.Point(126, 101);
            this.txtTenDP.Name = "txtTenDP";
            this.txtTenDP.Size = new System.Drawing.Size(206, 22);
            this.txtTenDP.TabIndex = 6;
            // 
            // txtMaDP
            // 
            this.txtMaDP.Location = new System.Drawing.Point(126, 49);
            this.txtMaDP.Name = "txtMaDP";
            this.txtMaDP.Size = new System.Drawing.Size(100, 22);
            this.txtMaDP.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(18, 197);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(73, 16);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // lblSoCaNhiemMoi
            // 
            this.lblSoCaNhiemMoi.AutoSize = true;
            this.lblSoCaNhiemMoi.Location = new System.Drawing.Point(6, 148);
            this.lblSoCaNhiemMoi.Name = "lblSoCaNhiemMoi";
            this.lblSoCaNhiemMoi.Size = new System.Drawing.Size(106, 16);
            this.lblSoCaNhiemMoi.TabIndex = 3;
            this.lblSoCaNhiemMoi.Text = "Số ca nhiễm mới";
            // 
            // lblTenDP
            // 
            this.lblTenDP.AutoSize = true;
            this.lblTenDP.Location = new System.Drawing.Point(13, 101);
            this.lblTenDP.Name = "lblTenDP";
            this.lblTenDP.Size = new System.Drawing.Size(103, 16);
            this.lblTenDP.TabIndex = 2;
            this.lblTenDP.Text = "Tên Địa Phương";
            // 
            // lblMaDP
            // 
            this.lblMaDP.AutoSize = true;
            this.lblMaDP.Location = new System.Drawing.Point(18, 49);
            this.lblMaDP.Name = "lblMaDP";
            this.lblMaDP.Size = new System.Drawing.Size(98, 16);
            this.lblMaDP.TabIndex = 1;
            this.lblMaDP.Text = "Mã Địa Phương";
            // 
            // dgvTinhHinhDP
            // 
            this.dgvTinhHinhDP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhHinhDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhHinhDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDP,
            this.colTenDP,
            this.colCaNhiem,
            this.colTenTT});
            this.dgvTinhHinhDP.Location = new System.Drawing.Point(387, 121);
            this.dgvTinhHinhDP.Name = "dgvTinhHinhDP";
            this.dgvTinhHinhDP.RowHeadersWidth = 51;
            this.dgvTinhHinhDP.RowTemplate.Height = 24;
            this.dgvTinhHinhDP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTinhHinhDP.Size = new System.Drawing.Size(759, 385);
            this.dgvTinhHinhDP.TabIndex = 2;
            this.dgvTinhHinhDP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTinhHinhDP_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem,
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem,
            this.toolStripSeparator1,
            this.xuấtToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // sắpXếpTheoSốCaNhiễmToolStripMenuItem
            // 
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem.Name = "sắpXếpTheoSốCaNhiễmToolStripMenuItem";
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem.Text = "Sắp xếp theo số ca nhiễm";
            this.sắpXếpTheoSốCaNhiễmToolStripMenuItem.Click += new System.EventHandler(this.sắpXếpTheoSốCaNhiễmToolStripMenuItem_Click);
            // 
            // cácĐịaPhươngNhómNguyCơToolStripMenuItem
            // 
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem.Name = "cácĐịaPhươngNhómNguyCơToolStripMenuItem";
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem.Text = "Các địa phương nhóm nguy cơ";
            this.cácĐịaPhươngNhómNguyCơToolStripMenuItem.Click += new System.EventHandler(this.cácĐịaPhươngNhómNguyCơToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(316, 6);
            // 
            // xuấtToolStripMenuItem
            // 
            this.xuấtToolStripMenuItem.Name = "xuấtToolStripMenuItem";
            this.xuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuấtToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.xuấtToolStripMenuItem.Text = "Xuất báo cáo";
            // 
            // colMaDP
            // 
            this.colMaDP.DataPropertyName = "MaDP";
            this.colMaDP.HeaderText = "MĐP";
            this.colMaDP.MinimumWidth = 6;
            this.colMaDP.Name = "colMaDP";
            // 
            // colTenDP
            // 
            this.colTenDP.DataPropertyName = "TenDP";
            this.colTenDP.HeaderText = "Tên ĐP ";
            this.colTenDP.MinimumWidth = 6;
            this.colTenDP.Name = "colTenDP";
            // 
            // colCaNhiem
            // 
            this.colCaNhiem.DataPropertyName = "SoCaNhiemMoi";
            this.colCaNhiem.HeaderText = "Ca nhiễm";
            this.colCaNhiem.MinimumWidth = 6;
            this.colCaNhiem.Name = "colCaNhiem";
            // 
            // colTenTT
            // 
            this.colTenTT.DataPropertyName = "TenTT";
            this.colTenTT.HeaderText = "Trạng Thái";
            this.colTenTT.MinimumWidth = 6;
            this.colTenTT.Name = "colTenTT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 549);
            this.Controls.Add(this.dgvTinhHinhDP);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lblTinhHinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Thông Tin Địa Phương";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhHinhDP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTinhHinh;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.TextBox txtSoCaNhiemMoi;
        private System.Windows.Forms.TextBox txtTenDP;
        private System.Windows.Forms.TextBox txtMaDP;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSoCaNhiemMoi;
        private System.Windows.Forms.Label lblTenDP;
        private System.Windows.Forms.Label lblMaDP;
        private System.Windows.Forms.DataGridView dgvTinhHinhDP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sắpXếpTheoSốCaNhiễmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cácĐịaPhươngNhómNguyCơToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem xuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaNhiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTT;
    }
}

