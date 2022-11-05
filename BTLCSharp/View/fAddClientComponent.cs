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
    public partial class fAddClientComponent : Form
    {
        private UIBuild? uiBuild;
        private Panel? parentPnl;
        Client ?client;
        public Button ?btnsearchClient;

        public Button? BtnsearchClient { get => btnsearchClient; set => btnsearchClient = value; }

        public fAddClientComponent()
        {
            InitializeComponent();
        }

        // Add client
        public fAddClientComponent(UIBuild uiBuild, Panel parent)
        {
            InitializeComponent();
            this.uiBuild = uiBuild;
            this.parentPnl = parent;
        }

        // Client detail
        public fAddClientComponent(UIBuild uiBuild, Panel parent, Client client)
        {
            InitializeComponent();
            this.uiBuild = uiBuild;
            this.parentPnl = parent;
            this.client = client;
        }

        private void fAddClientComponent_Load(object sender, EventArgs e)
        {
            if(client != null)
            {
                txtId.Texts = client.Id;
                txtName.Texts = client.Name;
                dtpDateOfBirth.Text = client.DateOfBirth;
                if (client.Gender == "Nam")
                {
                    rdoMale.Checked = true;
                }
                else rdoFemale.Checked = true;
                txtLocation.Texts = client.Location;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(uiBuild != null && parentPnl != null)
            {
                uiBuild.OpenChildForm(new fClientSearchComponent(uiBuild, parentPnl), parentPnl);
            }
        }
    }
}
