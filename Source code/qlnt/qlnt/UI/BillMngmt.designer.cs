namespace qlnt.UI
{
    partial class BillMngmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillMngmt));
            this.tbtnCreateBill = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnSearchBill = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbtnCreateBill
            // 
            this.tbtnCreateBill.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnCreateBill.color = System.Drawing.Color.SeaGreen;
            this.tbtnCreateBill.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnCreateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnCreateBill.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnCreateBill.ForeColor = System.Drawing.Color.White;
            this.tbtnCreateBill.Image = ((System.Drawing.Image)(resources.GetObject("tbtnCreateBill.Image")));
            this.tbtnCreateBill.ImagePosition = 19;
            this.tbtnCreateBill.ImageZoom = 50;
            this.tbtnCreateBill.LabelPosition = 39;
            this.tbtnCreateBill.LabelText = "Tạo hoá đơn mới";
            this.tbtnCreateBill.Location = new System.Drawing.Point(656, 225);
            this.tbtnCreateBill.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnCreateBill.Name = "tbtnCreateBill";
            this.tbtnCreateBill.Size = new System.Drawing.Size(205, 211);
            this.tbtnCreateBill.TabIndex = 7;
            this.tbtnCreateBill.Click += new System.EventHandler(this.tbtnCreateBill_Click);
            // 
            // tbtnSearchBill
            // 
            this.tbtnSearchBill.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnSearchBill.color = System.Drawing.Color.SeaGreen;
            this.tbtnSearchBill.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnSearchBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSearchBill.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnSearchBill.ForeColor = System.Drawing.Color.White;
            this.tbtnSearchBill.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSearchBill.Image")));
            this.tbtnSearchBill.ImagePosition = 19;
            this.tbtnSearchBill.ImageZoom = 50;
            this.tbtnSearchBill.LabelPosition = 39;
            this.tbtnSearchBill.LabelText = "Tìm kiếm hoá đơn";
            this.tbtnSearchBill.Location = new System.Drawing.Point(240, 225);
            this.tbtnSearchBill.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnSearchBill.Name = "tbtnSearchBill";
            this.tbtnSearchBill.Size = new System.Drawing.Size(205, 211);
            this.tbtnSearchBill.TabIndex = 6;
            this.tbtnSearchBill.Click += new System.EventHandler(this.tbtnSearchBill_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(33, 28);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // BillMngmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.tbtnCreateBill);
            this.Controls.Add(this.tbtnSearchBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillMngmt";
            this.Text = "BillMngmt";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton tbtnCreateBill;
        private Bunifu.Framework.UI.BunifuTileButton tbtnSearchBill;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}