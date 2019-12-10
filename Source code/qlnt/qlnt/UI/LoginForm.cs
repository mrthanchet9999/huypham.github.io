using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlnt.DB.Entity;
using System.Data.SqlClient;

namespace qlnt.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lblUsernameError.Visible = false;
            lblPasswordError.Visible = false;
        }
        private int authority()
        {
            int id = Int32.Parse(txtboxUsername.Text);
            if (id == 0 && txtboxPassword.Text == "admin")
                return 0;
            else if (id == 6 && txtboxPassword.Text == "david")
                return 1;
            else lblPasswordError.Show();
            return -1;
        }
        /*
        private bool verifyLogin (int id, string password)
        {
            bool loginApproved = false;
            string sql = "SELECT* FROM  Login WHERE Username=@UserName AND [Password]=@Password'";

            SqlCommand sqlCommand = new SqlCommand(sql, con);
            sqlCommand.Parameters.Add(new SqlParameter("Name", userName));
            sqlCommand.Parameters.Add(new SqlParameter("[Password]", passWord));
            SqlDataReader rdr = mySQL.ExecuteReader();
            if (rdr.HasrRows()) loginSuccessful = true;
            return loginApproved;
        }

        private int authorized ()
        {
            int authorizedID = -1;
            int id = Int32.Parse(txtboxUsername.Text);
            if (verifyLogin(id, txtboxPassword.Text) == true) authorizedID = 
            return authorizedID;
        }
        */
        private void fbtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newWindow = new Dashboard(authority());
            newWindow.FormClosed += (s, arg) => this.Close();
            newWindow.Show();
        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
