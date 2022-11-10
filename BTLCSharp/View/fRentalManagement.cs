using BTLCSharp.RJElements;
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

namespace BTLCSharp.View
{
    public partial class fRentalManagement : Form
    {
        private UIBuild uiBuild = new UIBuild();
        private RJButton currentBtn;
        private IconButton currentSubBtn;

        public fRentalManagement()
        {
            InitializeComponent();

            // Default active rental section
            ActiveButton(btnRental);
            ActiveSubButton(btnAdd);
            uiBuild.OpenChildForm(new fAddRentalBill(), pnlBody);
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

        private void ActiveSubButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableActiveSubButton();
                currentSubBtn = (IconButton)senderBtn;
                currentSubBtn.ForeColor = Color.FromArgb(117, 52, 255);
                currentSubBtn.IconColor = Color.FromArgb(117, 52, 255);
            }
        }

        private void DisableActiveSubButton()
        {
            if (currentSubBtn != null)
            {
                currentSubBtn.ForeColor = Color.DimGray;
                currentSubBtn.IconColor = Color.DimGray;
            }
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            ActiveSubButton(btnAdd);
            uiBuild.OpenChildForm(new fAddRentalBill(), pnlBody);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            ActiveSubButton(btnAdd);
            uiBuild.OpenChildForm(new fAddReturnBill(), pnlBody);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ActiveSubButton(sender);

            if (currentBtn.Text == "Phiếu thuê")
            {
                uiBuild.OpenChildForm(new fSearchRentalBill(), pnlBody);
            } else if(currentBtn.Text == "Phiếu trả")
            {
                uiBuild.OpenChildForm(new fSearchReturnBill(), pnlBody);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ActiveSubButton(sender);

            if(currentBtn.Text == "Phiếu thuê")
            {
                uiBuild.OpenChildForm(new fAddRentalBill(), pnlBody);
            } else if(currentBtn.Text == "Phiếu trả")
            {
                uiBuild.OpenChildForm(new fAddReturnBill(), pnlBody);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
