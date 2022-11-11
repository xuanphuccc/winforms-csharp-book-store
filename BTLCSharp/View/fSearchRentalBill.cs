using BTLCSharp.Controllers;
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
        public fSearchRentalBill()
        {
            InitializeComponent();
        }

        private void fSearchRentalBill_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = RentalBillDAO.Instance.LoadRentalBillList();

            dgvData.Columns[0].HeaderText = "Mã phiếu thuê";
            dgvData.Columns[1].HeaderText = "Mã khách hàng";
            dgvData.Columns[2].HeaderText = "Mã nhân viên";
            dgvData.Columns[3].HeaderText = "Ngày thuê";
            dgvData.Columns[4].HeaderText = "Tiền đặt cọc";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }
    }
}
