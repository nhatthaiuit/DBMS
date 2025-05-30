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
    public partial class AddExpenses : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        public AddExpenses(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            if(cbExType.SelectedValue == null)
            {
                message += "No expense type selected!\n";
            }
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
            if(dateEx.Value.Date > DateTime.Now.Date)
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
                string dateString = dateEx.Value.ToString("dd-MM-yyyy");
                decimal extypeId = (decimal)cbExType.SelectedValue;
                decimal money = decimal.Parse(txtMoney.Text);
                string sql = "INSERT INTO EXPENSES(USERID, EXTYPEID, MONEY, EXDATE, NOTE) VALUES (:p0, :p1, :p2,TO_DATE(:p3, 'DD-MM-YYYY'), :p4)";
                int rowNum = _qLChiTieu.Database.ExecuteSqlCommand(sql, _userId, extypeId, money, dateString, txtNote.Text);
                if(rowNum > 0)
                {
                    DialogResult dialog = MessageBox.Show("Add success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Add fail!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddExpenses_Load(object sender, EventArgs e)
        {
            _qLChiTieu = new QLChiTieuModel();
            cbExType.DataSource = _qLChiTieu.EXPENSESTYPEs.Where(x => x.USERID == _userId && x.ISACTIVE == "Y").ToList();
            cbExType.ValueMember = "EXTYPEID";
            cbExType.DisplayMember = "NAMEEXTYPE";
        }

        private void txtMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }
    }
}
