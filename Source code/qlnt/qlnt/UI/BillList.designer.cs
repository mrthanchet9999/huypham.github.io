namespace qlnt.UI
{
    partial class BillList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillList));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.ibtnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.ftbnAddBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fbtnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ibtnBack = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTitle.Location = new System.Drawing.Point(423, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danh sách hoá đơn";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtboxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtboxSearch.Location = new System.Drawing.Point(112, 128);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(482, 41);
            this.txtboxSearch.TabIndex = 1;
            this.txtboxSearch.Text = "Tìm kiếm hoá đơn";
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.ibtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSearch.Image")));
            this.ibtnSearch.ImageActive = null;
            this.ibtnSearch.Location = new System.Drawing.Point(554, 128);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(40, 40);
            this.ibtnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnSearch.TabIndex = 2;
            this.ibtnSearch.TabStop = false;
            this.ibtnSearch.Zoom = 10;
            // 
            // ftbnAddBill
            // 
            this.ftbnAddBill.Active = false;
            this.ftbnAddBill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ftbnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ftbnAddBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ftbnAddBill.BorderRadius = 0;
            this.ftbnAddBill.ButtonText = "Thêm hoá đơn";
            this.ftbnAddBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ftbnAddBill.DisabledColor = System.Drawing.Color.Gray;
            this.ftbnAddBill.Iconcolor = System.Drawing.Color.Transparent;
            this.ftbnAddBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("ftbnAddBill.Iconimage")));
            this.ftbnAddBill.Iconimage_right = null;
            this.ftbnAddBill.Iconimage_right_Selected = null;
            this.ftbnAddBill.Iconimage_Selected = null;
            this.ftbnAddBill.IconMarginLeft = 0;
            this.ftbnAddBill.IconMarginRight = 0;
            this.ftbnAddBill.IconRightVisible = true;
            this.ftbnAddBill.IconRightZoom = 0D;
            this.ftbnAddBill.IconVisible = true;
            this.ftbnAddBill.IconZoom = 70D;
            this.ftbnAddBill.IsTab = false;
            this.ftbnAddBill.Location = new System.Drawing.Point(677, 128);
            this.ftbnAddBill.Name = "ftbnAddBill";
            this.ftbnAddBill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ftbnAddBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ftbnAddBill.OnHoverTextColor = System.Drawing.Color.White;
            this.ftbnAddBill.selected = false;
            this.ftbnAddBill.Size = new System.Drawing.Size(154, 41);
            this.ftbnAddBill.TabIndex = 3;
            this.ftbnAddBill.Text = "Thêm hoá đơn";
            this.ftbnAddBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ftbnAddBill.Textcolor = System.Drawing.Color.White;
            this.ftbnAddBill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fbtnReload
            // 
            this.fbtnReload.Active = false;
            this.fbtnReload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnReload.BorderRadius = 0;
            this.fbtnReload.ButtonText = "Xem tất cả";
            this.fbtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnReload.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnReload.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnReload.Iconimage = null;
            this.fbtnReload.Iconimage_right = null;
            this.fbtnReload.Iconimage_right_Selected = null;
            this.fbtnReload.Iconimage_Selected = null;
            this.fbtnReload.IconMarginLeft = 10;
            this.fbtnReload.IconMarginRight = 0;
            this.fbtnReload.IconRightVisible = true;
            this.fbtnReload.IconRightZoom = 0D;
            this.fbtnReload.IconVisible = true;
            this.fbtnReload.IconZoom = 90D;
            this.fbtnReload.IsTab = false;
            this.fbtnReload.Location = new System.Drawing.Point(904, 128);
            this.fbtnReload.Name = "fbtnReload";
            this.fbtnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnReload.selected = false;
            this.fbtnReload.Size = new System.Drawing.Size(90, 41);
            this.fbtnReload.TabIndex = 4;
            this.fbtnReload.Text = "Xem tất cả";
            this.fbtnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnReload.Textcolor = System.Drawing.Color.White;
            this.fbtnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 384);
            this.dataGridView1.TabIndex = 5;
            // 
            // ibtnBack
            // 
            this.ibtnBack.BackColor = System.Drawing.Color.Transparent;
            this.ibtnBack.Image = ((System.Drawing.Image)(resources.GetObject("ibtnBack.Image")));
            this.ibtnBack.ImageActive = null;
            this.ibtnBack.Location = new System.Drawing.Point(34, 30);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(50, 50);
            this.ibtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnBack.TabIndex = 6;
            this.ibtnBack.TabStop = false;
            this.ibtnBack.Zoom = 10;
            this.ibtnBack.Click += new System.EventHandler(this.ibtnBack_Click);
            // 
            // BillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.ibtnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fbtnReload);
            this.Controls.Add(this.ftbnAddBill);
            this.Controls.Add(this.ibtnSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillList";
            this.Text = "ListForm";
            ((System.ComponentModel.ISupportInitialize)(this.ibtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxSearch;
        private Bunifu.Framework.UI.BunifuImageButton ibtnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton ftbnAddBill;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnReload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuImageButton ibtnBack;
    }
}