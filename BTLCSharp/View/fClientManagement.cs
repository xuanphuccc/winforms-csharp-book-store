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
    public partial class fClientManagement : Form
    {
        private UIBuild uiBuild = new UIBuild();
        private RJButton currentBtn;

        public fClientManagement()
        {
            InitializeComponent();

            // Default active search client
            ActiveButton(btnSearchClient);
            uiBuild.OpenChildForm(new fSearchComponent(), pnlSearchBody);
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

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            uiBuild.OpenChildForm(new fSearchComponent(), pnlSearchBody);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            uiBuild.OpenChildForm(new fAddClientComponent(), pnlSearchBody);
        }
    }
}
