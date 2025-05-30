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
    public partial class formAddIncomeType : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        public formAddIncomeType(int userId)
        {
            InitializeComponent();
            _qLChiTieu = new QLChiTieuModel();
            _userId = userId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            INCOMETYPE iNCOMETYPE = new INCOMETYPE();
            string message = "";
            var exType = _qLChiTieu.INCOMETYPEs.Where(x => (x.NAMEINTYPE.Replace(" ", "").ToLower() == txtNameType.Text.Replace(" ", "").ToLower()) && x.USERID == _userId).Any();
            if (exType == true)
            {
                if (_qLChiTieu.INCOMETYPEs.Where(x => x.USERID == _userId && (x.NAMEINTYPE.Replace(" ", "").ToLower() == txtNameType.Text.Replace(" ", "").ToLower()) && x.ISACTIVE == "N").Any())
                {
                    DialogResult dialog = MessageBox.Show("You’ve added this before, do you want to restore it?", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        int id = (int)_qLChiTieu.INCOMETYPEs.Where(x => x.USERID == _userId && (x.NAMEINTYPE.Replace(" ", "").ToLower() == txtNameType.Text.Replace(" ", "").ToLower()) && x.ISACTIVE == "N").First().INTYPEID;
                        iNCOMETYPE = _qLChiTieu.INCOMETYPEs.Find(id);
                        iNCOMETYPE.ISACTIVE = "Y";
                        _qLChiTieu.SaveChanges();
                        dialog = MessageBox.Show("Successfully restored!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        message = "check";
                    }
                }
                else
                {
                    message += "Name income type is exist!\n";
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtNameType.Text))
                {
                    message += "Name income type cannot be blank!!\n";
                }
                else
                {
                    iNCOMETYPE.USERID = _userId;
                    iNCOMETYPE.NAMEINTYPE = txtNameType.Text;
                    iNCOMETYPE.ISACTIVE = "Y";
                }
            }
            if (String.IsNullOrEmpty(message) == false && String.Compare(message, "check", true) != 0)
            {
                DialogResult dialog = MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.Compare(message, "check", true) != 0)
            {
                _qLChiTieu.INCOMETYPEs.Add(iNCOMETYPE);
                _qLChiTieu.SaveChanges();
                DialogResult dialog = MessageBox.Show("Add success!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNameType_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }
    }
}
