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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 employeeForm = new Form2(); // Gọi Form2 để thêm nhân viên
            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                // Thêm thông tin từ Form2 vào DataGridView
                dgvEmployees.Rows.Add(employeeForm.EmployeeID, employeeForm.EmployeeName, employeeForm.Salary);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null) // Kiểm tra dòng hiện tại
            {
                DataGridViewRow row = dgvEmployees.CurrentRow; // Lấy dòng hiện tại
                Form2 employeeForm = new Form2
                {
                    EmployeeID = row.Cells[0].Value.ToString(),
                    EmployeeName = row.Cells[1].Value.ToString(),
                    Salary = row.Cells[2].Value.ToString()
                };

                if (employeeForm.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật lại thông tin trên dòng hiện tại
                    row.Cells[0].Value = employeeForm.EmployeeID;
                    row.Cells[1].Value = employeeForm.EmployeeName;
                    row.Cells[2].Value = employeeForm.Salary;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                // Xóa dòng được chọn
                dgvEmployees.Rows.Remove(dgvEmployees.CurrentRow);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
