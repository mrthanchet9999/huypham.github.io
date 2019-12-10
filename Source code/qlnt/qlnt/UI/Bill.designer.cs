namespace qlnt.UI
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.fbtnPrintExpF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fbtnDiscardChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dpDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.fbtnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fbtnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtboxTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.txtboxAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cbbProducts = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtboxWorker = new System.Windows.Forms.TextBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // fbtnPrintExpF
            // 
            this.fbtnPrintExpF.Active = false;
            this.fbtnPrintExpF.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnPrintExpF.BackColor = System.Drawing.Color.Green;
            this.fbtnPrintExpF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnPrintExpF.BorderRadius = 0;
            this.fbtnPrintExpF.ButtonText = "In hoá đơn";
            this.fbtnPrintExpF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnPrintExpF.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnPrintExpF.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnPrintExpF.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnPrintExpF.Iconimage")));
            this.fbtnPrintExpF.Iconimage_right = null;
            this.fbtnPrintExpF.Iconimage_right_Selected = null;
            this.fbtnPrintExpF.Iconimage_Selected = null;
            this.fbtnPrintExpF.IconMarginLeft = 0;
            this.fbtnPrintExpF.IconMarginRight = 0;
            this.fbtnPrintExpF.IconRightVisible = true;
            this.fbtnPrintExpF.IconRightZoom = 0D;
            this.fbtnPrintExpF.IconVisible = true;
            this.fbtnPrintExpF.IconZoom = 90D;
            this.fbtnPrintExpF.IsTab = false;
            this.fbtnPrintExpF.Location = new System.Drawing.Point(181, 581);
            this.fbtnPrintExpF.Name = "fbtnPrintExpF";
            this.fbtnPrintExpF.Normalcolor = System.Drawing.Color.Green;
            this.fbtnPrintExpF.OnHovercolor = System.Drawing.Color.Green;
            this.fbtnPrintExpF.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnPrintExpF.selected = false;
            this.fbtnPrintExpF.Size = new System.Drawing.Size(195, 48);
            this.fbtnPrintExpF.TabIndex = 63;
            this.fbtnPrintExpF.Text = "In hoá đơn";
            this.fbtnPrintExpF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnPrintExpF.Textcolor = System.Drawing.Color.White;
            this.fbtnPrintExpF.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fbtnDiscardChanges
            // 
            this.fbtnDiscardChanges.Active = false;
            this.fbtnDiscardChanges.Activecolor = System.Drawing.Color.Red;
            this.fbtnDiscardChanges.BackColor = System.Drawing.Color.DarkRed;
            this.fbtnDiscardChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnDiscardChanges.BorderRadius = 0;
            this.fbtnDiscardChanges.ButtonText = "Huỷ thay đổi";
            this.fbtnDiscardChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnDiscardChanges.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnDiscardChanges.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnDiscardChanges.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnDiscardChanges.Iconimage")));
            this.fbtnDiscardChanges.Iconimage_right = null;
            this.fbtnDiscardChanges.Iconimage_right_Selected = null;
            this.fbtnDiscardChanges.Iconimage_Selected = null;
            this.fbtnDiscardChanges.IconMarginLeft = 0;
            this.fbtnDiscardChanges.IconMarginRight = 0;
            this.fbtnDiscardChanges.IconRightVisible = true;
            this.fbtnDiscardChanges.IconRightZoom = 0D;
            this.fbtnDiscardChanges.IconVisible = true;
            this.fbtnDiscardChanges.IconZoom = 90D;
            this.fbtnDiscardChanges.IsTab = false;
            this.fbtnDiscardChanges.Location = new System.Drawing.Point(735, 581);
            this.fbtnDiscardChanges.Name = "fbtnDiscardChanges";
            this.fbtnDiscardChanges.Normalcolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscardChanges.OnHovercolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscardChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnDiscardChanges.selected = false;
            this.fbtnDiscardChanges.Size = new System.Drawing.Size(195, 48);
            this.fbtnDiscardChanges.TabIndex = 62;
            this.fbtnDiscardChanges.Text = "Huỷ thay đổi";
            this.fbtnDiscardChanges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnDiscardChanges.Textcolor = System.Drawing.Color.White;
            this.fbtnDiscardChanges.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnDiscardChanges.Click += new System.EventHandler(this.fbtnDiscardChanges_Click);
            // 
            // dpDate
            // 
            this.dpDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpDate.BorderRadius = 0;
            this.dpDate.ForeColor = System.Drawing.Color.White;
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDate.FormatCustom = "dd/MM/yyyy";
            this.dpDate.Location = new System.Drawing.Point(792, 74);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(210, 30);
            this.dpDate.TabIndex = 59;
            this.dpDate.Value = new System.DateTime(2019, 11, 16, 10, 36, 3, 762);
            // 
            // fbtnAddProduct
            // 
            this.fbtnAddProduct.Active = false;
            this.fbtnAddProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnAddProduct.BorderRadius = 0;
            this.fbtnAddProduct.ButtonText = "Thêm mặt hàng";
            this.fbtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnAddProduct.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnAddProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnAddProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnAddProduct.Iconimage")));
            this.fbtnAddProduct.Iconimage_right = null;
            this.fbtnAddProduct.Iconimage_right_Selected = null;
            this.fbtnAddProduct.Iconimage_Selected = null;
            this.fbtnAddProduct.IconMarginLeft = 0;
            this.fbtnAddProduct.IconMarginRight = 0;
            this.fbtnAddProduct.IconRightVisible = true;
            this.fbtnAddProduct.IconRightZoom = 0D;
            this.fbtnAddProduct.IconVisible = true;
            this.fbtnAddProduct.IconZoom = 90D;
            this.fbtnAddProduct.IsTab = false;
            this.fbtnAddProduct.Location = new System.Drawing.Point(771, 184);
            this.fbtnAddProduct.Name = "fbtnAddProduct";
            this.fbtnAddProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnAddProduct.selected = false;
            this.fbtnAddProduct.Size = new System.Drawing.Size(175, 33);
            this.fbtnAddProduct.TabIndex = 58;
            this.fbtnAddProduct.Text = "Thêm mặt hàng";
            this.fbtnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnAddProduct.Textcolor = System.Drawing.Color.White;
            this.fbtnAddProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fbtnCreate
            // 
            this.fbtnCreate.Active = false;
            this.fbtnCreate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnCreate.BackColor = System.Drawing.Color.Green;
            this.fbtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnCreate.BorderRadius = 0;
            this.fbtnCreate.ButtonText = "Lưu hoá đơn";
            this.fbtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnCreate.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnCreate.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnCreate.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnCreate.Iconimage")));
            this.fbtnCreate.Iconimage_right = null;
            this.fbtnCreate.Iconimage_right_Selected = null;
            this.fbtnCreate.Iconimage_Selected = null;
            this.fbtnCreate.IconMarginLeft = 0;
            this.fbtnCreate.IconMarginRight = 0;
            this.fbtnCreate.IconRightVisible = true;
            this.fbtnCreate.IconRightZoom = 0D;
            this.fbtnCreate.IconVisible = true;
            this.fbtnCreate.IconZoom = 90D;
            this.fbtnCreate.IsTab = false;
            this.fbtnCreate.Location = new System.Drawing.Point(465, 581);
            this.fbtnCreate.Name = "fbtnCreate";
            this.fbtnCreate.Normalcolor = System.Drawing.Color.Green;
            this.fbtnCreate.OnHovercolor = System.Drawing.Color.Green;
            this.fbtnCreate.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnCreate.selected = false;
            this.fbtnCreate.Size = new System.Drawing.Size(195, 48);
            this.fbtnCreate.TabIndex = 57;
            this.fbtnCreate.Text = "Lưu hoá đơn";
            this.fbtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnCreate.Textcolor = System.Drawing.Color.White;
            this.fbtnCreate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtboxTotal
            // 
            this.txtboxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxTotal.Location = new System.Drawing.Point(789, 536);
            this.txtboxTotal.Name = "txtboxTotal";
            this.txtboxTotal.Size = new System.Drawing.Size(186, 30);
            this.txtboxTotal.TabIndex = 56;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotal.Location = new System.Drawing.Point(689, 539);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 25);
            this.lblTotal.TabIndex = 55;
            this.lblTotal.Text = "Tổng tiền";
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(223, 184);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(441, 33);
            this.cbbCustomer.TabIndex = 54;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCustomer.Location = new System.Drawing.Point(99, 187);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(118, 25);
            this.lblCustomer.TabIndex = 53;
            this.lblCustomer.Text = "Khách hàng";
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(99, 260);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(903, 261);
            this.dgvProductList.TabIndex = 52;
            // 
            // txtboxAmount
            // 
            this.txtboxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxAmount.Location = new System.Drawing.Point(792, 124);
            this.txtboxAmount.Name = "txtboxAmount";
            this.txtboxAmount.Size = new System.Drawing.Size(210, 30);
            this.txtboxAmount.TabIndex = 51;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAmount.Location = new System.Drawing.Point(696, 129);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 25);
            this.lblAmount.TabIndex = 50;
            this.lblAmount.Text = "Số lượng";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblProductName.Location = new System.Drawing.Point(99, 130);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(212, 25);
            this.lblProductName.TabIndex = 49;
            this.lblProductName.Text = "Tên mặt hàng cần xuất";
            // 
            // cbbProducts
            // 
            this.cbbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbbProducts.FormattingEnabled = true;
            this.cbbProducts.Location = new System.Drawing.Point(317, 127);
            this.cbbProducts.MaxDropDownItems = 10;
            this.cbbProducts.Name = "cbbProducts";
            this.cbbProducts.Size = new System.Drawing.Size(347, 33);
            this.cbbProducts.TabIndex = 48;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDate.Location = new System.Drawing.Point(696, 74);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 25);
            this.lblDate.TabIndex = 47;
            this.lblDate.Text = "Ngày lập";
            // 
            // txtboxWorker
            // 
            this.txtboxWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxWorker.Location = new System.Drawing.Point(241, 74);
            this.txtboxWorker.Name = "txtboxWorker";
            this.txtboxWorker.Size = new System.Drawing.Size(423, 30);
            this.txtboxWorker.TabIndex = 46;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblWorker.Location = new System.Drawing.Point(99, 74);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(137, 25);
            this.lblWorker.TabIndex = 45;
            this.lblWorker.Text = "Tên nhân viên";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTitle.Location = new System.Drawing.Point(369, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(428, 33);
            this.lblTitle.TabIndex = 44;
            this.lblTitle.Text = "LÂP HOÁ ĐƠN BÁN NÔNG SẢN";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.fbtnPrintExpF);
            this.Controls.Add(this.fbtnDiscardChanges);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.fbtnAddProduct);
            this.Controls.Add(this.fbtnCreate);
            this.Controls.Add(this.txtboxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.txtboxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.cbbProducts);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtboxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton fbtnPrintExpF;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnDiscardChanges;
        private Bunifu.Framework.UI.BunifuDatepicker dpDate;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnAddProduct;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnCreate;
        private System.Windows.Forms.TextBox txtboxTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.TextBox txtboxAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cbbProducts;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtboxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblTitle;

    }
}