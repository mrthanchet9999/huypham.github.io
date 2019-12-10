namespace qlnt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.inputSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonViewAll = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1024, 21);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.LimeGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(79, 50);
            this.bunifuCustomLabel1.MaximumSize = new System.Drawing.Size(100, 200);
            this.bunifuCustomLabel1.MinimumSize = new System.Drawing.Size(200, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(200, 42);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Tiêu đề";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputSearch
            // 
            this.inputSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.inputSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSearch.Location = new System.Drawing.Point(199, 123);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(405, 27);
            this.inputSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageActive = null;
            this.buttonSearch.Location = new System.Drawing.Point(610, 123);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(32, 27);
            this.buttonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.Zoom = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageActive = null;
            this.buttonAdd.Location = new System.Drawing.Point(779, 119);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(28, 27);
            this.buttonAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Zoom = 10;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(730, 123);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(47, 18);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Thêm";
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.ActiveBorderThickness = 1;
            this.buttonViewAll.ActiveCornerRadius = 20;
            this.buttonViewAll.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonViewAll.ActiveForecolor = System.Drawing.Color.White;
            this.buttonViewAll.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.buttonViewAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonViewAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonViewAll.BackgroundImage")));
            this.buttonViewAll.ButtonText = "Xem tất cả";
            this.buttonViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAll.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonViewAll.IdleBorderThickness = 1;
            this.buttonViewAll.IdleCornerRadius = 20;
            this.buttonViewAll.IdleFillColor = System.Drawing.Color.White;
            this.buttonViewAll.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonViewAll.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonViewAll.Location = new System.Drawing.Point(868, 113);
            this.buttonViewAll.Margin = new System.Windows.Forms.Padding(5);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(109, 33);
            this.buttonViewAll.TabIndex = 11;
            this.buttonViewAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        protected Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        protected Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        protected WindowsFormsControlLibrary1.BunifuCustomTextbox inputSearch;
        protected System.Windows.Forms.Label label1;
        protected Bunifu.Framework.UI.BunifuImageButton buttonSearch;
        protected Bunifu.Framework.UI.BunifuImageButton buttonAdd;
        protected Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        protected Bunifu.Framework.UI.BunifuThinButton2 buttonViewAll;
    }
}

