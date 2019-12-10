namespace qlnt
{
    partial class FormBangThuHoach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBangThuHoach));
            this.dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThuHoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanLuongThuHoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanLuongThietHai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaBang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblThem = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.lblTim = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.comboBoxThang = new System.Windows.Forms.ComboBox();
            this.bunifuImageButtonSearch = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNV,
            this.NgayThuHoach,
            this.SanLuongThuHoach,
            this.SanLuongThietHai,
            this.Xem,
            this.MaBang});
            this.dataGrid.DoubleBuffered = true;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.Silver;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataGrid.Location = new System.Drawing.Point(40, 190);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.Size = new System.Drawing.Size(987, 363);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellMouseLeave);
            this.dataGrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_CellMouseMove);
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgayThuHoach
            // 
            this.NgayThuHoach.DataPropertyName = "NgayThuHoach";
            this.NgayThuHoach.HeaderText = "Ngày thu hoạch";
            this.NgayThuHoach.Name = "NgayThuHoach";
            this.NgayThuHoach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NgayThuHoach.Width = 120;
            // 
            // SanLuongThuHoach
            // 
            this.SanLuongThuHoach.DataPropertyName = "SanLuongThuHoach";
            this.SanLuongThuHoach.HeaderText = "Tổng sản lượng thu hoạch";
            this.SanLuongThuHoach.Name = "SanLuongThuHoach";
            this.SanLuongThuHoach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SanLuongThuHoach.Width = 130;
            // 
            // SanLuongThietHai
            // 
            this.SanLuongThietHai.DataPropertyName = "SanLuongThietHai";
            this.SanLuongThietHai.HeaderText = "Tổng sản lượng thiệt hại";
            this.SanLuongThietHai.Name = "SanLuongThietHai";
            this.SanLuongThietHai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SanLuongThietHai.Width = 130;
            // 
            // Xem
            // 
            this.Xem.HeaderText = "Xem";
            this.Xem.Name = "Xem";
            this.Xem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xem.Text = "Xem";
            this.Xem.UseColumnTextForButtonValue = true;
            this.Xem.Width = 50;
            // 
            // MaBang
            // 
            this.MaBang.DataPropertyName = "MaBang";
            this.MaBang.HeaderText = "Column1";
            this.MaBang.Name = "MaBang";
            this.MaBang.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTitle.Location = new System.Drawing.Point(112, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 42);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Bảng thu hoạch nông sản";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(663, 119);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 30;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lblThem
            // 
            this.lblThem.AutoSize = true;
            this.lblThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblThem.Location = new System.Drawing.Point(713, 126);
            this.lblThem.Name = "lblThem";
            this.lblThem.Size = new System.Drawing.Size(65, 24);
            this.lblThem.TabIndex = 31;
            this.lblThem.Text = "Thêm ";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1052, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 32;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Location = new System.Drawing.Point(477, 131);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(68, 21);
            this.comboBoxNam.TabIndex = 33;
            this.comboBoxNam.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTim.Location = new System.Drawing.Point(89, 126);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(103, 28);
            this.lblTim.TabIndex = 35;
            this.lblTim.Text = "Tìm kiếm";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(261, 129);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(64, 23);
            this.lblThang.TabIndex = 36;
            this.lblThang.Text = "Tháng";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(421, 130);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(51, 24);
            this.lblNam.TabIndex = 37;
            this.lblNam.Text = "Năm";
            this.lblNam.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.Location = new System.Drawing.Point(332, 131);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(64, 21);
            this.comboBoxThang.TabIndex = 34;
            // 
            // bunifuImageButtonSearch
            // 
            this.bunifuImageButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonSearch.Image")));
            this.bunifuImageButtonSearch.ImageActive = null;
            this.bunifuImageButtonSearch.Location = new System.Drawing.Point(570, 129);
            this.bunifuImageButtonSearch.Name = "bunifuImageButtonSearch";
            this.bunifuImageButtonSearch.Size = new System.Drawing.Size(40, 25);
            this.bunifuImageButtonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonSearch.TabIndex = 38;
            this.bunifuImageButtonSearch.TabStop = false;
            this.bunifuImageButtonSearch.Zoom = 10;
            this.bunifuImageButtonSearch.Click += new System.EventHandler(this.bunifuImageButtonSearch_Click);
            // 
            // FormBangThuHoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.bunifuImageButtonSearch);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.comboBoxThang);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.lblThem);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBangThuHoach";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblThem;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox comboBoxThang;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThuHoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanLuongThuHoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanLuongThietHai;
        private System.Windows.Forms.DataGridViewButtonColumn Xem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBang;
    }
}