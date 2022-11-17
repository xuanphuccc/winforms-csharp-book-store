using BTLCSharp.Controllers;
using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLCSharp.View
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Texts;
            string password = txtPassword.Texts;
            lbNotification.Text = "";

            if (username != "" && password != "" &&  Login(username, password))
            {
                Form fHome = new fHome();
                this.Hide();
                fHome.ShowDialog();
                this.Show();

                lbNotification.Text = "";

                txtUsername.Texts = "";
                txtPassword.Texts = "";
            } else
            {
                lbNotification.Text = "Sai tên đăng nhập hoặc mật khẩu";
                lbNotification.ForeColor = Color.Red;
            }
        }

        private bool Login(string username, string password)
        {
            if(AccountDAO.Instance.Login(username, password))
            {
                return true;
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            lbNotification.Text = "";
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result== DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            lbNotification.Text = "";
        }

        private void btnToggleShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !txtPassword.PasswordChar;
        }
    }
}
