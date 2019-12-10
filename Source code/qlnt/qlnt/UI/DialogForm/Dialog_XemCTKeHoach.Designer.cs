namespace qlnt.UI
{
    partial class Dialog_XemCTKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_XemCTKH));
            this.labelCV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelXemThoiGian = new System.Windows.Forms.Label();
            this.dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoanThanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.richTextBoxND = new System.Windows.Forms.RichTextBox();
            this.btnEditND = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSaveND = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelCT = new System.Windows.Forms.Panel();
            this.panelSaveCT = new System.Windows.Forms.Panel();
            this.btnNotSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSaveCT = new Bunifu.Framework.UI.BunifuImageButton();
            this.richTextBoxCT = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditCT = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNotSaveND = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelSaveND = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveND)).BeginInit();
            this.panelCT.SuspendLayout();
            this.panelSaveCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotSaveND)).BeginInit();
            this.panelSaveND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCV
            // 
            this.labelCV.AutoSize = true;
            this.labelCV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCV.Location = new System.Drawing.Point(24, 105);
            this.labelCV.Name = "labelCV";
            this.labelCV.Size = new System.Drawing.Size(78, 19);
            this.labelCV.TabIndex = 38;
            this.labelCV.Text = "Công việc";
            this.labelCV.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nội dung";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // labelXemThoiGian
            // 
            this.labelXemThoiGian.AutoSize = true;
            this.labelXemThoiGian.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXemThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelXemThoiGian.Location = new System.Drawing.Point(226, 63);
            this.labelXemThoiGian.Name = "labelXemThoiGian";
            this.labelXemThoiGian.Size = new System.Drawing.Size(59, 25);
            this.labelXemThoiGian.TabIndex = 43;
            this.labelXemThoiGian.Text = "date";
            // 
            // dataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CongViec,
            this.HoanThanh,
            this.MaLoai,
            this.Xoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.DoubleBuffered = true;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataGrid.Location = new System.Drawing.Point(28, 147);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.Size = new System.Drawing.Size(373, 138);
            this.dataGrid.TabIndex = 44;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // CongViec
            // 
            this.CongViec.DataPropertyName = "CongViec";
            this.CongViec.HeaderText = "Công việc";
            this.CongViec.Name = "CongViec";
            this.CongViec.Width = 150;
            // 
            // HoanThanh
            // 
            this.HoanThanh.DataPropertyName = "HoanThanh";
            this.HoanThanh.FalseValue = "false";
            this.HoanThanh.HeaderText = "Hoàn thành";
            this.HoanThanh.Name = "HoanThanh";
            this.HoanThanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoanThanh.TrueValue = "true";
            this.HoanThanh.Width = 120;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "id";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaLoai.Visible = false;
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.Name = "Xoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ngày thực hiện";
            // 
            // buttonClose
            // 
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageActive = null;
            this.buttonClose.Location = new System.Drawing.Point(725, 9);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(34, 29);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 46;
            this.buttonClose.TabStop = false;
            this.buttonClose.Zoom = 10;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // richTextBoxND
            // 
            this.richTextBoxND.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxND.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxND.Location = new System.Drawing.Point(28, 346);
            this.richTextBoxND.Name = "richTextBoxND";
            this.richTextBoxND.ReadOnly = true;
            this.richTextBoxND.Size = new System.Drawing.Size(373, 110);
            this.richTextBoxND.TabIndex = 47;
            this.richTextBoxND.Text = "";
            // 
            // btnEditND
            // 
            this.btnEditND.Image = ((System.Drawing.Image)(resources.GetObject("btnEditND.Image")));
            this.btnEditND.ImageActive = null;
            this.btnEditND.Location = new System.Drawing.Point(121, 304);
            this.btnEditND.Name = "btnEditND";
            this.btnEditND.Size = new System.Drawing.Size(51, 25);
            this.btnEditND.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditND.TabIndex = 49;
            this.btnEditND.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEditND, "Chỉnh sửa");
            this.btnEditND.Zoom = 10;
            this.btnEditND.Click += new System.EventHandler(this.editND_Click);
            // 
            // btnSaveND
            // 
            this.btnSaveND.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveND.Image")));
            this.btnSaveND.ImageActive = null;
            this.btnSaveND.Location = new System.Drawing.Point(3, 3);
            this.btnSaveND.Name = "btnSaveND";
            this.btnSaveND.Size = new System.Drawing.Size(51, 25);
            this.btnSaveND.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSaveND.TabIndex = 50;
            this.btnSaveND.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSaveND, "Lưu");
            this.btnSaveND.Zoom = 10;
            this.btnSaveND.Click += new System.EventHandler(this.saveND_Click);
            // 
            // panelCT
            // 
            this.panelCT.Controls.Add(this.panelSaveCT);
            this.panelCT.Controls.Add(this.richTextBoxCT);
            this.panelCT.Controls.Add(this.label4);
            this.panelCT.Controls.Add(this.btnEditCT);
            this.panelCT.Location = new System.Drawing.Point(420, 256);
            this.panelCT.Name = "panelCT";
            this.panelCT.Size = new System.Drawing.Size(330, 224);
            this.panelCT.TabIndex = 53;
            // 
            // panelSaveCT
            // 
            this.panelSaveCT.Controls.Add(this.btnNotSave);
            this.panelSaveCT.Controls.Add(this.btnSaveCT);
            this.panelSaveCT.Location = new System.Drawing.Point(168, 42);
            this.panelSaveCT.Name = "panelSaveCT";
            this.panelSaveCT.Size = new System.Drawing.Size(98, 27);
            this.panelSaveCT.TabIndex = 57;
            this.panelSaveCT.Visible = false;
            // 
            // btnNotSave
            // 
            this.btnNotSave.Image = ((System.Drawing.Image)(resources.GetObject("btnNotSave.Image")));
            this.btnNotSave.ImageActive = null;
            this.btnNotSave.Location = new System.Drawing.Point(46, 2);
            this.btnNotSave.Name = "btnNotSave";
            this.btnNotSave.Size = new System.Drawing.Size(50, 25);
            this.btnNotSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNotSave.TabIndex = 55;
            this.btnNotSave.TabStop = false;
            this.toolTip1.SetToolTip(this.btnNotSave, "Không lưu");
            this.btnNotSave.Zoom = 10;
            this.btnNotSave.Click += new System.EventHandler(this.notSaveCT_Click);
            // 
            // btnSaveCT
            // 
            this.btnSaveCT.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCT.Image")));
            this.btnSaveCT.ImageActive = null;
            this.btnSaveCT.Location = new System.Drawing.Point(1, 2);
            this.btnSaveCT.Name = "btnSaveCT";
            this.btnSaveCT.Size = new System.Drawing.Size(50, 25);
            this.btnSaveCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSaveCT.TabIndex = 56;
            this.btnSaveCT.TabStop = false;
            this.btnSaveCT.Zoom = 10;
            this.btnSaveCT.Click += new System.EventHandler(this.saveCT_Click);
            // 
            // richTextBoxCT
            // 
            this.richTextBoxCT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCT.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.richTextBoxCT.Location = new System.Drawing.Point(40, 85);
            this.richTextBoxCT.Name = "richTextBoxCT";
            this.richTextBoxCT.ReadOnly = true;
            this.richTextBoxCT.Size = new System.Drawing.Size(266, 115);
            this.richTextBoxCT.TabIndex = 54;
            this.richTextBoxCT.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Chú thích";
            // 
            // btnEditCT
            // 
            this.btnEditCT.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCT.Image")));
            this.btnEditCT.ImageActive = null;
            this.btnEditCT.Location = new System.Drawing.Point(118, 43);
            this.btnEditCT.Name = "btnEditCT";
            this.btnEditCT.Size = new System.Drawing.Size(50, 25);
            this.btnEditCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditCT.TabIndex = 55;
            this.btnEditCT.TabStop = false;
            this.btnEditCT.Zoom = 10;
            this.btnEditCT.Click += new System.EventHandler(this.editCT_Click);
            // 
            // btnNotSaveND
            // 
            this.btnNotSaveND.Image = ((System.Drawing.Image)(resources.GetObject("btnNotSaveND.Image")));
            this.btnNotSaveND.ImageActive = null;
            this.btnNotSaveND.Location = new System.Drawing.Point(60, 3);
            this.btnNotSaveND.Name = "btnNotSaveND";
            this.btnNotSaveND.Size = new System.Drawing.Size(51, 25);
            this.btnNotSaveND.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNotSaveND.TabIndex = 54;
            this.btnNotSaveND.TabStop = false;
            this.toolTip1.SetToolTip(this.btnNotSaveND, "Không lưu");
            this.btnNotSaveND.Zoom = 10;
            this.btnNotSaveND.Click += new System.EventHandler(this.notSaveND_Click);
            // 
            // panelSaveND
            // 
            this.panelSaveND.Controls.Add(this.btnNotSaveND);
            this.panelSaveND.Controls.Add(this.btnSaveND);
            this.panelSaveND.Location = new System.Drawing.Point(172, 301);
            this.panelSaveND.Name = "panelSaveND";
            this.panelSaveND.Size = new System.Drawing.Size(114, 29);
            this.panelSaveND.TabIndex = 55;
            this.panelSaveND.Visible = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(111, 102);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 56;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(22, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 33);
            this.label10.TabIndex = 47;
            this.label10.Text = "Chi tiết kế hoạch";
            // 
            // Dialog_XemCTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(771, 519);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panelSaveND);
            this.Controls.Add(this.panelCT);
            this.Controls.Add(this.btnEditND);
            this.Controls.Add(this.richTextBoxND);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.labelXemThoiGian);
            this.Controls.Add(this.labelCV);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialog_XemCTKH";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FormChiTietKeHoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveND)).EndInit();
            this.panelCT.ResumeLayout(false);
            this.panelCT.PerformLayout();
            this.panelSaveCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNotSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotSaveND)).EndInit();
            this.panelSaveND.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCV;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label labelXemThoiGian;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
        private System.Windows.Forms.RichTextBox richTextBoxND;
        private Bunifu.Framework.UI.BunifuImageButton btnSaveND;
        private Bunifu.Framework.UI.BunifuImageButton btnEditND;
        private System.Windows.Forms.Panel panelCT;
        private Bunifu.Framework.UI.BunifuImageButton btnSaveCT;
        private Bunifu.Framework.UI.BunifuImageButton btnEditCT;
        private System.Windows.Forms.RichTextBox richTextBoxCT;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton btnNotSaveND;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton btnNotSave;
        private System.Windows.Forms.Panel panelSaveND;
        private System.Windows.Forms.Panel panelSaveCT;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongViec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewImageColumn Xoa;
        private System.Windows.Forms.Label label10;
    }
}