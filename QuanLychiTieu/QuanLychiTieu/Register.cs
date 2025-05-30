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
    public partial class Register : Form
    {
        private Login _loginForm;
        private QLChiTieuModel _qLChiTieuModel;
        public Register(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            picEyeShow1.Show();
            picEyeHide1.Hide();
            picEyeShow2.Show();
            picEyeHide2.Hide();
            _qLChiTieuModel = new QLChiTieuModel();
        }

        private void picRegister_Click(object sender, EventArgs e)
        {
            USER _user = new USER();
            //^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$");
            string message = "";
            if (String.IsNullOrEmpty(txtName.Text))
            {
                message += "Fullname cannot be blank!\n";
            }
            else
            {
                _user.FULLNAME = txtName.Text;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                message += "Email cannot be blank!\n";
            }

            else if (regex.IsMatch(txtEmail.Text) == true)
            {
                if (_qLChiTieuModel.USERS.Where(x => x.EMAIL == txtEmail.Text).Any())
                {
                    message += "Email is exists!!\n";
                }
                else
                {
                    _user.EMAIL = txtEmail.Text;
                }
            }
            else
            {
                message += "Invalid email!\n";
            }
            if (rbMale.Checked == true)
            {
                _user.GENDER = rbMale.Text;
            }
            else
            {
                _user.GENDER = rbFemale.Text;
            }
            if (String.IsNullOrEmpty(txtPass.Text) || String.IsNullOrEmpty(txtConfPass.Text))
            {
                message += "Password or ConfirmPass cannot be blank!\n";
            }
            else if (String.Compare(txtPass.Text, txtConfPass.Text, true) != 0)
            {
                message += "Password and ConfirmPass don't matching!\n";
            }
            else
            {
                _user.PASSWORD = new MD5Hash().EncryptionMD5Hash(txtPass.Text);
            }
            if (!String.IsNullOrEmpty(message))
            {
                DialogResult dialog = MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _qLChiTieuModel.USERS.Add(_user);
                _qLChiTieuModel.SaveChanges();
                DialogResult dialog = MessageBox.Show("Register success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                    _loginForm.Show();
                }
            }
        }

        private void picEyeShow1_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
            picEyeShow1.Hide();
            picEyeHide1.Show();
        }

        private void picEyeHide1_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            picEyeShow1.Show();
            picEyeHide1.Hide();

        }

        private void picEyeShow2_Click(object sender, EventArgs e)
        {
            txtConfPass.PasswordChar = '\0';
            picEyeShow2.Hide();
            picEyeHide2.Show();
        }

        private void picEyeHide2_Click(object sender, EventArgs e)
        {
            txtConfPass.PasswordChar = '*';
            picEyeShow2.Show();
            picEyeHide2.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                picRegister_Click(picRegister, new EventArgs());
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                picRegister_Click(picRegister, new EventArgs());
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                picRegister_Click(picRegister, new EventArgs());
            }
        }

        private void txtConfPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                picRegister_Click(picRegister, new EventArgs());
            }
        }
    }
}
