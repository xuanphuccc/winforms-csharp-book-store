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

namespace BTLCSharp
{
    public partial class fReport : Form
    {
        private Button currentBtn;
        public fReport()
        {
            InitializeComponent();

            // Default active book report
            ActiveButton(btnBooksReport);
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

        private void btnBooksReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnTurnoverReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnTopTurnoverReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
    }
}
