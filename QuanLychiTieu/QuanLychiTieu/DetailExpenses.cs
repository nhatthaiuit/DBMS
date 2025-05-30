using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLychiTieu
{
    public partial class DetailExpenses : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _expensesId;
        public DetailExpenses(int expensesId)
        {
            InitializeComponent();
            _expensesId = expensesId;
        }

        private void DetailExpenses_Load(object sender, EventArgs e)
        {
            _qLChiTieu = new QLChiTieuModel();
            var result = from expense in _qLChiTieu.EXPENSES
                         join expensesType in _qLChiTieu.EXPENSESTYPEs on expense.EXTYPEID equals expensesType.EXTYPEID
                         where expense.EXPENSESID == _expensesId && expensesType.ISACTIVE == "Y"
                         select new { nameType = expensesType.NAMEEXTYPE, money = expense.MONEY, date = expense.EXDATE, note = expense.NOTE };
            foreach (var item in result)
            {
                cbExType.Items.Add(item.nameType);
                cbExType.SelectedItem = item.nameType;
                txtMoney.Text = item.money.Value.ToString();
                dateEx.Value = item.date.Value;
                if(item.note != null)
                {

                    txtNote.Text = item.note.ToString();
                }
                else
                {

                    txtNote.Text = "N/A";
                }
            }
        }

        private void txtMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = "";
            Regex regex = new Regex(@"^[1-9][0-9]*$");
            if (String.IsNullOrEmpty(txtMoney.Text))
            {
                message += "Money cannot be blank!\n";
            }
            else
            {
                if (!regex.IsMatch(txtMoney.Text))
                {
                    message += "Only enter numbers!\n";
                }
            }
            if (dateEx.Value.Date > DateTime.Now.Date)
            {
                message += "The selected time is invalid!\n";
            }
            if (String.IsNullOrEmpty(txtNote.Text))
            {
                txtNote.Text = "N/A";
            }
            if (!String.IsNullOrEmpty(message))
            {
                DialogResult dialog = MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string dateString = dateEx.Value.ToString("dd-MM-yyyy");
                    decimal money = decimal.Parse(txtMoney.Text);
                    string sql = "UPDATE EXPENSES SET MONEY = :p0, EXDATE = TO_DATE(:p1, 'DD-MM-YYYY'), NOTE = :p2 WHERE EXPENSESID = :p3";
                    int rowNum = _qLChiTieu.Database.ExecuteSqlCommand(sql, money, dateString, txtNote.Text, _expensesId);
                    if (rowNum > 0)
                    {
                        DialogResult dialog = MessageBox.Show("Update success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Update fail!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    DialogResult dialog = MessageBox.Show(ex.ToString(), "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this row??",
                                                "Confirm deletion!!",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                var entity = _qLChiTieu.EXPENSES.Find(_expensesId);
                if (entity != null)
                {
                    _qLChiTieu.EXPENSES.Remove(entity);
                    _qLChiTieu.SaveChanges();
                    DialogResult dialog = MessageBox.Show("Delete success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }
    }
}
