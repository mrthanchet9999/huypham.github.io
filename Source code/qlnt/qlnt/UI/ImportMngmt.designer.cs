namespace qlnt.UI
{
    partial class ImportMngmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportMngmt));
            this.tbtnSearchImpf = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnCreateImpf = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.ibtnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tbtnSearchImpf
            // 
            this.tbtnSearchImpf.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnSearchImpf.color = System.Drawing.Color.SeaGreen;
            this.tbtnSearchImpf.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnSearchImpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSearchImpf.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnSearchImpf.ForeColor = System.Drawing.Color.White;
            this.tbtnSearchImpf.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSearchImpf.Image")));
            this.tbtnSearchImpf.ImagePosition = 19;
            this.tbtnSearchImpf.ImageZoom = 50;
            this.tbtnSearchImpf.LabelPosition = 39;
            this.tbtnSearchImpf.LabelText = "Tìm kiếm phiếu nhập";
            this.tbtnSearchImpf.Location = new System.Drawing.Point(235, 204);
            this.tbtnSearchImpf.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnSearchImpf.Name = "tbtnSearchImpf";
            this.tbtnSearchImpf.Size = new System.Drawing.Size(205, 211);
            this.tbtnSearchImpf.TabIndex = 4;
            this.tbtnSearchImpf.Click += new System.EventHandler(this.tbtnImportSearch_Click);
            // 
            // tbtnCreateImpf
            // 
            this.tbtnCreateImpf.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnCreateImpf.color = System.Drawing.Color.SeaGreen;
            this.tbtnCreateImpf.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnCreateImpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnCreateImpf.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnCreateImpf.ForeColor = System.Drawing.Color.White;
            this.tbtnCreateImpf.Image = ((System.Drawing.Image)(resources.GetObject("tbtnCreateImpf.Image")));
            this.tbtnCreateImpf.ImagePosition = 19;
            this.tbtnCreateImpf.ImageZoom = 50;
            this.tbtnCreateImpf.LabelPosition = 39;
            this.tbtnCreateImpf.LabelText = "Tạo phiếu nhập mới";
            this.tbtnCreateImpf.Location = new System.Drawing.Point(651, 204);
            this.tbtnCreateImpf.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnCreateImpf.Name = "tbtnCreateImpf";
            this.tbtnCreateImpf.Size = new System.Drawing.Size(205, 211);
            this.tbtnCreateImpf.TabIndex = 5;
            this.tbtnCreateImpf.Click += new System.EventHandler(this.tbtnCreateImpf_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.ibtnBack);
            this.pnlContainer.Controls.Add(this.tbtnCreateImpf);
            this.pnlContainer.Controls.Add(this.tbtnSearchImpf);
            this.pnlContainer.Location = new System.Drawing.Point(1, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1100, 661);
            this.pnlContainer.TabIndex = 6;
            // 
            // ibtnBack
            // 
            this.ibtnBack.Image = ((System.Drawing.Image)(resources.GetObject("ibtnBack.Image")));
            this.ibtnBack.ImageActive = null;
            this.ibtnBack.Location = new System.Drawing.Point(27, 28);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(71, 71);
            this.ibtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnBack.TabIndex = 6;
            this.ibtnBack.TabStop = false;
            this.ibtnBack.Zoom = 10;
            this.ibtnBack.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // ImportMngmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportMngmt";
            this.Text = "ImportMngmt";
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibtnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton tbtnSearchImpf;
        private Bunifu.Framework.UI.BunifuTileButton tbtnCreateImpf;
        private System.Windows.Forms.Panel pnlContainer;
        private Bunifu.Framework.UI.BunifuImageButton ibtnBack;
    }
}