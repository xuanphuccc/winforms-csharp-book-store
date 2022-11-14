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
    public partial class fSearchRentalBill : Form
    {
        UIBuild? parentUiBuild;
        Panel? parentPnl;

        public fSearchRentalBill()
        {
            InitializeComponent();
        }

        public fSearchRentalBill(UIBuild parentUiBuild, Panel parentPnl)
        {
            InitializeComponent();
            this.parentUiBuild = parentUiBuild;
            this.parentPnl = parentPnl;
        }

        private void fSearchRentalBill_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = RentalBillDAO.Instance.LoadRentalBillList();

            dgvData.Columns[0].HeaderText = "Mã phiếu thuê";
            dgvData.Columns[0].MinimumWidth = 180;
            dgvData.Columns[1].HeaderText = "Mã khách hàng";
            dgvData.Columns[1].MinimumWidth = 180;
            dgvData.Columns[2].HeaderText = "Tên khách hàng";
            dgvData.Columns[2].MinimumWidth = 360;
            dgvData.Columns[3].HeaderText = "Mã nhân viên";
            dgvData.Columns[3].MinimumWidth = 180;
            dgvData.Columns[4].HeaderText = "Ngày thuê";
            dgvData.Columns[4].MinimumWidth = 180;
            dgvData.Columns[5].HeaderText = "Tiền đặt cọc";
            dgvData.Columns[3].MinimumWidth = 180;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvData.CurrentRow.Index;
            string? rentalBillId = dgvData.Rows[selectedIndex].Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có muốn xóa phiếu thuê sách: " + rentalBillId, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                int deleteRentalBillDetail = RentalBillDetailDAO.Instance.DeleteRentalBillDetail(rentalBillId);
                if(deleteRentalBillDetail != 0)
                {
                    int deleteRentalBill = RentalBillDAO.Instance.DeleteRentalBill(rentalBillId);
                    if(deleteRentalBill != 0)
                    {
                        dgvData.DataSource = RentalBillDAO.Instance.LoadRentalBillList();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvData.CurrentRow.Index;
            List<RentalBill> data = RentalBillDAO.Instance.LoadRentalBillList();
            RentalBill rentalBill = data[currentIndex];

            if(parentUiBuild != null && parentPnl != null && rentalBill != null)
            {
                parentUiBuild.OpenChildForm(new fAddRentalBill(parentUiBuild, parentPnl, rentalBill), parentPnl);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int selectedIndex = cboSearch.SelectedIndex;
            string rule = "";
            switch (selectedIndex)
            {
                case 0:
                    rule = "TenKH";
                    break;
                case 1:
                    rule = "MaKH";
                    break;
                case 2:
                    rule = "MaThue";
                    break;
                default:
                    rule = "TenKH";
                    break;
            }

            dgvData.DataSource = RentalBillDAO.Instance.LoadRentalBillList($"where {rule} like N'%{txtSearch.Texts}%'");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = RentalBillDAO.Instance.LoadRentalBillList();
        }
    }
}
