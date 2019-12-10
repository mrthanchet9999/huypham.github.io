namespace qlnt.UI
{
    partial class ImportFormList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFormList));
            this.ibtnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvFormList = new System.Windows.Forms.DataGridView();
            this.fbtnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ftbnAddImportForm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ibtnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // ibtnBack
            // 
            this.ibtnBack.BackColor = System.Drawing.Color.Transparent;
            this.ibtnBack.Image = ((System.Drawing.Image)(resources.GetObject("ibtnBack.Image")));
            this.ibtnBack.ImageActive = null;
            this.ibtnBack.Location = new System.Drawing.Point(38, 39);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(50, 50);
            this.ibtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnBack.TabIndex = 20;
            this.ibtnBack.TabStop = false;
            this.ibtnBack.Zoom = 10;
            this.ibtnBack.Click += new System.EventHandler(this.ibtnBack_Click);
            // 
            // dgvFormList
            // 
            this.dgvFormList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormList.Location = new System.Drawing.Point(116, 211);
            this.dgvFormList.Name = "dgvFormList";
            this.dgvFormList.Size = new System.Drawing.Size(882, 384);
            this.dgvFormList.TabIndex = 19;
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
            this.fbtnReload.Location = new System.Drawing.Point(908, 137);
            this.fbtnReload.Name = "fbtnReload";
            this.fbtnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnReload.selected = false;
            this.fbtnReload.Size = new System.Drawing.Size(90, 41);
            this.fbtnReload.TabIndex = 18;
            this.fbtnReload.Text = "Xem tất cả";
            this.fbtnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnReload.Textcolor = System.Drawing.Color.White;
            this.fbtnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ftbnAddImportForm
            // 
            this.ftbnAddImportForm.Active = false;
            this.ftbnAddImportForm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ftbnAddImportForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ftbnAddImportForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ftbnAddImportForm.BorderRadius = 0;
            this.ftbnAddImportForm.ButtonText = "Thêm phiếu nhập";
            this.ftbnAddImportForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ftbnAddImportForm.DisabledColor = System.Drawing.Color.Gray;
            this.ftbnAddImportForm.Iconcolor = System.Drawing.Color.Transparent;
            this.ftbnAddImportForm.Iconimage = ((System.Drawing.Image)(resources.GetObject("ftbnAddImportForm.Iconimage")));
            this.ftbnAddImportForm.Iconimage_right = null;
            this.ftbnAddImportForm.Iconimage_right_Selected = null;
            this.ftbnAddImportForm.Iconimage_Selected = null;
            this.ftbnAddImportForm.IconMarginLeft = 0;
            this.ftbnAddImportForm.IconMarginRight = 0;
            this.ftbnAddImportForm.IconRightVisible = true;
            this.ftbnAddImportForm.IconRightZoom = 0D;
            this.ftbnAddImportForm.IconVisible = true;
            this.ftbnAddImportForm.IconZoom = 70D;
            this.ftbnAddImportForm.IsTab = false;
            this.ftbnAddImportForm.Location = new System.Drawing.Point(681, 137);
            this.ftbnAddImportForm.Name = "ftbnAddImportForm";
            this.ftbnAddImportForm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ftbnAddImportForm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ftbnAddImportForm.OnHoverTextColor = System.Drawing.Color.White;
            this.ftbnAddImportForm.selected = false;
            this.ftbnAddImportForm.Size = new System.Drawing.Size(154, 41);
            this.ftbnAddImportForm.TabIndex = 17;
            this.ftbnAddImportForm.Text = "Thêm phiếu nhập";
            this.ftbnAddImportForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ftbnAddImportForm.Textcolor = System.Drawing.Color.White;
            this.ftbnAddImportForm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.ibtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSearch.Image")));
            this.ibtnSearch.ImageActive = null;
            this.ibtnSearch.Location = new System.Drawing.Point(558, 137);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(40, 40);
            this.ibtnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnSearch.TabIndex = 16;
            this.ibtnSearch.TabStop = false;
            this.ibtnSearch.Zoom = 10;
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtboxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtboxSearch.Location = new System.Drawing.Point(116, 137);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(482, 41);
            this.txtboxSearch.TabIndex = 15;
            this.txtboxSearch.Text = "Tìm kiếm phiếu nhập";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(411, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 31);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Danh sách phiếu nhập";
            // 
            // ImportFormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.ibtnBack);
            this.Controls.Add(this.dgvFormList);
            this.Controls.Add(this.fbtnReload);
            this.Controls.Add(this.ftbnAddImportForm);
            this.Controls.Add(this.ibtnSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportFormList";
            this.Text = "ImportFormList";
            ((System.ComponentModel.ISupportInitialize)(this.ibtnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton ibtnBack;
        private System.Windows.Forms.DataGridView dgvFormList;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnReload;
        private Bunifu.Framework.UI.BunifuFlatButton ftbnAddImportForm;
        private Bunifu.Framework.UI.BunifuImageButton ibtnSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label lblTitle;
    }
}