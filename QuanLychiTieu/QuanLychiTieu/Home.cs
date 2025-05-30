using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLychiTieu
{
    public partial class Home : Form
    {
        private QLChiTieuModel _qLChiTieuModel;
        private Login _loginForm;
        private int _userId;
        private bool isProfileClicked = false;
        private bool isExpensesClicked = false;
        private bool isIncomeClicked = false;
        private bool isStatisticClicked = false;
        public Home(Login loginForm, int userId)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _userId = userId;
        }

        private void lbProfile_Click(object sender, EventArgs e)
        {
            lbProfile.BackColor = Color.White;
            lbExpense.BackColor = Color.FromArgb(255, 255, 128);
            lbIncome.BackColor = Color.FromArgb(255, 255, 128);
            lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
            isProfileClicked = true;
            isExpensesClicked = false;
            isIncomeClicked = false;
            isStatisticClicked = false;
            foreach (Control control in pnShowMain.Controls)
            {
                control.Dispose();
            }
            pnShowMain.Controls.Clear();
            formSoon formSoon = new formSoon();
            formSoon.TopLevel = false;
            formSoon.AutoScroll = true;
            pnShowMain.Controls.Add(formSoon);
            formSoon.Show();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                foreach (Control control in pnShowMain.Controls)
                {
                    control.Dispose();
                }
                pnShowMain.Controls.Clear();
                Profile profile = new Profile(_userId);
                profile.TopLevel = false;
                profile.AutoScroll = true;
                pnShowMain.Controls.Add(profile);
                profile.Show();
                timer.Stop();
            };
            timer.Start();
        }

        private void lbExpense_Click(object sender, EventArgs e)
        {
            lbExpense.BackColor = Color.White;
            lbProfile.BackColor = Color.FromArgb(255, 255, 128);
            lbIncome.BackColor = Color.FromArgb(255, 255, 128);
            lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
            isProfileClicked = false;
            isExpensesClicked = true;
            isIncomeClicked = false;
            isStatisticClicked = false;
            foreach (Control control in pnShowMain.Controls)
            {
                control.Dispose();
            }
            pnShowMain.Controls.Clear();
            formSoon formSoon = new formSoon();
            formSoon.TopLevel = false;
            formSoon.AutoScroll = true;
            pnShowMain.Controls.Add(formSoon);
            formSoon.Show();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                foreach (Control control in pnShowMain.Controls)
                {
                    control.Dispose();
                }
                pnShowMain.Controls.Clear();
                Expenses expenses = new Expenses(_userId);
                expenses.TopLevel = false;
                expenses.AutoScroll = true;
                pnShowMain.Controls.Add(expenses);
                expenses.Show();
                timer.Stop();
            };
            timer.Start();
        }

        private void lbIncome_Click(object sender, EventArgs e)
        {
            lbIncome.BackColor = Color.White;
            lbExpense.BackColor = Color.FromArgb(255, 255, 128);
            lbProfile.BackColor = Color.FromArgb(255, 255, 128);
            lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
            isProfileClicked = false;
            isExpensesClicked = false;
            isIncomeClicked = true;
            isStatisticClicked = false;
            foreach (Control control in pnShowMain.Controls)
            {
                control.Dispose();
            }
            pnShowMain.Controls.Clear();
            formSoon formSoon = new formSoon();
            formSoon.TopLevel = false;
            formSoon.AutoScroll = true;
            pnShowMain.Controls.Add(formSoon);
            formSoon.Show();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                foreach (Control control in pnShowMain.Controls)
                {
                    control.Dispose();
                }
                pnShowMain.Controls.Clear();
                InCome income = new InCome(_userId);
                income.TopLevel = false;
                income.AutoScroll = true;
                pnShowMain.Controls.Add(income);
                income.Show();
                timer.Stop();
            };
            timer.Start();
        }

        private void lbStatistics_Click(object sender, EventArgs e)
        {
            lbStatistics.BackColor = Color.White;
            lbIncome.BackColor = Color.FromArgb(255, 255, 128);
            lbExpense.BackColor = Color.FromArgb(255, 255, 128);
            lbProfile.BackColor = Color.FromArgb(255, 255, 128);
            isProfileClicked = false;
            isExpensesClicked = false;
            isIncomeClicked = false;
            isStatisticClicked = true;
            foreach (Control control in pnShowMain.Controls)
            {
                control.Dispose();
            }
            pnShowMain.Controls.Clear();
            formSoon formSoon = new formSoon();
            formSoon.TopLevel = false;
            formSoon.AutoScroll = true;
            pnShowMain.Controls.Add(formSoon);
            formSoon.Show();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                foreach (Control control in pnShowMain.Controls)
                {
                    control.Dispose();
                }
                pnShowMain.Controls.Clear();
                Statistics statistics = new Statistics(_userId);
                statistics.TopLevel = false;
                statistics.AutoScroll = true;
                pnShowMain.Controls.Add(statistics);
                statistics.Show();
                timer.Stop();
            };
            timer.Start();
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            _qLChiTieuModel = new QLChiTieuModel();
            USER user = _qLChiTieuModel.USERS.Find(_userId);
            if (String.Compare(user.GENDER, "Female", true) == 0)
            {
                picAvatar.Image = Properties.Resources.human;
            }
            else
            {
                picAvatar.Image = Properties.Resources.man;
            }
            lbName.Text = user.FULLNAME;
            lbProfile.Paint += new PaintEventHandler(picAvatar_Paint);
            lbExpense.Paint += new PaintEventHandler(picAvatar_Paint);
            lbIncome.Paint += new PaintEventHandler(picAvatar_Paint);
            lbStatistics.Paint += new PaintEventHandler(picAvatar_Paint);
            picLogout.Paint += new PaintEventHandler(picAvatar_Paint);
            
        }
        void picAvatar_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Control)sender).DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void lbProfile_MouseEnter(object sender, EventArgs e)
        {
            if (!isProfileClicked)
            {
                lbProfile.BackColor = Color.White;
            }
        }

        private void lbProfile_MouseLeave(object sender, EventArgs e)
        {

            if (!isProfileClicked)
            {
                lbProfile.BackColor = Color.FromArgb(255, 255, 128);
            }
        }

        private void lbExpense_MouseEnter(object sender, EventArgs e)
        {
            if (!isExpensesClicked)
            {
                lbExpense.BackColor = Color.White;
            }
        }

        private void lbExpense_MouseLeave(object sender, EventArgs e)
        {
            if (!isExpensesClicked)
            {
                lbExpense.BackColor = Color.FromArgb(255, 255, 128);
            }
        }

        private void lbIncome_MouseEnter(object sender, EventArgs e)
        {
            if (!isIncomeClicked)
            {
                lbIncome.BackColor = Color.White;
            }
        }

        private void lbIncome_MouseLeave(object sender, EventArgs e)
        {
            if (!isIncomeClicked)
            {
                lbIncome.BackColor = Color.FromArgb(255, 255, 128);
            }
        }

        private void lbStatistics_MouseEnter(object sender, EventArgs e)
        {
            if (!isStatisticClicked)
            {
                lbStatistics.BackColor = Color.White;
            }
        }

        private void lbStatistics_MouseLeave(object sender, EventArgs e)
        {
            if (!isStatisticClicked)
            {
                lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
            }
        }

        private void picLogout_MouseEnter(object sender, EventArgs e)
        {
            picLogout.BackColor = Color.White;
        }

        private void picLogout_MouseLeave(object sender, EventArgs e)
        {
            picLogout.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            string message = "";
            if (_qLChiTieuModel.EXPENSES.Any(x => x.USERID == _userId && x.EXDATE.Value.Month == DateTime.Now.Month) && _qLChiTieuModel.INCOMEs.Any(x => x.USERID == _userId && x.INDATE.Value.Month == DateTime.Now.Month))
            {
                var totalMonthCur = (from expense in _qLChiTieuModel.EXPENSES
                                     where expense.USERID == _userId && expense.EXDATE.Value.Month == DateTime.Now.Month
                                     select expense.MONEY).Sum();
                int preMonth = DateTime.Now.AddMonths(-1).Month;
                var totalMonthPre = (from expense in _qLChiTieuModel.EXPENSES
                                     where expense.USERID == _userId && expense.EXDATE.Value.Month == preMonth
                                     select expense.MONEY).Sum();
                if (totalMonthPre != 0 && ((totalMonthCur - totalMonthPre) / totalMonthPre) * 100 > 0)
                {
                    message += "This month, expenses increased by " + Math.Round((double)((totalMonthCur - totalMonthPre) / totalMonthPre) * 100, 0) + "%";
                }
                else if (totalMonthPre != 0 && ((totalMonthCur - totalMonthPre) / totalMonthPre) * 100 < 0)
                {
                    message += "This month, expenses decreased by " + Math.Round((double)((totalMonthCur - totalMonthPre) / totalMonthPre) * 100 * -1, 0) + "%";
                }
                else
                {
                    message += "Last month you did not update any expenses\n";
                }
                totalMonthCur = (from income in _qLChiTieuModel.INCOMEs
                                 where income.USERID == _userId && income.INDATE.Value.Month == DateTime.Now.Month
                                 select income.MONEY).Sum();
                totalMonthPre = (from income in _qLChiTieuModel.INCOMEs
                                 where income.USERID == _userId && income.INDATE.Value.Month == preMonth
                                 select income.MONEY).Sum();
                if (totalMonthPre != 0 && ((totalMonthCur - totalMonthPre) / totalMonthPre) * 100 > 0)
                {
                    message += ", income increased by " + Math.Round((double)((totalMonthCur - totalMonthPre) / totalMonthPre) * 100, 0) + "% compared to last month\n";
                }
                else if (totalMonthPre != 0 && ((totalMonthCur - totalMonthPre) / totalMonthPre) * 100 < 0)
                {
                    message += ", income decreased by " + Math.Round((double)((totalMonthCur - totalMonthPre) / totalMonthPre) * 100 * -1, 0) + "% compared to last month\n";
                }
                else
                {
                    message += "Last month you did not update any income\n";
                }
                NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = ".", NumberDecimalDigits = 0 };
                var totalYear = (from expense in _qLChiTieuModel.EXPENSES
                                 where expense.USERID == _userId && expense.EXDATE.Value.Year == DateTime.Now.Year
                                 select expense.MONEY).Sum();
                message += "This year, the average monthly expenses is: " + (totalYear / 12).Value.ToString("#,##0", nfi) + " VND; ";
                totalYear = (from income in _qLChiTieuModel.INCOMEs
                             where income.USERID == _userId && income.INDATE.Value.Year == DateTime.Now.Year
                             select income.MONEY).Sum();
                message += "the average monthly income is: " + (totalYear / 12).Value.ToString("#,##0", nfi) + " VND.";
                DialogResult dialog = MessageBox.Show(message, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (_qLChiTieuModel.EXPENSES.Any(x => x.USERID == _userId && x.EXDATE.Value.Year == DateTime.Now.Year) && _qLChiTieuModel.INCOMEs.Any(x => x.USERID == _userId && x.INDATE.Value.Year == DateTime.Now.Year))
            {
                NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = ".", NumberDecimalDigits = 0 };
                var totalYear = (from expense in _qLChiTieuModel.EXPENSES
                                 where expense.USERID == _userId && expense.EXDATE.Value.Year == DateTime.Now.Year
                                 select expense.MONEY).Sum();
                message += "This year, the average monthly expenses is: " + (totalYear / 12).Value.ToString("#,##0", nfi) + " VND; ";
                totalYear = (from income in _qLChiTieuModel.INCOMEs
                             where income.USERID == _userId && income.INDATE.Value.Year == DateTime.Now.Year
                             select income.MONEY).Sum();
                message += "the average monthly income is: " + (totalYear / 12).Value.ToString("#,##0", nfi) + " VND.";
                DialogResult dialog = MessageBox.Show(message, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
