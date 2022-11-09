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
    public partial class fAddClientComponent : Form
    {
        private UIBuild? uiBuild;
        private Panel? parentPnl;
        Client ?client;

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

                // Disable client id input
                txtId.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = "";
            foreach(RadioButton item in pnlGender.Controls)
            {
                if(item.Checked) gender = item.Text;
            }
            Client clientData = new Client(txtId.Texts, txtName.Texts, dtpDateOfBirth.Text, gender, txtLocation.Texts);

            if(client != null)
            {
                // Update client
                if (clientData != null)
                {
                    int status = ClientDAO.Instance.UpdateClient(clientData);

                    if (status > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                    }
                    else MessageBox.Show("Cập nhật thất bại", "Thông báo");

                }

            } else
            {
                // Create client
                if(clientData != null)
                {
                    int status = ClientDAO.Instance.CreateClient(clientData);

                    if(status > 0)
                    {
                        ClearInputs();
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    } else MessageBox.Show("Thêm thất bại", "Thông báo");
                    
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(uiBuild != null && parentPnl != null)
            {
                uiBuild.OpenChildForm(new fClientSearchComponent(uiBuild, parentPnl), parentPnl);
            }
        }

        private void ClearInputs()
        {
            txtId.Texts = "";
            txtName.Texts = "";
            foreach (RadioButton item in pnlGender.Controls)
            {
                if (item.Checked) item.Checked = false;
            }
            txtLocation.Texts = "";
        }
    }
}
