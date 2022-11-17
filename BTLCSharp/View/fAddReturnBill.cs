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
    public partial class fAddReturnBill : Form
    {
        private UIBuild? parentUiBuild;
        private Panel? parentPnl;
        private ReturnBill? returnBill;

        private string isCreatedReturnBill = "";
        private bool isClickCreateBtn = false;

        public fAddReturnBill()
        {
            InitializeComponent();
        }

        public fAddReturnBill(UIBuild parentUiBuild, Panel parentPnl)
        {
            InitializeComponent();
            this.parentUiBuild = parentUiBuild;
            this.parentPnl = parentPnl;
        }

        public fAddReturnBill(UIBuild parentUiBuild, Panel parentPnl, ReturnBill returnBill)
        {
            InitializeComponent();
            this.parentUiBuild = parentUiBuild;
            this.parentPnl = parentPnl;
            this.returnBill = returnBill;
        }

        private void fAddReturnBill_Load(object sender, EventArgs e)
        {
            cboDestruction.DataSource = DestructionDAO.Instance.LoadDestructionList();
            cboDestruction.DisplayMember = "name";

            if(returnBill != null)
            {
                LoadData(returnBill.Id);

                // Fill inputs data
                txtId.Texts = returnBill.Id;
                txtRentalId.Texts = returnBill.RentalBillId;
                dtpReturnDate.Text = returnBill.Date;


                // Disable edit
                btnAddBook.Enabled = false;
                btnCreate.Enabled = false;
                txtId.Enabled = false;
                txtRentalId.Enabled = false;
                dtpReturnDate.Enabled = false;
            }
        }

        private void LoadData(string returnBillId)
        {
            // Fill data
            List<ReturnBillDetail> returnBillDetailList = ReturnBillDetailDAO.Instance.LoadReturnBillDetailList(returnBillId);
            dgvData.DataSource = returnBillDetailList;

            // Change columns name
            dgvData.Columns[0].HeaderText = "Mã phiếu trả";
            dgvData.Columns[0].MinimumWidth = 160;
            dgvData.Columns[1].HeaderText = "Mã sách";
            dgvData.Columns[2].HeaderText = "Tên sách";
            dgvData.Columns[2].MinimumWidth = 320;
            dgvData.Columns[3].HeaderText = "Mã vi phạm";
            dgvData.Columns[4].HeaderText = "Thành tiền";
            dgvData.Columns[4].MinimumWidth = 160;

            int? totalMoney = 0;
            foreach (ReturnBillDetail item in returnBillDetailList)
            {
                if (item.ReturnBillId == returnBillId)
                {
                    totalMoney += item.RentalPrice;
                }
            }
            lbTotalMoney.Text = totalMoney.ToString() + " đ";
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(checkInputs())
            {
                Account? user = AccountDAO.Instance.User;
                string returnDate = dtpReturnDate.Value.Year.ToString() + "/" +
                              dtpReturnDate.Value.Month.ToString() + "/" +
                              dtpReturnDate.Value.Day.ToString();

                if(user != null)
                {
                    // Create Return Bill
                    ReturnBill returnBill = new ReturnBill(
                        txtId.Texts,
                        txtRentalId.Texts,
                        user.StaffId,
                        returnDate,
                        0
                    );

                    if (isCreatedReturnBill == "")
                    {
                        int createdReturnBill = ReturnBillDAO.Instance.CreateReturnBill(returnBill);

                        if (createdReturnBill != 0)
                        {
                            // Change Create Return Bill Status to TRUE
                            isCreatedReturnBill = returnBill.Id;
                        }
                    }

                    if (isCreatedReturnBill != "")
                    {
                        // Create Return Bill Detail
                        Book book = (Book)cboBooksName.SelectedItem;
                        Destruction destruction = (Destruction)cboDestruction.SelectedItem;

                        if (book != null && destruction != null)
                        {
                            ReturnBillDetail returnBillDetail = new ReturnBillDetail(
                                returnBill.Id,
                                book.Id,
                                book.Name,
                                destruction.Id,
                                0
                            );
                            int createdReturnBillDetail = ReturnBillDetailDAO.Instance.CreateReturnBillDetail(returnBillDetail);

                            if (createdReturnBillDetail != 0)
                            {
                                // Successful
                                LoadData(returnBill.Id);
                                LoadCboBookNameData();
                            }
                            else
                            {
                                MessageBox.Show("Thêm sách vào phiếu trả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Không thể tạo phiếu trả sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(checkInputs() && isCreatedReturnBill != "")
            {
                isClickCreateBtn = true;
                MessageBox.Show("Tạo phiếu trả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInputs();
            } else if (isCreatedReturnBill == "") {
                MessageBox.Show("Chưa chọn sách để trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fAddReturnBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isCreatedReturnBill != "" && isClickCreateBtn == false)
            {
                int deletedReturnBillDetail = ReturnBillDetailDAO.Instance.DeleteReturnBillDetail(isCreatedReturnBill);
                if(deletedReturnBillDetail != 0)
                {
                    ReturnBillDAO.Instance.DeleteReturnBill(isCreatedReturnBill);
                    MessageBox.Show("Bạn đã hủy trả sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void txtRentalId_MouseLeave(object sender, EventArgs e)
        {
            LoadCboBookNameData();
        }

        private void txtRentalId_Leave(object sender, EventArgs e)
        {
            LoadCboBookNameData();
        }

        private void LoadCboBookNameData()
        {
            if(txtRentalId.Texts != "")
            {
                List<Book> data = BookDAO.Instance.LoadUnpaidBookList(txtRentalId.Texts);
                cboBooksName.DataSource = data;
                cboBooksName.DisplayMember = "name";

                if(data.Count == 0)
                {
                    cboBooksName.DataSource = null;
                    cboBooksName.Texts = "";
                }
            } else
            {
                cboBooksName.DataSource = null;
                cboBooksName.Texts = "";
            }
        }

        private bool checkInputs()
        {
            if (
                InputCheck.Instance.EmptyCheck(txtId.Texts, "mã phiếu trả") &&
                InputCheck.Instance.EmptyCheck(txtRentalId.Texts, "mã phiếu thuê")
            )
            {
                return true;
            }

            return false;
        }

        private void clearInputs()
        {
            txtId.Texts = "";
            txtRentalId.Texts = "";
            dtpReturnDate.Value = DateTime.Now;
            lbTotalMoney.Text = "0.000 đ";
            dgvData.DataSource = null;
        }

    }
}
