using BTLCSharp.RJElements;
using BTLCSharp.View;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLCSharp
{
    public partial class fBookManagement : Form
    {
        private UIBuild uiBuild = new UIBuild();
        private RJButton currentBtn;
        public fBookManagement()
        {
            InitializeComponent();

            // Default active search books
            ActiveButton(btnSearchCategory);
        }

        private void ActiveButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableActiveButton();
                currentBtn = (RJButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(231, 232, 254);
            }
        }

        private void DisableActiveButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            uiBuild.OpenChildForm(new fAddBookComponent(), pnlSearchBody);
        }
    }
}
