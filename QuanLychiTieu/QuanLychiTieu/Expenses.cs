using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLychiTieu
{
    public partial class Expenses : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        private List<ComboItem> _comboItem;
        public Expenses(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _comboItem = new List<ComboItem>
            {
                new ComboItem { Value = 1, Display = "<= 5.000.000 VND" },
                new ComboItem { Value = 2, Display = "<= 15.000.000 VND" },
                new ComboItem { Value = 3, Display = "<= 50.000.000 VND" },
                new ComboItem { Value = 4, Display = "> 50.000.000 VND" }
            };
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            formAddType formAddType = new formAddType(_userId);
            formAddType.ShowDialog();
            this.Expenses_Load(sender, e);
        }

        private void picLoad_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            picLoad.Image = Properties.Resources.work_in_progress;
            timer.Tick += (s, ev) =>
            {
                picLoad.Image = Properties.Resources.work_in_progress_static;
                Expenses_Load(sender, e);
                timer.Stop();

            };
            timer.Start();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            _qLChiTieu = new QLChiTieuModel();
            cbExType.SelectedIndexChanged -= cbExType_SelectedIndexChanged;
            cbExType.DataSource = _qLChiTieu.EXPENSESTYPEs.Where(x => x.USERID == _userId && x.ISACTIVE == "Y").ToList();
            cbExType.ValueMember = "EXTYPEID";
            cbExType.DisplayMember = "NAMEEXTYPE";
            cbExType.SelectedIndexChanged += cbExType_SelectedIndexChanged;
            cbMoney.SelectedIndexChanged -= cbMoney_SelectedIndexChanged;
            cbMoney.DataSource = _comboItem;
            cbMoney.ValueMember = "Value";
            cbMoney.DisplayMember = "Display";
            cbMoney.SelectedIndexChanged += cbMoney_SelectedIndexChanged;
            dtGridEx.Rows.Clear();
            var values = from expenses in _qLChiTieu.EXPENSES
                         join expensesType in _qLChiTieu.EXPENSESTYPEs on expenses.EXTYPEID equals expensesType.EXTYPEID
                         where expenses.USERID == _userId && expensesType.ISACTIVE == "Y"
                         orderby expenses.EXPENSESID
                         select new { id = expenses.EXPENSESID, nameType = expensesType.NAMEEXTYPE, money = expenses.MONEY, date = expenses.EXDATE, note = expenses.NOTE };
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = ".", NumberDecimalDigits = 0 };
            foreach (var item in values)
            {
                dtGridEx.Rows.Add(item.id, item.nameType, item.money.Value.ToString("#,##0", nfi), item.date.Value.ToShortDateString(), item.note);
            }
            var totalMoney = (from expenses in _qLChiTieu.EXPENSES
                     where expenses.USERID == _userId && expenses.EXDATE.Value.Year == DateTime.Now.Year
                     select expenses.MONEY).Sum();
            if (totalMoney.HasValue)
            {
                lbTotalMoney.Text = totalMoney.Value.ToString("#,##0", nfi) + " VND";
            }
            else
            {
                lbTotalMoney.Text = "0.00 VND";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddExpenses formAddEx = new AddExpenses(_userId);
            formAddEx.ShowDialog();
            this.Expenses_Load(sender, e);
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Red;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Gray;
        }

        private void dtGridEx_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dtGridEx.Rows[e.RowIndex] != null && dtGridEx.Rows[e.RowIndex].Cells["colId"] != null && dtGridEx.Rows[e.RowIndex].Cells["colId"].Value != null)
                {
                    int id = int.Parse(dtGridEx.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                    DetailExpenses detailExpenses = new DetailExpenses(id);
                    detailExpenses.ShowDialog();
                    Expenses_Load(sender, new EventArgs());
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Invalid selection!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbExType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelect = cbExType.Text.ToString();
            DialogResult dialog = MessageBox.Show("Do you want to search or delete '" + itemSelect + "'? [Yes: Search] or [No: Delete]", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                for (int i = dtGridEx.RowCount - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dtGridEx.Rows[i];
                    if (String.Compare(row.Cells["colExType"].Value.ToString(), itemSelect, true) != 0)
                    {
                        dtGridEx.Rows.Remove(row);
                    }
                }
                if (dtGridEx.RowCount == 0)
                {
                    dialog = MessageBox.Show("There are no valid values", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Expenses_Load(sender, e);
                }
            }
            else
            {
                EXPENSESTYPE eXPENSESTYPE = _qLChiTieu.EXPENSESTYPEs.Find(cbExType.SelectedValue);
                eXPENSESTYPE.ISACTIVE = "N";
                _qLChiTieu.SaveChanges();
                dialog = MessageBox.Show("Delete success!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(dialog == DialogResult.OK)
                {
                    Expenses_Load(sender, e);
                }
            }
            
        }

        private void cbMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = cbMoney.SelectedValue;
            long money = 0;
            switch (selectItem)
            {
                case 1:
                    for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridEx.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money > 5000000)
                        {
                            dtGridEx.Rows.Remove(row);
                        }
                    }
                    break;
                case 2:
                    for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridEx.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money > 15000000)
                        {
                            dtGridEx.Rows.Remove(row);
                        }
                    }
                    break;
                case 3:
                    for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridEx.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money > 50000000)
                        {
                            dtGridEx.Rows.Remove(row);
                        }
                    }
                    break;
                default:
                    for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridEx.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money <= 50000000)
                        {
                            dtGridEx.Rows.Remove(row);
                        }
                    }
                    break;
            }
            if (dtGridEx.RowCount == 1)
            {
                DialogResult dialog = MessageBox.Show("There are no valid values", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Expenses_Load(sender, e);
            }
        }

        private void dateExpense_CloseUp(object sender, EventArgs e)
        {
            string itemSelect = dateExpense.Value.ToString("MM-yyyy");
            for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
            {
                DataGridViewRow row = dtGridEx.Rows[i];
                DateTime colDate = DateTime.ParseExact(row.Cells["colDate"].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                if (String.Compare(colDate.ToString("MM-yyyy"), itemSelect, true) != 0)
                {
                    dtGridEx.Rows.Remove(row);
                }
            }
            if (dtGridEx.RowCount == 1)
            {
                DialogResult dialog = MessageBox.Show("There are no valid values", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Expenses_Load(sender, e);
            }
        }

        private void dtGridEx_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            {
                switch (e.Column.Name)
                {
                    case "colMoney":
                        long a = long.Parse(e.CellValue1.ToString().Replace(".", ""));
                        long b = long.Parse(e.CellValue2.ToString().Replace(".", ""));
                        e.SortResult = a.CompareTo(b);
                        break;

                    case "colDate":
                        DateTime aDate = DateTime.Parse(e.CellValue1.ToString());
                        DateTime bDate = DateTime.Parse(e.CellValue2.ToString());
                        e.SortResult = aDate.CompareTo(bDate);
                        break;

                    case "colExType":
                    case "colNote":
                    default:
                        e.SortResult = String.Compare(e.CellValue1.ToString(), e.CellValue2.ToString());
                        break;
                }

                e.Handled = true;
            }
            //dtGridEx.SortCompare += new DataGridViewSortCompareEventHandler(dtGridEx_SortCompare);
        }
    }
}
