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
            cboSectors.DisplayMember = "id";

            // Load authors combobox
            cboAuthors.DataSource = AuthorDAO.Instance.LoadAuthorList();
            cboAuthors.DisplayMember = "id";

            // Load publishing companies combobox
            cboPublishingCpn.DataSource = PublishingCompanyDAO.Instance.LoadPublishingCompanyList();
            cboPublishingCpn.DisplayMember = "id";


            if (book != null)
            {
                txtName.Texts = book.Name;
                txtId.Texts = book.Id;
                txtTotalPages.Texts = book.TotalPages.ToString();
                txtPrice.Texts = book.Price.ToString();
                txtRentalPrice.Texts = book.RentalPrice.ToString();
                txtQuantity.Texts = book.Quantity.ToString();
                cboBookTypes.Texts = book.BookTypeId;
                cboLanguages.Texts = book.LanguageId;
                cboSectors.Texts = book.SectorId;
                cboAuthors.Texts = book.AuthorId;
                cboPublishingCpn.Texts = book.PublishingCpnId;


                // Disable book id input
                txtId.Enabled = false;
            } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (uiBuild != null && parentPnl != null)
            {
                uiBuild.OpenChildForm(new fBookSearchComponent(uiBuild, parentPnl), parentPnl);
            }
        }

        private void clearInputs()
        {

        }
    }
}
