namespace qlnt.UI
{
    partial class Dialog_LapKeHoach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_LapKeHoach));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DatepickerThucHien = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxND = new System.Windows.Forms.RichTextBox();
            this.labelCV = new System.Windows.Forms.Label();
            this.buttonAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.richTextBoxCT = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRadio = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(57, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập kế hoạch";
            // 
            // DatepickerThucHien
            // 
            this.DatepickerThucHien.BackColor = System.Drawing.Color.SeaGreen;
            this.DatepickerThucHien.BorderRadius = 0;
            this.DatepickerThucHien.ForeColor = System.Drawing.Color.White;
            this.DatepickerThucHien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerThucHien.FormatCustom = "dd/MM/yyyy";
            this.DatepickerThucHien.Location = new System.Drawing.Point(200, 138);
            this.DatepickerThucHien.Name = "DatepickerThucHien";
            this.DatepickerThucHien.Size = new System.Drawing.Size(156, 24);
            this.DatepickerThucHien.TabIndex = 22;
            this.DatepickerThucHien.Value = new System.DateTime(2019, 11, 2, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ngày thực hiện:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nội dung:";
            // 
            // richTextBoxND
            // 
            this.richTextBoxND.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxND.Location = new System.Drawing.Point(65, 270);
            this.richTextBoxND.Name = "richTextBoxND";
            this.richTextBoxND.Size = new System.Drawing.Size(373, 115);
            this.richTextBoxND.TabIndex = 26;
            this.richTextBoxND.Text = "";
            // 
            // labelCV
            // 
            this.labelCV.AutoSize = true;
            this.labelCV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCV.Location = new System.Drawing.Point(61, 192);
            this.labelCV.Name = "labelCV";
            this.labelCV.Size = new System.Drawing.Size(84, 19);
            this.labelCV.TabIndex = 27;
            this.labelCV.Text = "Công việc:";
            this.labelCV.UseMnemonic = false;
            this.labelCV.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Active = false;
            this.buttonAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.BorderRadius = 0;
            this.buttonAdd.ButtonText = "Lập kế hoạch";
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAdd.Iconimage = null;
            this.buttonAdd.Iconimage_right = null;
            this.buttonAdd.Iconimage_right_Selected = null;
            this.buttonAdd.Iconimage_Selected = null;
            this.buttonAdd.IconMarginLeft = 0;
            this.buttonAdd.IconMarginRight = 0;
            this.buttonAdd.IconRightVisible = true;
            this.buttonAdd.IconRightZoom = 0D;
            this.buttonAdd.IconVisible = true;
            this.buttonAdd.IconZoom = 90D;
            this.buttonAdd.IsTab = false;
            this.buttonAdd.Location = new System.Drawing.Point(65, 415);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAdd.selected = false;
            this.buttonAdd.Size = new System.Drawing.Size(154, 48);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Lập kế hoạch";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Textcolor = System.Drawing.Color.White;
            this.buttonAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageActive = null;
            this.buttonClose.Location = new System.Drawing.Point(767, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(34, 29);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 29;
            this.buttonClose.TabStop = false;
            this.buttonClose.Zoom = 10;
            this.buttonClose.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // richTextBoxCT
            // 
            this.richTextBoxCT.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.richTextBoxCT.Location = new System.Drawing.Point(484, 270);
            this.richTextBoxCT.Name = "richTextBoxCT";
            this.richTextBoxCT.Size = new System.Drawing.Size(266, 115);
            this.richTextBoxCT.TabIndex = 32;
            this.richTextBoxCT.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Chú thích";
            // 
            // panelRadio
            // 
            this.panelRadio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRadio.BackgroundImage")));
            this.panelRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRadio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRadio.GradientBottomLeft = System.Drawing.Color.White;
            this.panelRadio.GradientBottomRight = System.Drawing.Color.White;
            this.panelRadio.GradientTopLeft = System.Drawing.Color.White;
            this.panelRadio.GradientTopRight = System.Drawing.Color.White;
            this.panelRadio.Location = new System.Drawing.Point(145, 180);
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Quality = 10;
            this.panelRadio.Size = new System.Drawing.Size(542, 33);
            this.panelRadio.TabIndex = 33;
            // 
            // Dialog_LapKeHoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(813, 488);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelRadio);
            this.Controls.Add(this.richTextBoxCT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCV);
            this.Controls.Add(this.richTextBoxND);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatepickerThucHien);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialog_LapKeHoach";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerThucHien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxND;
        private System.Windows.Forms.Label labelCV;
        private Bunifu.Framework.UI.BunifuFlatButton buttonAdd;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
        private System.Windows.Forms.RichTextBox richTextBoxCT;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuGradientPanel panelRadio;
    }
}