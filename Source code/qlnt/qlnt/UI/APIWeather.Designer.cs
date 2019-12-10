namespace qlnt.UI
{
    partial class APIWeather
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelViTri = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTinhTrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // labelViTri
            // 
            this.labelViTri.AutoSize = true;
            this.labelViTri.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViTri.Location = new System.Drawing.Point(209, 86);
            this.labelViTri.Name = "labelViTri";
            this.labelViTri.Size = new System.Drawing.Size(41, 23);
            this.labelViTri.TabIndex = 0;
            this.labelViTri.Text = "ViTri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 92);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTinhTrang
            // 
            this.labelTinhTrang.AutoSize = true;
            this.labelTinhTrang.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTinhTrang.Location = new System.Drawing.Point(209, 155);
            this.labelTinhTrang.Name = "labelTinhTrang";
            this.labelTinhTrang.Size = new System.Drawing.Size(81, 23);
            this.labelTinhTrang.TabIndex = 2;
            this.labelTinhTrang.Text = "TinhTrang";
            // 
            // APIWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.labelTinhTrang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelViTri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "APIWeather";
            this.Text = "APIWeather";
            this.Load += new System.EventHandler(this.APIWeather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label labelViTri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTinhTrang;
    }
}