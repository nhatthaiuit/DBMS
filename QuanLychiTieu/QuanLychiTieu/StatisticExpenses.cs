using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLychiTieu
{
    public partial class StatisticExpenses : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        private List<ComboItem> _comboItems;
        private List<ComboItem> _comboValues;
        public StatisticExpenses(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _qLChiTieu = new QLChiTieuModel();
            _comboItems = new List<ComboItem> {
            new ComboItem{ Value = 1, Display = "This week"},
            new ComboItem{ Value = 2, Display = "By month of current year" },
            new ComboItem{ Value = 3, Display = "By current year" },
            new ComboItem{ Value = 4, Display = "By month is selected time"},
            new ComboItem{ Value = 5, Display = "By year is selected time"}
            };
        }

        private void lkHome_Click(object sender, EventArgs e)
        {
            pnStatisEx.Controls.Clear();
            Statistics statistic = new Statistics(_userId);
            statistic.TopLevel = false;
            statistic.AutoScroll = true;
            pnStatisEx.Controls.Add(statistic);
            statistic.Show();
        }

        private void StatisticExpenses_Load(object sender, EventArgs e)
        {
            cbValue.Hide();
            cbFill.SelectedIndexChanged -= cbFill_SelectedIndexChanged;
            cbFill.DataSource = _comboItems;
            cbFill.ValueMember = "Value";
            cbFill.DisplayMember = "Display";
            cbFill.SelectedIndexChanged += cbFill_SelectedIndexChanged;
            List<int> allYear = new List<int>();
            List<string> allType = new List<string>();
            var expenses = _qLChiTieu.EXPENSES.Join(_qLChiTieu.EXPENSESTYPEs, x => x.EXTYPEID, y => y.EXTYPEID, (x, y) => new { x, y })
                            .Where(z => z.x.USERID == _userId && z.y.ISACTIVE == "Y")
                            .GroupBy(z => new { z.y.NAMEEXTYPE, z.x.EXDATE.Value.Year })
                            .OrderBy(z => z.Key.Year)
                            .Select(z => new
                            {
                                NameExType = z.Key.NAMEEXTYPE,
                                Year = z.Key.Year,
                                money = z.Sum(m => m.x.MONEY)
                            })
                            .ToList();
            allYear.AddRange(expenses.Select(x => x.Year).Distinct());
            allType.AddRange(expenses.Select(x => x.NameExType));
            foreach (var type in allType)
            {
                if (!chartMain.Series.Any(x => x.Name == type))
                {
                    chartMain.Series.Add(type);
                }
            }
            foreach (var year in allYear)
            {
                foreach (var series in chartMain.Series)
                {
                    if (expenses.Any(x => x.NameExType == series.Name && x.Year == year))
                    {
                        var item = expenses.First(x => x.NameExType == series.Name && x.Year == year);
                        chartMain.Series[series.Name].Points.AddXY(year, (double)item.money);
                    }
                    else
                    {
                        chartMain.Series[series.Name].Points.AddXY(year, 0);
                    }
                }
            }
        }

        private void lkHome_MouseEnter(object sender, EventArgs e)
        {
            lkHome.LinkColor = Color.Red;
        }

        private void lkHome_MouseLeave(object sender, EventArgs e)
        {
            lkHome.LinkColor = Color.Gray;
        }

        private void cbFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = cbFill.SelectedValue;
            switch (selectItem)
            {
                case 1:
                    cbValue.Hide();
                    foreach (var series in chartMain.Series)
                    {
                        chartMain.Series[series.Name].Points.Clear();
                    }
                    string sql = "SELECT SUM(EXPENSES.MONEY) AS \"_money\", EXPENSES.EXDATE AS \"_date\", SUM(EXPENSES.MONEY) AS \"_money\" " +
                                 "FROM EXPENSES JOIN EXPENSESTYPE ON EXPENSES.EXTYPEID = EXPENSESTYPE.EXTYPEID " +
                                 "WHERE EXPENSES.USERID = :p0 AND EXPENSESTYPE.ISACTIVE = 'Y' AND " +
                                 "EXDATE >= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') AND " +
                                 "EXDATE <= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') + 6 " +
                                 "GROUP BY EXPENSESTYPE.NAMEEXTYPE, EXPENSES.EXDATE " +
                                 "ORDER BY EXPENSES.EXDATE";
                    var expenses = _qLChiTieu.Database.SqlQuery<ResultDbEXIn>(sql, _userId, DateTime.Now.ToShortDateString());
                    if (expenses.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            StatisticExpenses_Load(sender, e);
                        }
                    }
                    else
                    {
                        List<DateTime> allDate = new List<DateTime>();
                        allDate.AddRange(expenses.Select(x => x._date).Distinct());
                        foreach (var dt in allDate)
                        {
                            string date = dt.ToString("dd-MM");
                            foreach (var series in chartMain.Series)
                            {
                                if (expenses.Any(x => x._nameType == series.Name && x._date.Date == dt.Date))
                                {
                                    var item = expenses.First(x => x._nameType == series.Name && x._date.Date == dt.Date);
                                    chartMain.Series[series.Name].Points.AddXY(date, (double)item._money);
                                }
                                else
                                {
                                    chartMain.Series[series.Name].Points.AddXY(date, 0);
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    cbValue.Show();
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
                    foreach (var series in chartMain.Series)
                    {
                        chartMain.Series[series.Name].Points.Clear();
                    }
                    sql = "SELECT EXPENSESTYPE.NAMEEXTYPE AS \"_nameType\", EXPENSES.EXDATE AS \"_date\", SUM(EXPENSES.MONEY) AS \"_money\" " +
                          "FROM EXPENSES JOIN EXPENSESTYPE ON EXPENSES.EXTYPEID = EXPENSESTYPE.EXTYPEID " +
                          "WHERE EXPENSES.USERID = :p0 AND EXPENSESTYPE.ISACTIVE = 'Y' AND " +
                          "EXTRACT(YEAR FROM EXPENSES.EXDATE) = :p1 " +
                          "GROUP BY EXPENSESTYPE.NAMEEXTYPE, EXPENSES.EXDATE " +
                               "ORDER BY EXPENSES.EXDATE";
                    expenses = _qLChiTieu.Database.SqlQuery<ResultDbEXIn>(sql, _userId, DateTime.Now.Year);
                    if (expenses.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            StatisticExpenses_Load(sender, e);
                        }
                    }
                    else
                    {
                        List<DateTime> allDate = new List<DateTime>();
                        allDate.AddRange(expenses.Select(x => x._date).Distinct());
                        foreach (var dt in allDate)
                        {
                            string date = dt.ToString("dd-MM");
                            foreach (var series in chartMain.Series)
                            {
                                if (expenses.Any(x => x._nameType == series.Name && x._date.Date == dt.Date))
                                {
                                    var item = expenses.First(x => x._nameType == series.Name && x._date.Date == dt.Date);
                                    chartMain.Series[series.Name].Points.AddXY(date, (double)item._money);
                                }
                                else
                                {
                                    chartMain.Series[series.Name].Points.AddXY(date, 0);
                                }
                            }
                        }
                    }
                    break;
                case 4:
                    cbValue.Hide();
                    foreach (var series in chartMain.Series)
                    {
                        chartMain.Series[series.Name].Points.Clear();
                    }
                    sql = "SELECT EXPENSESTYPE.NAMEEXTYPE AS \"_nameType\", EXPENSES.EXDATE AS \"_date\", SUM(EXPENSES.MONEY) AS \"_money\" " +
                          "FROM EXPENSES JOIN EXPENSESTYPE ON EXPENSES.EXTYPEID = EXPENSESTYPE.EXTYPEID " +
                          "WHERE EXPENSES.USERID = :p0 AND EXPENSESTYPE.ISACTIVE = 'Y' AND " +
                          "EXTRACT(MONTH FROM EXPENSES.EXDATE) = :p1 AND " +
                          "EXTRACT(YEAR FROM EXPENSES.EXDATE) = :p2 " +
                          "GROUP BY EXPENSESTYPE.NAMEEXTYPE, EXPENSES.EXDATE " +
                          "ORDER BY EXPENSES.EXDATE";
                    expenses = _qLChiTieu.Database.SqlQuery<ResultDbEXIn>(sql, _userId, dateFill.Value.Month, dateFill.Value.Year);
                    if (expenses.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            StatisticExpenses_Load(sender, e);
                        }
                    }
                    else
                    {
                        List<DateTime> allDate = new List<DateTime>();
                        allDate.AddRange(expenses.Select(x => x._date).Distinct());
                        foreach (var dt in allDate)
                        {
                            string date = dt.ToString("dd-MM");
                            foreach (var series in chartMain.Series)
                            {
                                if (expenses.Any(x => x._nameType == series.Name && x._date.Date == dt.Date))
                                {
                                    var item = expenses.First(x => x._nameType == series.Name && x._date.Date == dt.Date);
                                    chartMain.Series[series.Name].Points.AddXY(date, (double)item._money);
                                }
                                else
                                {
                                    chartMain.Series[series.Name].Points.AddXY(date, 0);
                                }
                            }
                        }
                    }
                    break;
                default:
                    cbValue.Hide();
                    foreach (var series in chartMain.Series)
                    {
                        chartMain.Series[series.Name].Points.Clear();
                    }
                    sql = "SELECT EXPENSESTYPE.NAMEEXTYPE AS \"_nameType\", EXPENSES.EXDATE AS \"_date\", SUM(EXPENSES.MONEY) AS \"_money\" " +
                          "FROM EXPENSES JOIN EXPENSESTYPE ON EXPENSES.EXTYPEID = EXPENSESTYPE.EXTYPEID " +
                          "WHERE EXPENSES.USERID = :p0 AND EXPENSESTYPE.ISACTIVE = 'Y' AND " +
                          "EXTRACT(YEAR FROM EXPENSES.EXDATE) = :p1 " +
                          "GROUP BY EXPENSESTYPE.NAMEEXTYPE, EXPENSES.EXDATE " +
                          "ORDER BY EXPENSES.EXDATE";
                    expenses = _qLChiTieu.Database.SqlQuery<ResultDbEXIn>(sql, _userId, dateFill.Value.Year);
                    if (expenses.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            StatisticExpenses_Load(sender, e);
                        }
                    }
                    else
                    {
                        List<DateTime> allDate = new List<DateTime>();
                        allDate.AddRange(expenses.Select(x => x._date).Distinct());
                        foreach (var dt in allDate)
                        {
                            string date = dt.ToString("dd-MM");
                            foreach (var series in chartMain.Series)
                            {
                                if (expenses.Any(x => x._nameType == series.Name && x._date.Date == dt.Date))
                                {
                                    var item = expenses.First(x => x._nameType == series.Name && x._date.Date == dt.Date);
                                    chartMain.Series[series.Name].Points.AddXY(date, (double)item._money);
                                }
                                else
                                {
                                    chartMain.Series[series.Name].Points.AddXY(date, 0);
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in chartMain.Series)
            {
                chartMain.Series[series.Name].Points.Clear();
            }
            string sql = "SELECT EXPENSESTYPE.NAMEEXTYPE AS \"_nameType\", EXPENSES.EXDATE AS \"_date\", SUM(EXPENSES.MONEY) AS \"_money\" " +
                         "FROM EXPENSES JOIN EXPENSESTYPE ON EXPENSES.EXTYPEID = EXPENSESTYPE.EXTYPEID " +
                         "WHERE EXPENSES.USERID = :p0 AND EXPENSESTYPE.ISACTIVE = 'Y' AND " +
                         "EXTRACT(MONTH FROM EXPENSES.EXDATE) = :p1 AND " +
                         "EXTRACT(YEAR FROM EXPENSES.EXDATE) = :p2 " +
                         "GROUP BY EXPENSESTYPE.NAMEEXTYPE, EXPENSES.EXDATE " +
                         "ORDER BY EXPENSES.EXDATE";
            var expenses = _qLChiTieu.Database.SqlQuery<ResultDbEXIn>(sql, _userId, cbValue.SelectedValue, DateTime.Now.Year);
            if (expenses.Any() == false)
            {
                DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    StatisticExpenses_Load(sender, e);
                }
            }
            else
            {
                List<DateTime> allDate = new List<DateTime>();
                allDate.AddRange(expenses.Select(x => x._date).Distinct());
                foreach (var dt in allDate)
                {
                    string date = dt.ToString("dd-MM");
                    foreach (var series in chartMain.Series)
                    {
                        if (expenses.Any(x => x._nameType == series.Name && x._date.Date == dt.Date))
                        {
                            var item = expenses.First(x => x._nameType == series.Name && x._date.Date == dt.Date);
                            chartMain.Series[series.Name].Points.AddXY(date, (double)item._money);
                        }
                        else
                        {
                            chartMain.Series[series.Name].Points.AddXY(date, 0);
                        }
                    }
                }
            }
        }

        private void lkIncome_MouseEnter(object sender, EventArgs e)
        {
            lkIncome.LinkColor = Color.Red;
        }

        private void lkIncome_MouseLeave(object sender, EventArgs e)
        {
            lkIncome.LinkColor = Color.Gray;
        }

        private void lkIncome_Click(object sender, EventArgs e)
        {
            pnStatisEx.Controls.Clear();
            StatisticIncome statisticIncome = new StatisticIncome(_userId);
            statisticIncome.TopLevel = false;
            statisticIncome.AutoScroll = true;
            pnStatisEx.Controls.Add(statisticIncome);
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
                StatisticExpenses_Load(sender, e);
                timer.Stop();

            };
            timer.Start();
        }
    }
}
