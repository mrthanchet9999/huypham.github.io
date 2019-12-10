namespace qlnt.UI
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.bunifuGauge1 = new Bunifu.Framework.UI.BunifuGauge();
            this.fbtnDone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuGauge1
            // 
            this.bunifuGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge1.BackgroundImage")));
            this.bunifuGauge1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuGauge1.Location = new System.Drawing.Point(439, 214);
            this.bunifuGauge1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge1.Name = "bunifuGauge1";
            this.bunifuGauge1.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuGauge1.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge1.ProgressColor2 = System.Drawing.Color.Tomato;
            this.bunifuGauge1.Size = new System.Drawing.Size(174, 117);
            this.bunifuGauge1.Suffix = "";
            this.bunifuGauge1.TabIndex = 0;
            this.bunifuGauge1.Thickness = 30;
            this.bunifuGauge1.Value = 0;
            // 
            // fbtnDone
            // 
            this.fbtnDone.Active = false;
            this.fbtnDone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnDone.BorderRadius = 0;
            this.fbtnDone.ButtonText = "Done";
            this.fbtnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnDone.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnDone.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnDone.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnDone.Iconimage")));
            this.fbtnDone.Iconimage_right = null;
            this.fbtnDone.Iconimage_right_Selected = null;
            this.fbtnDone.Iconimage_Selected = null;
            this.fbtnDone.IconMarginLeft = 0;
            this.fbtnDone.IconMarginRight = 0;
            this.fbtnDone.IconRightVisible = true;
            this.fbtnDone.IconRightZoom = 0D;
            this.fbtnDone.IconVisible = true;
            this.fbtnDone.IconZoom = 90D;
            this.fbtnDone.IsTab = false;
            this.fbtnDone.Location = new System.Drawing.Point(414, 430);
            this.fbtnDone.Name = "fbtnDone";
            this.fbtnDone.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnDone.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnDone.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnDone.selected = false;
            this.fbtnDone.Size = new System.Drawing.Size(241, 48);
            this.fbtnDone.TabIndex = 1;
            this.fbtnDone.Text = "Done";
            this.fbtnDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnDone.Textcolor = System.Drawing.Color.White;
            this.fbtnDone.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnDone.Click += new System.EventHandler(this.fbtnDone_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.fbtnDone);
            this.Controls.Add(this.bunifuGauge1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGauge bunifuGauge1;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnDone;
    }
}