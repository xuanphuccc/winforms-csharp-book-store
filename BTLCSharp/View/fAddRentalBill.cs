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
    public partial class fAddRentalBill : Form
    {
        UIBuild? parentUiBuild;
        Panel? parentPnl;
        RentalBill? rentalBill;

        public fAddRentalBill()
        {
            InitializeComponent();
        }

        public fAddRentalBill(UIBuild parentUiBuild, Panel parentPnl)
        {
            InitializeComponent();
            this.parentUiBuild = parentUiBuild;
            this.parentPnl = parentPnl;
        }

        public fAddRentalBill(UIBuild parentUiBuild, Panel parentPnl, RentalBill rentalBill)
        {
            InitializeComponent();
            this.parentUiBuild = parentUiBuild;
            this.parentPnl = parentPnl;
            this.rentalBill = rentalBill;
        }

        private void fAddRentalBill_Load(object sender, EventArgs e)
        {
            // Load combo box data
            cboBooksName.DataSource = BookDAO.Instance.LoadBooksList("where SoLuong > 0");
            cboBooksName.DisplayMember = "name";

            cboBookStatus.DataSource = BookStatusDAO.Instance.LoadBookStatusList();
            cboBookStatus.DisplayMember = "name";

            if (rentalBill != null)
            {
                // Fill data
                dgvData.DataSource = RentalBillDetailDAO.Instance.LoadRentalBillDetailList(rentalBill.Id);

                // Change columns name
                dgvData.Columns[0].HeaderText = "Mã phiếu thuê";
                dgvData.Columns[0].MinimumWidth = 160;
                dgvData.Columns[1].HeaderText = "Mã sách";
                dgvData.Columns[2].HeaderText = "Tên sách";
                dgvData.Columns[2].MinimumWidth = 320;
                dgvData.Columns[3].HeaderText = "Mã tình trạng";
                dgvData.Columns[3].MinimumWidth = 160;
                dgvData.Columns[4].HeaderText = "Đã trả";

                // Fill input data
                txtId.Texts = rentalBill.Id;
                txtClientId.Texts = rentalBill.ClientId;
                dtpRentalDate.Text = rentalBill.Date;

                // Disable edit
                btnAddBook.Enabled = false;
                btnCreate.Enabled = false;
                txtId.Enabled = false;
                txtClientId.Enabled = false;
                dtpRentalDate.Enabled = false;
            }
        }

        List<RentalBillDetail> rentalBillDetailList = new List<RentalBillDetail>();
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = (Book)cboBooksName.SelectedItem;
            BookStatus bookStatus = (BookStatus)cboBookStatus.SelectedItem;

            RentalBillDetail rentalBook = new RentalBillDetail(
                txtId.Texts,
                book.Id,
                book.Name,
                bookStatus.Id,
                0
            );

            // Check duplicate book
            bool isDuplicate = false;
            foreach(RentalBillDetail item in rentalBillDetailList)
            {
                if(item.BookId == rentalBook.BookId)
                {
                    isDuplicate = true;
                }
            }

            // If not duplicate then add to the list
            if(isDuplicate == false)
            {
                rentalBillDetailList.Add(rentalBook);

                dgvData.DataSource = null; // Reset data
                dgvData.DataSource = rentalBillDetailList;

                // Change columns name
                dgvData.Columns[0].HeaderText = "Mã phiếu thuê";
                dgvData.Columns[0].MinimumWidth = 160;
                dgvData.Columns[1].HeaderText = "Mã sách";
                dgvData.Columns[2].HeaderText = "Tên sách";
                dgvData.Columns[2].MinimumWidth = 320;
                dgvData.Columns[3].HeaderText = "Mã tình trạng";
                dgvData.Columns[3].MinimumWidth = 160;
                dgvData.Columns[4].HeaderText = "Đã trả";
            } else
            {
                MessageBox.Show("Không thể thêm hai cuốn sách cùng loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(checkInputs())
            {
                string rentalDate = dtpRentalDate.Value.Year.ToString() + "/" +
                              dtpRentalDate.Value.Month.ToString() + "/" +
                              dtpRentalDate.Value.Day.ToString();

                RentalBill rentalBill = new RentalBill(
                    txtId.Texts,
                    txtClientId.Texts,
                    "NV01",
                    rentalDate,
                    "100000"
                );

                int rentalBillResult = RentalBillDAO.Instance.CreateRentalBill(rentalBill);
                if(rentalBillResult != 0)
                {
                    int rentalBillDetailResult = 1;
                    foreach(RentalBillDetail item in rentalBillDetailList)
                    {
                        item.RentalBillId = rentalBill.Id;
                        if(RentalBillDetailDAO.Instance.CreateRentalBillDetail(item) == 0)
                        {
                            rentalBillDetailResult = 0;
                            break;
                        }
                    }
                    
                    if(rentalBillDetailResult != 0)
                    {
                        clearInputs();
                        cboBooksName.DataSource = BookDAO.Instance.LoadBooksList("where SoLuong > 0"); // Reload
                        dgvData.DataSource = null;
                        MessageBox.Show("Tạo phiếu thuê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Tạo phiếu thuê thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private bool checkBookListLength()
        {
            if(rentalBillDetailList.Count < 1)
            {
                MessageBox.Show("Bạn chưa chọn sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool checkInputs()
        {
            if(
                InputCheck.Instance.EmptyCheck(txtId.Texts, "mã phiếu thuê") &&
                InputCheck.Instance.EmptyCheck(txtClientId.Texts, "mã khách hàng") &&
                checkBookListLength()
            )
            {
                return true;
            }

            return false;
        }

        private void clearInputs()
        {
            txtId.Texts = "";
            txtClientId.Texts = "";
        }
    }
}
