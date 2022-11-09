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
    public partial class fBookSearchComponent : Form
    {
        private UIBuild? uiBuild;
        private Panel? parentPnl;

        public fBookSearchComponent()
        {
            InitializeComponent();
        }

        public fBookSearchComponent(UIBuild uiBuild, Panel parent)
        {
            InitializeComponent();
            this.uiBuild = uiBuild;
            this.parentPnl = parent;
        }

        private void fBookSearchComponent_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = BookDAO.Instance.LoadBooksList();

            dgvData.Columns[0].HeaderText = "Mã sách";
            dgvData.Columns[1].HeaderText = "Tên sách";
            dgvData.Columns[2].HeaderText = "Số trang";
            dgvData.Columns[3].HeaderText = "Giá sách";
            dgvData.Columns[4].HeaderText = "Giá cho thuê";
            dgvData.Columns[5].HeaderText = "Số lượng";
            dgvData.Columns[6].HeaderText = "Hình ảnh";
            dgvData.Columns[7].HeaderText = "Ghi chú";

            dgvData.Columns[8].HeaderText = "Mã loại sách";
            dgvData.Columns[9].HeaderText = "Mã lĩnh vực";
            dgvData.Columns[10].HeaderText = "Mã tác giả";
            dgvData.Columns[11].HeaderText = "Mã NXB";
            dgvData.Columns[12].HeaderText = "Mã ngôn ngữ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvData.CurrentRow.Index;
            string selectedBookId = dgvData.Rows[currentRowIndex].Cells[0].Value.ToString();
            string selectedBookName = dgvData.Rows[currentRowIndex].Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Bạn có muốn xóa sách: " + selectedBookName + "?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (result == DialogResult.Yes)
            {
                int count = BookDAO.Instance.DeleteBook(selectedBookId);
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // Reload data
            dgvData.DataSource = BookDAO.Instance.LoadBooksList();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvData.CurrentRow.Index;
            List<Book> data = BookDAO.Instance.LoadBooksList();
            Book book = data[currentRowIndex];

            if(uiBuild != null && parentPnl != null)
            {
                uiBuild.OpenChildForm(new fAddBookComponent(uiBuild, parentPnl, book), parentPnl);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string rule;
            string selectedRule = cboSearch.Texts;

            switch (selectedRule)
            {
                case "Tên sách":
                    rule = "TenSach";
                    break;
                case "Lĩnh vực":
                    rule = "MaLV";
                    break;
                case "Tác giả":
                    rule = "MaTG";
                    break;
                case "NXB":
                    rule = "MaNXB";
                    break;
                default:
                    rule = "TenSach";
                    break;
            }

            dgvData.DataSource = BookDAO.Instance.LoadBooksList($"where {rule} like N'%{txtSearch.Texts}%'");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = BookDAO.Instance.LoadBooksList();
        }
    }
}
