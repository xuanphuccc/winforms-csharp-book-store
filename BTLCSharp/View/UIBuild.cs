using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.View
{
    public class UIBuild
    {
        private Form currentChildForm;

        public void OpenChildForm(Form childForm, Panel panel)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void CloseCurrentChildForm()
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }
    }
}
