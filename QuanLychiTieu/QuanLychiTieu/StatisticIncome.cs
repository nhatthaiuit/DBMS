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

namespace QuanLychiTieu
{
    public partial class StatisticIncome : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        private List<ComboItem> _comboItems;
        private List<ComboItem> _comboValues;
        public StatisticIncome(int userId)
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

        private void StatisticIncome_Load(object sender, EventArgs e)
        {
            cbValue.Hide();
            cbFill.SelectedIndexChanged -= cbFill_SelectedIndexChanged;
            cbFill.DataSource = _comboItems;
            cbFill.ValueMember = "Value";
            cbFill.DisplayMember = "Display";
            cbFill.SelectedIndexChanged += cbFill_SelectedIndexChanged;
            List<int> allYear = new List<int>();
            List<string> allType = new List<string>();
            var income = _qLChiTieu.INCOMEs.Join(_qLChiTieu.INCOMETYPEs, x => x.INTYPEID, y => y.INTYPEID, (x, y) => new { x, y })
                            .Where(z => z.x.USERID == _userId && z.y.ISACTIVE == "Y")
                            .GroupBy(z => new { z.y.NAMEINTYPE, z.x.INDATE.Value.Year })
                            .OrderBy(z => z.Key.Year)
                            .Select(z => new
                            {
                                NameExType = z.Key.NAMEINTYPE,
                                Year = z.Key.Year,
                                money = z.Sum(m => m.x.MONEY)
                            })
                            .ToList();
            allYear.AddRange(income.Select(x => x.Year).Distinct());
            allType.AddRange(income.Select(x => x.NameExType));
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
                    if (income.Any(x => x.NameExType == series.Name && x.Year == year))
                    {
                        var item = income.First(x => x.NameExType == series.Name && x.Year == year);
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

        private void lkExpenses_MouseEnter(object sender, EventArgs e)
        {
            lkExpenses.LinkColor = Color.Red;
        }

        private void lkExpenses_MouseLeave(object sender, EventArgs e)
        {
            lkExpenses.LinkColor = Color.Gray;
        }

        private void lkHome_Click(object sender, EventArgs e)
        {
            pnStatisIn.Controls.Clear();
            Statistics statistics = new Statistics(_userId);
            statistics.TopLevel = false;
            statistics.AutoScroll = true;
            pnStatisIn.Controls.Add(statistics);
            statistics.Show();
        }

        private void lkExpenses_Click(object sender, EventArgs e)
        {
            pnStatisIn.Controls.Clear();
            StatisticExpenses statisticExpenses = new StatisticExpenses(_userId);
            statisticExpenses.TopLevel = false;
            statisticExpenses.AutoScroll = true;
            pnStatisIn.Controls.Add(statisticExpenses);
            statisticExpenses.Show();
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
                    string sql = "SELECT INCOMETYPE.NAMEINTYPE AS \"_nameType\", INCOME.INDATE AS \"_date\", SUM(INCOME.MONEY) AS \"_money\" " +
                          "FROM INCOME JOIN INCOMETYPE ON INCOME.INTYPEID = INCOMETYPE.INTYPEID " +
                          "WHERE INCOME.USERID = :p0 AND INCOMETYPE.ISACTIVE = 'Y' AND " +
                          "INCOME.INDATE >= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') AND " +
                          "INCOME.INDATE <= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') + 6 " +
                          "GROUP BY INCOME.INDATE " +
                          "ORDER BY INCOME.INDATE";
                    var income = _qLChiTieu.Database.SqlQuery<ResultDbEXIn>(sql, _userId, DateTime.Now.ToShortDateString());
                    if (income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            StatisticIncome_Load(sender, e);    
                        }
                    }
                    else
                    {
                        List<DateTime> allDate = new List<DateTime>();
                        allDate.AddRange(income.Select(x => x._date).Distinct());
                        foreach (var dt in allDate)
                        {
                            string date = dt.ToString("dd-MM");
                            foreach (var series in chartMain.Series)
                            {
                                if (income.Any(x => x._nameType == series.Name && x._date.Date == dt.Date))
                                {
                                    var item = income.First(x => x._nameType == series.Name && x._date.Date == dt.Date);
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
                    sql = "SELECT INCOMETYPE.NAMEINTYPE AS \"_nameType\", INCOME.INDATE AS \"_date\", SUM(INCOME.MONEY) AS \"_money\" " +
                          "FROM INCOME JOIN INCOMETYPE ON INCOME.INTYPEID = INCOMETYPE.INTYPEID " +
                          "WHERE INCOME.USERID = :p0 AND INCOMETYPE.ISACTIVE = 'Y' AND " +
                          "EXTRACT(YEAR FROM INCOME.INDATE) = :p1 " +
                          "GROUP BY INCOMETYPE.NAMEINTYPE, INCOME.INDATE " +
                          "ORDER BY INCOME.INDATE";
                    income = _qLChiTieu.Database.SqlQuery<ResultDbEXIn>(sql, _userId, DateTime.Now.Year);
                    if (income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            StatisticIncome_Load(sender, e);
                        }
                    }
                    else
                    {
                        List<DateTime> allDate = new List<DateTime>();
                        allDate.AddRange(income.Select(x => x._date).Distinct());
                        foreach (var dt in allDate)
                        {
                            string date = dt.ToString("dd-MM");
                            foreach (var series in chartMain.Series)
                            {
                                if (income.Any(x => x._nameType == series.Name && x._date.Date == dt.Date))
                                {
                                    var item = income.First(x => x._nameType == series.Name && x._date.Date == dt.Date);
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
                    sql = "SELECT INCOMETYPE.NAMEINTYPE AS \"_nameType\", INCOME.INDATE AS \"_date\", SUM(INCOME.MONEY) AS \"_money\" " +
                          "FROM INCOME JOIN INCOMETYPE ON INCOME.INTYPEID = INCOMETYPE.INTYPEID " +
                          "WHERE INCOME.USERID = :p0 AND INCOMETYPE.ISACTIVE = 'Y' AND " +
                          "EXTRACT(MONTH FROM INCOME.INDATE) = :p1 AND " +
                          "EXTRACT(YEAR FROM INCOME.INDATE) = :p2 " +
                          "GROUP BY INCOMETYPE.NAMEINTYPE, INCOME.INDATE " +
                          "ORDER BY INCOME.INDATE";
                    income = _qLChiTieu.Database.SqlQuery<ResultDbEXIn>(sql, _userId, dateFill.Value.Month, dateFill.Value.Year);
                    if (income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            StatisticIncome_Load(sender, e);
                        }
                    }
                    else
                    {
                        List<DateTime> allDate = new List<DateTime>();
                        allDate.AddRange(income.Select(x => x._date).Distinct());
                        foreach (var dt in allDate)
                        {
                            string date = dt.ToString("dd-MM");
                            foreach (var series in chartMain.Series)
                            {
                                if (income.Any(x => x._nameType == series.Name && x._date.Date == dt.Date))
                                {
                                    var item = income.First(x => x._nameType == series.Name && x._date.Date == dt.Date);
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
                    sql = "SELECT INCOMETYPE.NAMEINTYPE AS \"_nameType\", INCOME.INDATE AS \"_date\", SUM(INCOME.MONEY) AS \"_money\" " +
                          "FROM INCOME JOIN INCOMETYPE ON INCOME.INTYPEID = INCOMETYPE.INTYPEID " +
                          "WHERE INCOME.USERID = :p0 AND INCOMETYPE.ISACTIVE = 'Y' AND " +
                          "EXTRACT(YEAR FROM INCOME.INDATE) = :p1 " +
                          "GROUP BY INCOMETYPE.NAMEINTYPE, INCOME.INDATE " +
                          "ORDER BY INCOME.INDATE";
                    income = _qLChiTieu.Database.SqlQuery<ResultDbEXIn>(sql, _userId, dateFill.Value.Year);
                    if (income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            StatisticIncome_Load(sender, e);
                        }
                    }
                    else
                    {
                        List<DateTime> allDate = new List<DateTime>();
                        allDate.AddRange(income.Select(x => x._date).Distinct());
                        foreach (var dt in allDate)
                        {
                            string date = dt.ToString("dd-MM");
                            foreach (var series in chartMain.Series)
                            {
                                if (income.Any(x => x._nameType == series.Name && x._date.Date == dt.Date))
                                {
                                    var item = income.First(x => x._nameType == series.Name && x._date.Date == dt.Date);
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
            string sql = "SELECT INCOMETYPE.NAMEINTYPE AS \"_nameType\", INCOME.INDATE AS \"_date\", SUM(INCOME.MONEY) AS \"_money\" " +
                          "FROM INCOME JOIN INCOMETYPE ON INCOME.INTYPEID = INCOMETYPE.INTYPEID " +
                          "WHERE INCOME.USERID = :p0 AND INCOMETYPE.ISACTIVE = 'Y' AND " +
                          "EXTRACT(MONTH FROM INCOME.INDATE) = :p1 AND " +
                          "EXTRACT(YEAR FROM INCOME.INDATE) = :p2 " +
                          "GROUP BY INCOMETYPE.NAMEINTYPE, INCOME.INDATE " +
                          "ORDER BY INCOME.INDATE";
            var income = _qLChiTieu.Database.SqlQuery<ResultDbEXIn>(sql, _userId, cbValue.SelectedValue, DateTime.Now.Year);
            if (income.Any() == false)
            {
                DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    StatisticIncome_Load(sender, e);
                }
            }
            else
            {
                List<DateTime> allDate = new List<DateTime>();
                allDate.AddRange(income.Select(x => x._date).Distinct());
                foreach (var dt in allDate)
                {
                    string date = dt.ToString("dd-MM");
                    foreach (var series in chartMain.Series)
                    {
                        if (income.Any(x => x._nameType == series.Name && x._date.Date == dt.Date))
                        {
                            var item = income.First(x => x._nameType == series.Name && x._date.Date == dt.Date);
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
                StatisticIncome_Load(sender, e);
                timer.Stop();

            };
            timer.Start();
        }
    }
}
