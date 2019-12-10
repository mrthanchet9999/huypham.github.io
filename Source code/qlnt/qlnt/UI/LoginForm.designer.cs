namespace qlnt.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.fbtnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlDecor = new System.Windows.Forms.Panel();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.ibtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlDecor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(159, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đăng nhập";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxUsername.Location = new System.Drawing.Point(217, 125);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(294, 30);
            this.txtboxUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblUsername.Location = new System.Drawing.Point(62, 130);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(149, 25);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Tên người dùng";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPassword.Location = new System.Drawing.Point(118, 187);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(93, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxPassword.Location = new System.Drawing.Point(217, 182);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(294, 30);
            this.txtboxPassword.TabIndex = 4;
            // 
            // fbtnLogin
            // 
            this.fbtnLogin.Active = false;
            this.fbtnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnLogin.BorderRadius = 0;
            this.fbtnLogin.ButtonText = "Đăng nhập";
            this.fbtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnLogin.Iconimage")));
            this.fbtnLogin.Iconimage_right = null;
            this.fbtnLogin.Iconimage_right_Selected = null;
            this.fbtnLogin.Iconimage_Selected = null;
            this.fbtnLogin.IconMarginLeft = 0;
            this.fbtnLogin.IconMarginRight = 0;
            this.fbtnLogin.IconRightVisible = true;
            this.fbtnLogin.IconRightZoom = 0D;
            this.fbtnLogin.IconVisible = true;
            this.fbtnLogin.IconZoom = 90D;
            this.fbtnLogin.IsTab = false;
            this.fbtnLogin.Location = new System.Drawing.Point(206, 257);
            this.fbtnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.fbtnLogin.Name = "fbtnLogin";
            this.fbtnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnLogin.selected = false;
            this.fbtnLogin.Size = new System.Drawing.Size(137, 39);
            this.fbtnLogin.TabIndex = 5;
            this.fbtnLogin.Text = "Đăng nhập";
            this.fbtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnLogin.Textcolor = System.Drawing.Color.White;
            this.fbtnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbtnLogin.Click += new System.EventHandler(this.fbtnLogin_Click);
            // 
            // pnlDecor
            // 
            this.pnlDecor.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlDecor.Controls.Add(this.ibtnClose);
            this.pnlDecor.Controls.Add(this.lblTitle);
            this.pnlDecor.Location = new System.Drawing.Point(0, 0);
            this.pnlDecor.Name = "pnlDecor";
            this.pnlDecor.Size = new System.Drawing.Size(550, 82);
            this.pnlDecor.TabIndex = 6;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameError.Location = new System.Drawing.Point(213, 158);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(172, 13);
            this.lblUsernameError.TabIndex = 7;
            this.lblUsernameError.Text = "Sai tên đăng nhập, vui lòng thử lại!";
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(214, 215);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(146, 13);
            this.lblPasswordError.TabIndex = 8;
            this.lblPasswordError.Text = "Sai mật khẩu, vui lòng thử lại!";
            // 
            // ibtnClose
            // 
            this.ibtnClose.Image = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Image")));
            this.ibtnClose.ImageActive = null;
            this.ibtnClose.Location = new System.Drawing.Point(507, 0);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(40, 40);
            this.ibtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnClose.TabIndex = 9;
            this.ibtnClose.TabStop = false;
            this.ibtnClose.Zoom = 10;
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 330);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblUsernameError);
            this.Controls.Add(this.pnlDecor);
            this.Controls.Add(this.fbtnLogin);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtboxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.pnlDecor.ResumeLayout(false);
            this.pnlDecor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtboxPassword;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnLogin;
        private System.Windows.Forms.Panel pnlDecor;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblPasswordError;
        private Bunifu.Framework.UI.BunifuImageButton ibtnClose;
    }
}