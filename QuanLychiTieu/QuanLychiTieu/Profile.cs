using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLychiTieu
{
    public partial class Profile : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        private bool ischeck = false;
        public Profile(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _qLChiTieu = new QLChiTieuModel();
            picEyeShow1.Show();
            picEyeHide1.Hide();
            picEyeShow2.Show();
            picEyeHide2.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            pnUpdatePass.Hide();
            USER user = _qLChiTieu.USERS.Find(_userId);
            txtName.Text = user.FULLNAME;
            txtEmail.Text = user.EMAIL;
            if(String.Compare(user.GENDER, "Female", true) == 0)
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = ".", NumberDecimalDigits = 0 };
            var totalYearEx = (from expense in _qLChiTieu.EXPENSES
                             where expense.USERID == _userId && expense.EXDATE.Value.Year == DateTime.Now.Year
                             select expense.MONEY).Sum();
            var totalYearIn = (from income in _qLChiTieu.INCOMEs
                         where income.USERID == _userId && income.INDATE.Value.Year == DateTime.Now.Year
                         select income.MONEY).Sum();
            if (totalYearEx.HasValue && totalYearIn.HasValue)
            {
                lbMoneyEx.Text = totalYearEx.Value.ToString("#,##0", nfi) + " VND";
                lbMoneyIncome.Text = totalYearIn.Value.ToString("#,##0", nfi) + " VND";
                lbBalance.Text = (totalYearIn - totalYearEx).Value.ToString("#,##0", nfi) + " VND";
                if ((totalYearIn - totalYearEx) < 0)
                {
                    ischeck = true;
                }
            }
            else
            {
                lbMoneyEx.Text = "0.00 VND";
                lbMoneyIncome.Text = "0.00 VND";
                lbBalance.Text = "0.00 VND";
            }
           
        }

        private void likChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pnUpdatePass.Visible)
            {
                pnUpdatePass.Hide();
            }
            else
            {
                pnUpdatePass.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            USER _user = _qLChiTieu.USERS.Find(_userId);
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
                _user.EMAIL = txtEmail.Text;
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
            if (pnUpdatePass.Visible)
            {
                //"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$
                if (String.IsNullOrEmpty(txtPass.Text) || String.IsNullOrEmpty(txtConfirmPass.Text))
                {
                    message += "Password or ConfirmPass cannot be blank!\n";
                }
                else if (String.Compare(txtPass.Text, txtConfirmPass.Text, true) != 0)
                {
                    message += "New password and ConfirmPass don't matching!\n";
                }
                else
                {
                    _user.PASSWORD = new MD5Hash().EncryptionMD5Hash(txtPass.Text);
                }
            }
            if (!String.IsNullOrEmpty(message))
            {
                DialogResult dialog = MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _qLChiTieu.SaveChanges();
                DialogResult dialog = MessageBox.Show("Update success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtConfirmPass.PasswordChar = '\0';
            picEyeShow2.Hide();
            picEyeHide2.Show();
        }

        private void picEyeHide2_Click(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = '*';
            picEyeShow2.Show();
            picEyeHide2.Hide();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }

        private void txtConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }

        private void Profile_Shown(object sender, EventArgs e)
        {
            if (ischeck)
            {
                DialogResult dialog = MessageBox.Show("A negative balance could be due to you forgetting to update your income entries, or there may have been errors in entering income and expenditure information into the system.\n Please verify again!!", "Notify", MessageBoxButtons.OK);
            }
        }
    }
}
