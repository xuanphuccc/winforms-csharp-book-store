using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLCSharp.Controllers;
using BTLCSharp.Model;
using BTLCSharp.RJElements;
using BTLCSharp.View;

namespace BTLCSharp
{
    public partial class fAddBookComponent : Form
    {
        private UIBuild? uiBuild;
        private Panel? parentPnl;
        private Book? book;
        private string photoURL = "";

        public fAddBookComponent()
        {
            InitializeComponent();
        }

        // Add book constructor
        public fAddBookComponent(UIBuild uiBuild, Panel parent)
        {
            InitializeComponent();
            this.uiBuild = uiBuild;
            this.parentPnl = parent;
        }

        // Update book constructor
        public fAddBookComponent(UIBuild uiBuild, Panel parent, Book book)
        {
            InitializeComponent();
            this.uiBuild = uiBuild;
            this.parentPnl = parent;
            this.book = book;
        }

        private void fAddBookComponent_Load(object sender, EventArgs e)
        {
            // Load book types combobox
            cboBookTypes.DataSource = BookTypeDAO.Instance.LoadBookTypeList();
            cboBookTypes.DisplayMember = "id";

            // Load languages combobox
            cboLanguages.DataSource = LanguageDAO.Instance.LoadLanguageList();
            cboLanguages.DisplayMember = "id";

            // Load sectors combobox
            cboSectors.DataSource = SectorDAO.Instance.LoadSectorList();
            cboSectors.DisplayMember = "name";

            // Load authors combobox
            cboAuthors.DataSource = AuthorDAO.Instance.LoadAuthorList();
            cboAuthors.DisplayMember = "name";

            // Load publishing companies combobox
            cboPublishingCpn.DataSource = PublishingCompanyDAO.Instance.LoadPublishingCompanyList();
            cboPublishingCpn.DisplayMember = "name";


            if (book != null)
            {
                txtName.Texts = book.Name;
                txtId.Texts = book.Id;
                txtTotalPages.Texts = book.TotalPages.ToString();
                txtPrice.Texts = book.Price.ToString();
                txtRentalPrice.Texts = book.RentalPrice.ToString();
                txtQuantity.Texts = book.Quantity.ToString();
                ptbBookImage.ImageLocation = book.PhotoURL;
                cboBookTypes.Texts = book.BookTypeId;
                cboLanguages.Texts = book.LanguageId;

                // Load selected Sector
                for (int i = 0; i < cboSectors.Items.Count; i++)
                {
                    if (((Sector)cboSectors.Items[i]).Id == book.SectorId)
                    {
                        cboSectors.SelectedIndex = i;
                    }
                }

                // Load selected Author
                for (int i = 0; i< cboAuthors.Items.Count; i++)
                {
                    if (((Author)cboAuthors.Items[i]).Id == book.AuthorId)
                    {
                        cboAuthors.SelectedIndex = i;
                    }
                }

                // Load selected Publishing Company
                for (int i = 0; i < cboPublishingCpn.Items.Count; i++)
                {
                    if (((PublishingCompany)cboPublishingCpn.Items[i]).Id == book.PublishingCpnId)
                    {
                        cboPublishingCpn.SelectedIndex = i;
                    }
                }

                // Disable book id input
                txtId.Enabled = false;
            } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sectorId = ((Sector)cboSectors.SelectedItem).Id;
            string authorId = ((Author)cboAuthors.SelectedItem).Id;
            string publishingCpnId = ((PublishingCompany)cboPublishingCpn.SelectedItem).Id;

            Book newBook = null;
            if(checkInputs())
            {
                newBook = new Book(
                    txtId.Texts,
                    txtName.Texts,
                    Convert.ToInt32(txtTotalPages.Texts),
                    Convert.ToInt32(txtPrice.Texts),
                    Convert.ToInt32(txtRentalPrice.Texts),
                    Convert.ToInt32(txtQuantity.Texts),
                    photoURL,
                    "",
                    cboBookTypes.Texts,
                    sectorId,
                    authorId,
                    publishingCpnId,
                    cboLanguages.Texts
                );
            }

            if (book != null)
            {
                if(newBook != null)
                {
                    // Update
                    int result = BookDAO.Instance.UpdateBook(newBook);
                    if (result != 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if(newBook != null)
                {
                    // Create
                    int result = BookDAO.Instance.CreateBook(newBook);
                    if (result != 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInputs();
                    }
                }
            }
        }

        private void ptbBookImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                int index = fileName.LastIndexOf("Resourse");
                
                if(index != -1)
                {
                    string newPath = fileName.Substring(index);
                    photoURL = newPath;
                    ptbBookImage.ImageLocation = Application.StartupPath + newPath;

                }

                
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (uiBuild != null && parentPnl != null)
            {
                uiBuild.OpenChildForm(new fBookSearchComponent(uiBuild, parentPnl), parentPnl);
            }
        }

        private bool checkInputs()
        {
            if(
                InputCheck.Instance.EmptyCheck(txtName.Texts, "tên sách") &&
                InputCheck.Instance.EmptyCheck(txtId.Texts, "mã sách") &&
                InputCheck.Instance.EmptyCheck(txtTotalPages.Texts, "số trang") &&
                InputCheck.Instance.EmptyCheck(txtPrice.Texts, "giá sách") &&
                InputCheck.Instance.EmptyCheck(txtRentalPrice.Texts, "giá cho thuê") &&
                InputCheck.Instance.EmptyCheck(txtQuantity.Texts, "số lượng")
            )
            {
                return true;
            }

            return false;
        }

        private void clearInputs()
        {
            txtId.Texts = "";
            txtName.Texts = "";
            txtTotalPages.Texts = "";
            txtPrice.Texts = "";
            txtRentalPrice.Texts = "";
            txtQuantity.Texts = "";
            photoURL = "";
        }

    }
}
