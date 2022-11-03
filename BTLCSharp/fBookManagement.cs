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
        public RJButton currentBtn;
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
                currentBtn.BackColor = Color.FromArgb(50, 107, 255);
                currentBtn.ForeColor = Color.White;
            }
        }

        private void DisableActiveButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(231, 232, 254);
                currentBtn.ForeColor = Color.Black;
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
    }
}
