using BTLCSharp.Controllers;
using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLCSharp.View
{
    public partial class fStaffSearchComponent : Form
    {
        private UIBuild? uiBuild;
        private Panel? parentPnl;

        public fStaffSearchComponent()
        {
            InitializeComponent();
        }

        public fStaffSearchComponent(UIBuild uiBuild, Panel parent)
        {
            InitializeComponent();
            this.uiBuild = uiBuild;
            this.parentPnl = parent;
        }

        private void fStaffSearchComponent_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = StaffDAO.Instance.LoadStaffList();

            dgvData.Columns[0].HeaderText = "Mã nhân viên";
            dgvData.Columns[1].HeaderText = "Tên nhân viên";
            dgvData.Columns[2].HeaderText = "Mã ca làm việc";
            dgvData.Columns[3].HeaderText = "Ngày sinh";
            dgvData.Columns[4].HeaderText = "Giới tính";
            dgvData.Columns[5].HeaderText = "Địa chỉ";
            dgvData.Columns[6].HeaderText = "Số điện thoại";
            dgvData.Columns[7].HeaderText = "Lương ($)";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvData.CurrentRow.Index;
            string selectedUserId = dgvData.Rows[currentRowIndex].Cells[0].Value.ToString();
            string selectedUserName = dgvData.Rows[currentRowIndex].Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Bạn có muốn xóa nhân viên: " + selectedUserName + "?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.Yes)
            {
                int count = StaffDAO.Instance.DeleteStaff(selectedUserId);
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // Reload data
            dgvData.DataSource = StaffDAO.Instance.LoadStaffList();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvData.CurrentRow.Index;
            List<Staff> data = StaffDAO.Instance.LoadStaffList();
            Staff staff = data[currentRowIndex];

            if (uiBuild != null && parentPnl != null)
            {
                uiBuild.OpenChildForm(new fAddStaffComponent(uiBuild, parentPnl, staff), parentPnl);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string rule;
            string selectedRule = gboSearch.Texts;
            if (selectedRule == "Tên nhân viên")
            {
                rule = "TenNV";
            }
            else if (selectedRule == "Ca làm việc")
            {
                rule = "MaCa";
            }
            else if (selectedRule == "Giới Tính")
            {
                rule = "GioiTinh";
            }
            else
            {
                rule = "TenNV";
            }

            dgvData.DataSource = StaffDAO.Instance.LoadStaffList("where " + rule + " like N'%" + txtSearch.Texts + "%'");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            // Reload data
            dgvData.DataSource = StaffDAO.Instance.LoadStaffList();
        }
    }
}
