using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QuanLychiTieu
{
    public partial class Statistics : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        private List<ComboItem> _comboItems;
        private List<ComboItem> _comboValues;
        public Statistics(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _comboItems = new List<ComboItem> {
            new ComboItem{ Value = 1, Display = "This week"},
            new ComboItem{ Value = 2, Display = "By month of current year" },
            new ComboItem{ Value = 3, Display = "By current year" },
            new ComboItem{ Value = 4, Display = "By month is selected time"},
            new ComboItem{ Value = 5, Display = "By year is selected time"}
            };
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            cbValue.Hide();
            dateFill.Value = DateTime.Now;
            _qLChiTieu = new QLChiTieuModel();
            var expenses = _qLChiTieu.EXPENSES.Join(_qLChiTieu.EXPENSESTYPEs, x => x.EXTYPEID, y => y.EXTYPEID, (x, y) => new { x, y })
                           .Where(z => z.x.USERID == _userId && z.y.ISACTIVE == "Y")
                           .GroupBy(z => z.x.EXDATE.Value.Year)
                           .Select(z => new { date = z.Key, money = z.Sum(m => m.x.MONEY) })
                           .OrderByDescending(x => x.date)
                           .Take(5)
                           .ToList();
            foreach (var item in expenses)
            {
                chartMain.Series["Expenses"].Points.AddXY(item.date, (double)item.money);
            }
            var income = _qLChiTieu.INCOMEs.Join(_qLChiTieu.INCOMETYPEs, x => x.INTYPEID, y => y.INTYPEID, (x, y) => new { x, y })
                         .Where(z => z.x.USERID == _userId && z.y.ISACTIVE == "Y")
                         .GroupBy(z => z.x.INDATE.Value.Year)
                         .Select(z => new { date = z.Key, money = z.Sum(m => m.x.MONEY) })
                         .OrderByDescending(x => x.date)
                         .Take(5)
                         .ToList();
            foreach (var item in income)
            {
                chartMain.Series["Income"].Points.AddXY(item.date, (double)item.money);
            }
            cbFill.SelectedIndexChanged -= cbFill_SelectedIndexChanged;
            cbFill.DataSource = _comboItems;
            cbFill.ValueMember = "Value";
            cbFill.DisplayMember = "Display";
            cbFill.SelectedIndexChanged += cbFill_SelectedIndexChanged;
        }

        private void lkExpenses_MouseEnter(object sender, EventArgs e)
        {
            lkExpenses.LinkColor = Color.Red;
        }

        private void lkExpenses_MouseLeave(object sender, EventArgs e)
        {
            lkExpenses.LinkColor = Color.Gray;
        }

        private void lkIncome_MouseEnter(object sender, EventArgs e)
        {
            lkIncome.LinkColor = Color.Red;
        }

        private void lkIncome_MouseLeave(object sender, EventArgs e)
        {
            lkIncome.LinkColor = Color.Gray;
        }

        private void cbFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DateTime> allDates = new List<DateTime>();
            var selectItem = cbFill.SelectedValue;
            switch (selectItem)
            {
                case 1:
                    cbValue.Hide();
                    chartMain.Series["Expenses"].Points.Clear();
                    chartMain.Series["Income"].Points.Clear();
                    string sql = "SELECT EXPENSES.EXDATE AS \"_date\", SUM(EXPENSES.MONEY) AS \"_money\" " +
                                 "FROM EXPENSES JOIN EXPENSESTYPE ON EXPENSES.EXTYPEID = EXPENSESTYPE.EXTYPEID " +
                                 "WHERE EXPENSES.USERID = :p0 AND EXPENSESTYPE.ISACTIVE = 'Y' AND " +
                                 "EXPENSES.EXDATE >= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') AND " +
                                 "EXPENSES.EXDATE <= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') + 6 " +
                                 "GROUP BY EXPENSES.EXDATE " +
                                 "ORDER BY EXPENSES.EXDATE";
                    var expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, DateTime.Now.ToShortDateString());
                    sql = "SELECT INCOME.INDATE AS \"_date\", SUM(INCOME.MONEY) AS \"_money\" " +
                          "FROM INCOME JOIN INCOMETYPE ON INCOME.INTYPEID = INCOMETYPE.INTYPEID " +
                          "WHERE INCOME.USERID = :p0 AND INCOMETYPE.ISACTIVE = 'Y' AND " +
                          "INCOME.INDATE >= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') AND " +
                          "INCOME.INDATE <= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') + 6 " +
                          "GROUP BY INCOME.INDATE " +
                          "ORDER BY INCOME.INDATE";
                    var income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, DateTime.Now.ToShortDateString());
                    allDates.Clear();
                    allDates.AddRange(expenses.Select(i => i._date).Distinct());
                    allDates.AddRange(income.Select(i => i._date).Distinct());
                    allDates = allDates.Distinct().ToList();
                    allDates.Sort();
                    if (expenses.Any() == false && income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            Statistics_Load(sender, e);
                        }
                    }
                    else
                    {
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!expenses.Any(i => i._date == dt))
                            {
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = expenses.First(i => i._date == dt);
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, (double)item._money);
                            }
                            if (!income.Any(i => i._date == dt))
                            {
                                chartMain.Series["Income"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = income.First(i => i._date == dt);
                                chartMain.Series["Income"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                    }
                    break;
                case 2:
                    _comboValues = new List<ComboItem> {
                    new ComboItem{Value = 1, Display = "January" },
                    new ComboItem{Value = 2, Display = "February" },
                    new ComboItem{Value = 3, Display = "March" },
                    new ComboItem{Value = 4, Display = "April" },
                    new ComboItem{Value = 5, Display = "May" },
                    new ComboItem{Value = 6, Display = "June" },
                    new ComboItem{Value = 7, Display = "July" },
                    new ComboItem{Value = 8, Display = "August" },
                    new ComboItem{Value = 9, Display = "September" },
                    new ComboItem{Value = 10, Display = "October" },
                    new ComboItem{Value = 11, Display = "November" },
                    new ComboItem{Value = 12, Display = "December" },
                    };
                    cbValue.SelectedIndexChanged -= cbValue_SelectedIndexChanged;
                    cbValue.DataSource = _comboValues;
                    cbValue.ValueMember = "Value";
                    cbValue.DisplayMember = "Display";
                    cbValue.SelectedIndexChanged += cbValue_SelectedIndexChanged;
                    cbValue.Show();
                    break;
                case 3:
                    cbValue.Hide();
                    chartMain.Series["Expenses"].Points.Clear();
                    chartMain.Series["Income"].Points.Clear();
                    sql = "SELECT EXPENSES.EXDATE AS \"_date\", SUM(EXPENSES.MONEY) AS \"_money\" " +
                           "FROM EXPENSES JOIN EXPENSESTYPE ON EXPENSES.EXTYPEID = EXPENSESTYPE.EXTYPEID " +
                           "WHERE EXPENSES.USERID = :p0 AND EXPENSESTYPE.ISACTIVE = 'Y' AND " +
                           "EXTRACT(YEAR FROM EXPENSES.EXDATE) = :p1 " +
                           "GROUP BY EXPENSES.EXDATE " +
                           "ORDER BY EXPENSES.EXDATE";
                    expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, DateTime.Now.Year);
                    sql = "SELECT INCOME.INDATE AS \"_date\", SUM(INCOME.MONEY) AS \"_money\" " +
                          "FROM INCOME JOIN INCOMETYPE ON INCOME.INTYPEID = INCOMETYPE.INTYPEID " +
                          "WHERE INCOME.USERID = :p0 AND INCOMETYPE.ISACTIVE = 'Y' AND " +
                          "EXTRACT(YEAR FROM INCOME.INDATE) = :p1 " +
                          "GROUP BY INCOME.INDATE " +
                          "ORDER BY INCOME.INDATE";
                    income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, DateTime.Now.Year);
                    allDates.Clear();
                    allDates.AddRange(expenses.Select(i => i._date).Distinct());
                    allDates.AddRange(income.Select(i => i._date).Distinct());
                    allDates = allDates.Distinct().ToList();
                    allDates.Sort();
                    if (expenses.Any() == false && income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            Statistics_Load(sender, e);
                        }
                    }
                    else
                    {
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!expenses.Any(i => i._date == dt))
                            {
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = expenses.First(i => i._date == dt);
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, (double)item._money);
                            }
                            if (!income.Any(i => i._date == dt))
                            {
                                chartMain.Series["Income"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = income.First(i => i._date == dt);
                                chartMain.Series["Income"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                    }
                    break;
                case 4:
                    cbValue.Hide();
                    chartMain.Series["Expenses"].Points.Clear();
                    chartMain.Series["Income"].Points.Clear();
                    sql = "SELECT EXPENSES.EXDATE AS \"_date\", SUM(EXPENSES.MONEY) AS \"_money\" " +
                           "FROM EXPENSES JOIN EXPENSESTYPE ON EXPENSES.EXTYPEID = EXPENSESTYPE.EXTYPEID " +
                           "WHERE EXPENSES.USERID = :p0 AND EXPENSESTYPE.ISACTIVE = 'Y' AND " +
                           "EXTRACT(MONTH FROM EXPENSES.EXDATE) = :p1 AND " +
                           "EXTRACT(YEAR FROM EXPENSES.EXDATE) = :p2 " +
                           "GROUP BY EXPENSES.EXDATE " +
                           "ORDER BY EXPENSES.EXDATE";
                    expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, dateFill.Value.Month, dateFill.Value.Year);
                    sql = "SELECT INCOME.INDATE AS \"_date\", SUM(INCOME.MONEY) AS \"_money\" " +
                          "FROM INCOME JOIN INCOMETYPE ON INCOME.INTYPEID = INCOMETYPE.INTYPEID " +
                          "WHERE INCOME.USERID = :p0 AND INCOMETYPE.ISACTIVE = 'Y' AND " +
                          "EXTRACT(MONTH FROM INCOME.INDATE) = :p1 AND " +
                          "EXTRACT(YEAR FROM INCOME.INDATE) = :p2 " +
                          "GROUP BY INCOME.INDATE " +
                          "ORDER BY INCOME.INDATE";
                    income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, dateFill.Value.Month, dateFill.Value.Year);
                    allDates.Clear();
                    allDates.AddRange(expenses.Select(i => i._date).Distinct());
                    allDates.AddRange(income.Select(i => i._date).Distinct());
                    allDates = allDates.Distinct().ToList();
                    allDates.Sort();
                    if (expenses.Any() == false && income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            Statistics_Load(sender, e);
                        }
                    }
                    else
                    {
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!expenses.Any(i => i._date == dt))
                            {
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = expenses.First(i => i._date == dt);
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, (double)item._money);
                            }
                            if (!income.Any(i => i._date == dt))
                            {
                                chartMain.Series["Income"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = income.First(i => i._date == dt);
                                chartMain.Series["Income"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                    }
                    break;
                case 5:
                    cbValue.Hide();
                    chartMain.Series["Expenses"].Points.Clear();
                    chartMain.Series["Income"].Points.Clear();
                    sql ="SELECT EXPENSES.EXDATE AS \"_date\", SUM(EXPENSES.MONEY) AS \"_money\" " +
                           "FROM EXPENSES JOIN EXPENSESTYPE ON EXPENSES.EXTYPEID = EXPENSESTYPE.EXTYPEID " +
                           "WHERE EXPENSES.USERID = :p0 AND EXPENSESTYPE.ISACTIVE = 'Y' AND " +
                           "EXTRACT(YEAR FROM EXPENSES.EXDATE) = :p1 " +
                           "GROUP BY EXPENSES.EXDATE " +
                           "ORDER BY EXPENSES.EXDATE";
                    expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, dateFill.Value.Year);
                    sql = "SELECT INCOME.INDATE AS \"_date\", SUM(INCOME.MONEY) AS \"_money\" " +
                          "FROM INCOME JOIN INCOMETYPE ON INCOME.INTYPEID = INCOMETYPE.INTYPEID " +
                          "WHERE INCOME.USERID = :p0 AND INCOMETYPE.ISACTIVE = 'Y' AND " +
                          "EXTRACT(YEAR FROM INCOME.INDATE) = :p1 " +
                          "GROUP BY INCOME.INDATE " +
                          "ORDER BY INCOME.INDATE";
                    income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, dateFill.Value.Year);
                    allDates.Clear();
                    allDates.AddRange(expenses.Select(i => i._date).Distinct());
                    allDates.AddRange(income.Select(i => i._date).Distinct());
                    allDates = allDates.Distinct().ToList();
                    allDates.Sort();
                    if (expenses.Any() == false && income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            Statistics_Load(sender, e);
                        }
                    }
                    else
                    {
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!expenses.Any(i => i._date == dt))
                            {
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = expenses.First(i => i._date == dt);
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, (double)item._money);
                            }
                            if (!income.Any(i => i._date == dt))
                            {
                                chartMain.Series["Income"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = income.First(i => i._date == dt);
                                chartMain.Series["Income"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";
            chartMain.Series["Expenses"].Points.Clear();
            chartMain.Series["Income"].Points.Clear();
            List<DateTime> allDates = new List<DateTime>();
            sql = "SELECT EXPENSES.EXDATE AS \"_date\", SUM(EXPENSES.MONEY) AS \"_money\" " +
                  "FROM EXPENSES JOIN EXPENSESTYPE ON EXPENSES.EXTYPEID = EXPENSESTYPE.EXTYPEID " +
                  "WHERE EXPENSES.USERID = :p0 AND EXPENSESTYPE.ISACTIVE = 'Y' AND " +
                  "EXTRACT(MONTH FROM EXPENSES.EXDATE) = :p1 AND " +
                  "EXTRACT(YEAR FROM EXPENSES.EXDATE) = :p2 " +
                  "GROUP BY EXPENSES.EXDATE " +
                  "ORDER BY EXPENSES.EXDATE";
            var expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, cbValue.SelectedValue, DateTime.Now.Year);
            sql = "SELECT INCOME.INDATE AS \"_date\", SUM(INCOME.MONEY) AS \"_money\" " +
                  "FROM INCOME JOIN INCOMETYPE ON INCOME.INTYPEID = INCOMETYPE.INTYPEID " +
                  "WHERE INCOME.USERID = :p0 AND INCOMETYPE.ISACTIVE = 'Y' AND " +
                  "EXTRACT(MONTH FROM INCOME.INDATE) = :p1 AND " +
                  "EXTRACT(YEAR FROM INCOME.INDATE) = :p2 " +
                  "GROUP BY INCOME.INDATE " +
                  "ORDER BY INCOME.INDATE";
            var income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, cbValue.SelectedValue, DateTime.Now.Year);
            allDates.Clear();
            allDates.AddRange(expenses.Select(i => i._date).Distinct());
            allDates.AddRange(income.Select(i => i._date).Distinct());
            allDates = allDates.Distinct().ToList();
            allDates.Sort();
            if (expenses.Any() == false && income.Any() == false)
            {
                DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    Statistics_Load(sender, e);
                }
            }
            else
            {
                foreach (DateTime dt in allDates)
                {
                    string dtLabel = dt.ToString("dd-MM");
                    if (!expenses.Any(i => i._date == dt))
                    {
                        chartMain.Series["Expenses"].Points.AddXY(dtLabel, 0);
                    }
                    else
                    {
                        var item = expenses.First(i => i._date == dt);
                        chartMain.Series["Expenses"].Points.AddXY(dtLabel, (double)item._money);
                    }
                    if (!income.Any(i => i._date == dt))
                    {
                        chartMain.Series["Income"].Points.AddXY(dtLabel, 0);
                    }
                    else
                    {
                        var item = income.First(i => i._date == dt);
                        chartMain.Series["Income"].Points.AddXY(dtLabel, (double)item._money);
                    }
                }
            }
        }

        private void lkExpenses_Click(object sender, EventArgs e)
        {
            pnStatistc.Controls.Clear();
            StatisticExpenses statisticExpenses = new StatisticExpenses(_userId);
            statisticExpenses.TopLevel = false;
            statisticExpenses.AutoScroll = true;
            pnStatistc.Controls.Add(statisticExpenses);
            statisticExpenses.Show();
        }

        private void lkIncome_MouseEnter_1(object sender, EventArgs e)
        {
            lkIncome.LinkColor = Color.Red;
        }

        private void lkIncome_MouseLeave_1(object sender, EventArgs e)
        {
            lkIncome.LinkColor = Color.Gray;
        }

        private void lkIncome_Click(object sender, EventArgs e)
        {
            pnStatistc.Controls.Clear();
            StatisticIncome statisticIncome = new StatisticIncome(_userId);
            statisticIncome.TopLevel = false;
            statisticIncome.AutoScroll = true;
            pnStatistc.Controls.Add(statisticIncome);
            statisticIncome.Show();
        }

        private void picLoad_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            picLoad.Image = Properties.Resources.work_in_progress;
            timer.Tick += (s, ev) =>
            {
                picLoad.Image = Properties.Resources.work_in_progress_static;
                foreach (var series in chartMain.Series)
                {
                    chartMain.Series[series.Name].Points.Clear();
                }
                Statistics_Load(sender, e);
                timer.Stop();

            };
            timer.Start();
        }
    }
}
