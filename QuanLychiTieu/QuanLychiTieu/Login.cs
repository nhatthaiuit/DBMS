using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLychiTieu
{
    public partial class Login : Form
    {
        private QLChiTieuModel _qLChiTieuModel;
        public Login()
        {
            InitializeComponent();
            picEyeShow.Show();
            picEyeHide.Hide();
            _qLChiTieuModel = new QLChiTieuModel();
        }

        private void picLogin_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$");
            string message = "";
            if(String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPass.Text))
            {
                message += "Email or password cannot be blank!\n";
            }
            else if (regex.IsMatch(txtEmail.Text) == true)
            {
                string pass = new MD5Hash().EncryptionMD5Hash(txtPass.Text);
                var values = _qLChiTieuModel.USERS.Where(x => x.EMAIL == txtEmail.Text && x.PASSWORD == pass).FirstOrDefault();
                if (values != null)
                {
                    this.Hide();
                    Home formHome = new Home(this, (int)values.USERID);
                    formHome.Show();
                }
                else
                {
                    message += "Email or password was entered incorrectly!\n";
                }
            }
            else
            {
                message += "Invalid email!\n";
            }
            if (!String.IsNullOrEmpty(message))
            {
                DialogResult dialog = MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picEyeShow_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
            picEyeShow.Hide();
            picEyeHide.Show();
        }

        private void picEyeHide_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            picEyeShow.Show();
            picEyeHide.Hide();
        }

        private void likRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register formRegister = new Register(this);
            formRegister.Show();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                picLogin_Click(picLogin, new EventArgs());
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                picLogin_Click(picLogin, new EventArgs());
            }
        }

        private void picLogin_MouseEnter(object sender, EventArgs e)
        {
            picLogin.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void picLogin_MouseLeave(object sender, EventArgs e)
        {
            picLogin.BackColor = Color.FromArgb(255, 255, 128);
        }
    }
}
