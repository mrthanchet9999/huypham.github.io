namespace qlnt.UI
{
    partial class ExportMngmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportMngmt));
            this.tbtnCreateExpf = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnSearchExpf = new Bunifu.Framework.UI.BunifuTileButton();
            this.ibtnBack = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tbtnCreateExpf
            // 
            this.tbtnCreateExpf.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnCreateExpf.color = System.Drawing.Color.SeaGreen;
            this.tbtnCreateExpf.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnCreateExpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnCreateExpf.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnCreateExpf.ForeColor = System.Drawing.Color.White;
            this.tbtnCreateExpf.Image = ((System.Drawing.Image)(resources.GetObject("tbtnCreateExpf.Image")));
            this.tbtnCreateExpf.ImagePosition = 19;
            this.tbtnCreateExpf.ImageZoom = 50;
            this.tbtnCreateExpf.LabelPosition = 39;
            this.tbtnCreateExpf.LabelText = "Tạo phiếu xuất mới";
            this.tbtnCreateExpf.Location = new System.Drawing.Point(656, 225);
            this.tbtnCreateExpf.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnCreateExpf.Name = "tbtnCreateExpf";
            this.tbtnCreateExpf.Size = new System.Drawing.Size(205, 211);
            this.tbtnCreateExpf.TabIndex = 7;
            this.tbtnCreateExpf.Click += new System.EventHandler(this.tbtnCreateExpf_Click);
            // 
            // tbtnSearchExpf
            // 
            this.tbtnSearchExpf.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnSearchExpf.color = System.Drawing.Color.SeaGreen;
            this.tbtnSearchExpf.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnSearchExpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnSearchExpf.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnSearchExpf.ForeColor = System.Drawing.Color.White;
            this.tbtnSearchExpf.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSearchExpf.Image")));
            this.tbtnSearchExpf.ImagePosition = 19;
            this.tbtnSearchExpf.ImageZoom = 50;
            this.tbtnSearchExpf.LabelPosition = 39;
            this.tbtnSearchExpf.LabelText = "Tìm kiếm phiếu xuất";
            this.tbtnSearchExpf.Location = new System.Drawing.Point(240, 225);
            this.tbtnSearchExpf.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnSearchExpf.Name = "tbtnSearchExpf";
            this.tbtnSearchExpf.Size = new System.Drawing.Size(205, 211);
            this.tbtnSearchExpf.TabIndex = 6;
            this.tbtnSearchExpf.Click += new System.EventHandler(this.tbtnSearchExpf_Click);
            // 
            // ibtnBack
            // 
            this.ibtnBack.Image = ((System.Drawing.Image)(resources.GetObject("ibtnBack.Image")));
            this.ibtnBack.ImageActive = null;
            this.ibtnBack.Location = new System.Drawing.Point(30, 34);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(71, 71);
            this.ibtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnBack.TabIndex = 8;
            this.ibtnBack.TabStop = false;
            this.ibtnBack.Zoom = 10;
            this.ibtnBack.Click += new System.EventHandler(this.ibtnBack_Click);
            // 
            // ExportMngmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.ibtnBack);
            this.Controls.Add(this.tbtnCreateExpf);
            this.Controls.Add(this.tbtnSearchExpf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportMngmt";
            this.Text = "ExportMngmt";
            ((System.ComponentModel.ISupportInitialize)(this.ibtnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton tbtnCreateExpf;
        private Bunifu.Framework.UI.BunifuTileButton tbtnSearchExpf;
        private Bunifu.Framework.UI.BunifuImageButton ibtnBack;
    }
}