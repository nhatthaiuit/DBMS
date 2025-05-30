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
    public partial class DetailIncome : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _incomeId;
        public DetailIncome(int incomeId)
        {
            InitializeComponent();
            _incomeId = incomeId;
        }

        private void DetailIncome_Load(object sender, EventArgs e)
        {
            _qLChiTieu = new QLChiTieuModel();
            var result = from income in _qLChiTieu.INCOMEs
                         join incomeType in _qLChiTieu.INCOMETYPEs on income.INTYPEID equals incomeType.INTYPEID
                         where income.INCOMEID == _incomeId && incomeType.ISACTIVE == "Y"
                         select new { nameType = incomeType.NAMEINTYPE, money = income.MONEY, date = income.INDATE, note = income.NOTE };
            foreach (var item in result)
            {
                cbInType.Items.Add(item.nameType);
                cbInType.SelectedItem = item.nameType;
                txtMoney.Text = item.money.Value.ToString();
                dateIn.Value = item.date.Value;
                if (item.note != null)
                {

                    txtNote.Text = item.note.ToString();
                }
                else
                {

                    txtNote.Text = "N/A";
                }
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
            if(dateIn.Value.Date > DateTime.Now.Date)
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
                    string dateString = dateIn.Value.ToString("dd-MM-yyyy");
                    decimal money = decimal.Parse(txtMoney.Text);
                    string sql = "UPDATE INCOME SET MONEY = :p0, INDATE = TO_DATE(:p1, 'DD-MM-YYYY'), NOTE = :p2 WHERE INCOMEID = :p3";
                    int rowNum = _qLChiTieu.Database.ExecuteSqlCommand(sql, money, dateString, txtNote.Text, _incomeId);
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

                var entity = _qLChiTieu.INCOMEs.Find(_incomeId);
                if (entity != null)
                {
                    _qLChiTieu.INCOMEs.Remove(entity);
                    _qLChiTieu.SaveChanges();
                    DialogResult dialog = MessageBox.Show("Delete success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }

        private void txtMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }
    }
}
