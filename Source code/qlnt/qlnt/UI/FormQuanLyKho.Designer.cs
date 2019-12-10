namespace qlnt.UI
{
    partial class FormQuanLyKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyKho));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThongBao = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textTen = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLoai = new System.Windows.Forms.ComboBox();
            this.comboBoxTT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(145, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thống kê mặt hàng trong kho";
            // 
            // dataGrid
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.Ten,
            this.SL,
            this.HanSD,
            this.TinhTrang,
            this.Loai});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid.DoubleBuffered = true;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataGrid.Location = new System.Drawing.Point(40, 231);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.Size = new System.Drawing.Size(711, 197);
            this.dataGrid.TabIndex = 28;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "id";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = false;
            this.MaKH.Width = 120;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.Width = 120;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng / Sản lượng(kg)";
            this.SL.Name = "SL";
            this.SL.Width = 150;
            // 
            // HanSD
            // 
            this.HanSD.DataPropertyName = "HanSD";
            this.HanSD.HeaderText = "Hạn sử dụng";
            this.HanSD.Name = "HanSD";
            this.HanSD.Width = 140;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 150;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "loai";
            this.Loai.HeaderText = "Loại";
            this.Loai.Name = "Loai";
            // 
            // btnXem
            // 
            this.btnXem.ActiveBorderThickness = 1;
            this.btnXem.ActiveCornerRadius = 20;
            this.btnXem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnXem.ActiveForecolor = System.Drawing.Color.White;
            this.btnXem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnXem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXem.BackgroundImage")));
            this.btnXem.ButtonText = "Xem tất cả";
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXem.IdleBorderThickness = 1;
            this.btnXem.IdleCornerRadius = 20;
            this.btnXem.IdleFillColor = System.Drawing.Color.White;
            this.btnXem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnXem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnXem.Location = new System.Drawing.Point(383, 115);
            this.btnXem.Margin = new System.Windows.Forms.Padding(5);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(126, 41);
            this.btnXem.TabIndex = 29;
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click_1);
            // 
            // btnThongBao
            // 
            this.btnThongBao.ActiveBorderThickness = 1;
            this.btnThongBao.ActiveCornerRadius = 20;
            this.btnThongBao.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnThongBao.ActiveForecolor = System.Drawing.Color.White;
            this.btnThongBao.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnThongBao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongBao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongBao.BackgroundImage")));
            this.btnThongBao.ButtonText = "Danh sách cần hủy";
            this.btnThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBao.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThongBao.IdleBorderThickness = 1;
            this.btnThongBao.IdleCornerRadius = 20;
            this.btnThongBao.IdleFillColor = System.Drawing.Color.White;
            this.btnThongBao.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnThongBao.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnThongBao.Location = new System.Drawing.Point(605, 115);
            this.btnThongBao.Margin = new System.Windows.Forms.Padding(5);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(147, 41);
            this.btnThongBao.TabIndex = 30;
            this.btnThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ActiveBorderThickness = 1;
            this.btnHuy.ActiveCornerRadius = 20;
            this.btnHuy.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnHuy.ActiveForecolor = System.Drawing.Color.White;
            this.btnHuy.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnHuy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.ButtonText = "Xác nhận hủy";
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.IdleBorderThickness = 1;
            this.btnHuy.IdleCornerRadius = 20;
            this.btnHuy.IdleFillColor = System.Drawing.Color.White;
            this.btnHuy.IdleForecolor = System.Drawing.Color.Red;
            this.btnHuy.IdleLineColor = System.Drawing.Color.Red;
            this.btnHuy.Location = new System.Drawing.Point(642, 162);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 41);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // textTen
            // 
            this.textTen.BorderColor = System.Drawing.Color.SeaGreen;
            this.textTen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTen.Location = new System.Drawing.Point(119, 124);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(154, 22);
            this.textTen.TabIndex = 32;
            this.textTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textTen_KeyDown);
            this.textTen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bunifuCustomTextbox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nhập tên";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(275, 125);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(41, 21);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 35;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Lọc ";
            // 
            // comboBoxLoai
            // 
            this.comboBoxLoai.FormattingEnabled = true;
            this.comboBoxLoai.Items.AddRange(new object[] {
            "Tất cả",
            "Nông sản",
            "Phân bón",
            "Thuốc BVTV"});
            this.comboBoxLoai.Location = new System.Drawing.Point(152, 181);
            this.comboBoxLoai.Name = "comboBoxLoai";
            this.comboBoxLoai.Size = new System.Drawing.Size(92, 21);
            this.comboBoxLoai.TabIndex = 38;
            this.comboBoxLoai.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxTT
            // 
            this.comboBoxTT.FormattingEnabled = true;
            this.comboBoxTT.Items.AddRange(new object[] {
            "Tất cả",
            "Còn hàng",
            "Sắp hết hàng",
            "Hết hàng"});
            this.comboBoxTT.Location = new System.Drawing.Point(342, 184);
            this.comboBoxTT.Name = "comboBoxTT";
            this.comboBoxTT.Size = new System.Drawing.Size(97, 21);
            this.comboBoxTT.TabIndex = 39;
            this.comboBoxTT.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label4.Location = new System.Drawing.Point(101, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label5.Location = new System.Drawing.Point(261, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Tình trạng";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(456, 183);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(53, 23);
            this.btnLoc.TabIndex = 42;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.ItemHeight = 14;
            this.listBoxSearch.Location = new System.Drawing.Point(119, 148);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(154, 74);
            this.listBoxSearch.TabIndex = 34;
            this.listBoxSearch.Visible = false;
            this.listBoxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSearch_MouseClick);
            // 
            // FormQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.listBoxSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTT);
            this.Controls.Add(this.comboBoxLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textTen);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThongBao);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyKho";
            this.Text = "FormQuanLyKho";
            this.Load += new System.EventHandler(this.FormQuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThongBao;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox textTen;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTT;
        private System.Windows.Forms.ComboBox comboBoxLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ListBox listBoxSearch;
    }
}