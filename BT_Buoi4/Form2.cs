using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi4
{
    public partial class Form2 : Form
    {
        public string EmployeeID { get => txtMSNV.Text; set => txtMSNV.Text = value; }
        public string EmployeeName { get => txtHoTen.Text; set => txtHoTen.Text = value; }
        public string Salary { get => txtLuong.Text; set => txtLuong.Text = value; }

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (ValidateInput()) 
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMSNV.Text))
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!decimal.TryParse(txtLuong.Text, out _))
            {
                MessageBox.Show("Lương phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
