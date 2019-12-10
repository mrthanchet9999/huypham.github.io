namespace qlnt.UI
{
    partial class EmployMngmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployMngmt));
            this.ibtnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.fbtnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ftbnAddEmployeeForm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ibtnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // ibtnBack
            // 
            this.ibtnBack.BackColor = System.Drawing.Color.Transparent;
            this.ibtnBack.Image = ((System.Drawing.Image)(resources.GetObject("ibtnBack.Image")));
            this.ibtnBack.ImageActive = null;
            this.ibtnBack.Location = new System.Drawing.Point(39, 43);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(50, 50);
            this.ibtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnBack.TabIndex = 27;
            this.ibtnBack.TabStop = false;
            this.ibtnBack.Zoom = 10;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Location = new System.Drawing.Point(117, 215);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(882, 384);
            this.dgvEmployeeList.TabIndex = 26;
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
            this.fbtnReload.Location = new System.Drawing.Point(909, 141);
            this.fbtnReload.Name = "fbtnReload";
            this.fbtnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnReload.selected = false;
            this.fbtnReload.Size = new System.Drawing.Size(90, 41);
            this.fbtnReload.TabIndex = 25;
            this.fbtnReload.Text = "Xem tất cả";
            this.fbtnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnReload.Textcolor = System.Drawing.Color.White;
            this.fbtnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ftbnAddEmployeeForm
            // 
            this.ftbnAddEmployeeForm.Active = false;
            this.ftbnAddEmployeeForm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ftbnAddEmployeeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ftbnAddEmployeeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ftbnAddEmployeeForm.BorderRadius = 0;
            this.ftbnAddEmployeeForm.ButtonText = "Thêm nhân viên mới";
            this.ftbnAddEmployeeForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ftbnAddEmployeeForm.DisabledColor = System.Drawing.Color.Gray;
            this.ftbnAddEmployeeForm.Iconcolor = System.Drawing.Color.Transparent;
            this.ftbnAddEmployeeForm.Iconimage = ((System.Drawing.Image)(resources.GetObject("ftbnAddEmployeeForm.Iconimage")));
            this.ftbnAddEmployeeForm.Iconimage_right = null;
            this.ftbnAddEmployeeForm.Iconimage_right_Selected = null;
            this.ftbnAddEmployeeForm.Iconimage_Selected = null;
            this.ftbnAddEmployeeForm.IconMarginLeft = 0;
            this.ftbnAddEmployeeForm.IconMarginRight = 0;
            this.ftbnAddEmployeeForm.IconRightVisible = true;
            this.ftbnAddEmployeeForm.IconRightZoom = 0D;
            this.ftbnAddEmployeeForm.IconVisible = true;
            this.ftbnAddEmployeeForm.IconZoom = 70D;
            this.ftbnAddEmployeeForm.IsTab = false;
            this.ftbnAddEmployeeForm.Location = new System.Drawing.Point(682, 141);
            this.ftbnAddEmployeeForm.Name = "ftbnAddEmployeeForm";
            this.ftbnAddEmployeeForm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ftbnAddEmployeeForm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ftbnAddEmployeeForm.OnHoverTextColor = System.Drawing.Color.White;
            this.ftbnAddEmployeeForm.selected = false;
            this.ftbnAddEmployeeForm.Size = new System.Drawing.Size(176, 41);
            this.ftbnAddEmployeeForm.TabIndex = 24;
            this.ftbnAddEmployeeForm.Text = "Thêm nhân viên mới";
            this.ftbnAddEmployeeForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ftbnAddEmployeeForm.Textcolor = System.Drawing.Color.White;
            this.ftbnAddEmployeeForm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.ibtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSearch.Image")));
            this.ibtnSearch.ImageActive = null;
            this.ibtnSearch.Location = new System.Drawing.Point(559, 141);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(40, 40);
            this.ibtnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnSearch.TabIndex = 23;
            this.ibtnSearch.TabStop = false;
            this.ibtnSearch.Zoom = 10;
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtboxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtboxSearch.Location = new System.Drawing.Point(117, 141);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(482, 41);
            this.txtboxSearch.TabIndex = 22;
            this.txtboxSearch.Text = "Tìm kiếm";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(428, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 31);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Danh sách nhân viên";
            // 
            // EmployMngmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.ibtnBack);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.fbtnReload);
            this.Controls.Add(this.ftbnAddEmployeeForm);
            this.Controls.Add(this.ibtnSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployMngmt";
            this.Text = "EmployMngmt";
            ((System.ComponentModel.ISupportInitialize)(this.ibtnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton ibtnBack;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnReload;
        private Bunifu.Framework.UI.BunifuFlatButton ftbnAddEmployeeForm;
        private Bunifu.Framework.UI.BunifuImageButton ibtnSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label lblTitle;

    }
}