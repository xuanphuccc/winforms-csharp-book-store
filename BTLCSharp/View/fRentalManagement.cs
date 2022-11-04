using BTLCSharp.RJElements;
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
    public partial class fRentalManagement : Form
    {
        private UIBuild uiBuild = new UIBuild();
        private RJButton currentBtn;

        public fRentalManagement()
        {
            InitializeComponent();

            // Default active rental section
            ActiveButton(btnRental);
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
        private void btnRental_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

        }
    }
}
