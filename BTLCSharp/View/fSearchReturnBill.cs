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
    public partial class fSearchReturnBill : Form
    {
        UIBuild? parentUiBuild;
        Panel? parentPnl;

        public fSearchReturnBill()
        {
            InitializeComponent();
        }

        public fSearchReturnBill(UIBuild parentUiBuild, Panel parentPnl)
        {
            InitializeComponent();
            this.parentUiBuild = parentUiBuild;
            this.parentPnl = parentPnl;
        }

        private void fSearchReturnBill_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = ReturnBillDAO.Instance.LoadReturnBillList();

            dgvData.Columns[0].HeaderText = "Mã phiếu trả";
            dgvData.Columns[1].HeaderText = "Mã phiếu thuê";
            dgvData.Columns[2].HeaderText = "Mã nhân viên";
            dgvData.Columns[3].HeaderText = "Ngày trả";
            dgvData.Columns[4].HeaderText = "Tổng tiền";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvData.CurrentRow.Index;
            string? returnBillId = dgvData.Rows[selectedIndex].Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có muốn xóa phiếu trả sách: " + returnBillId, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                int deleteReturnBillDetail = ReturnBillDetailDAO.Instance.DeleteReturnBillDetail(returnBillId);
                if (deleteReturnBillDetail != 0)
                {
                    int deleteReturnBill = ReturnBillDAO.Instance.DeleteReturnBill(returnBillId);
                    if (deleteReturnBill != 0)
                    {
                        dgvData.DataSource = ReturnBillDAO.Instance.LoadReturnBillList();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int currentIndex = dgvData.CurrentRow.Index;
            List<ReturnBill> data = ReturnBillDAO.Instance.LoadReturnBillList();
            ReturnBill returnBill = data[currentIndex];

            if (parentUiBuild != null && parentPnl != null && returnBill != null)
            {
                parentUiBuild.OpenChildForm(new fAddReturnBill(parentUiBuild, parentPnl, returnBill), parentPnl);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int selectedIndex = cboSearch.SelectedIndex;
            string rule = "";

            switch(selectedIndex)
            {
                case 0:
                    rule = "MaThue";
                    break;
                case 1:
                    rule = "MaTra";
                    break;
                case 2:
                    rule = "MaNV";
                    break;
                default:
                    rule = "MaThue";
                    break;
            }

            dgvData.DataSource = ReturnBillDAO.Instance.LoadReturnBillList($"where {rule} like N'%{txtSearch.Texts}%'");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = ReturnBillDAO.Instance.LoadReturnBillList();
        }
    }
}
