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
    public partial class fClientSearchComponent : Form
    {
        private UIBuild ?uiBuild;
        private Panel ?parentPnl;

        public fClientSearchComponent()
        {
            InitializeComponent();
        }

        public fClientSearchComponent(UIBuild uiBuild ,Panel parent)
        {
            InitializeComponent();
            this.uiBuild = uiBuild;
            this.parentPnl = parent;
        }

        private void fSearchComponent_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = ClientDAO.Instance.LoadClientList();

            dgvData.Columns[0].HeaderText = "Mã khách hàng";
            dgvData.Columns[1].HeaderText = "Tên khách hàng";
            dgvData.Columns[2].HeaderText = "Ngày sinh";
            dgvData.Columns[3].HeaderText = "Giới tính";
            dgvData.Columns[4].HeaderText = "Địa chỉ";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvData.CurrentRow.Index;
            string selectedUserId = dgvData.Rows[currentRowIndex].Cells[0].Value.ToString();
            string selectedUserName = dgvData.Rows[currentRowIndex].Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Bạn có muốn xóa khách hàng: " + selectedUserName + "?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.Yes)
            {
                int count = ClientDAO.Instance.DeleteClient(selectedUserId);
                if(count > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // Reload data
            dgvData.DataSource = ClientDAO.Instance.LoadClientList();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvData.CurrentRow.Index;
            List<Client> data = ClientDAO.Instance.LoadClientList();
            Client client = data[currentRowIndex];

            if(uiBuild != null && parentPnl != null)
            {
                uiBuild.OpenChildForm(new fAddClientComponent(uiBuild, parentPnl, client), parentPnl);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string rule;
            string selectedRule = gboSearch.Texts;
            if(selectedRule == "Tên khách hàng")
            {
                rule = "TenKH";
            } else if (selectedRule == "Mã khách hàng")
            {
                rule = "MaKH";
            } else if (selectedRule == "Giới Tính")
            {
                rule = "GioiTinh";
            } else
            {
                rule = "TenKH";
            }

            dgvData.DataSource = ClientDAO.Instance.LoadClientList($"where {rule} like N'%{txtSearch.Texts}%'");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = ClientDAO.Instance.LoadClientList();
        }
    }
}
