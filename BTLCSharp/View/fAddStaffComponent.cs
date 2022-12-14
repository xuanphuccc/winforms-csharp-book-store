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
    public partial class fAddStaffComponent : Form
    {
        private UIBuild? uiBuild;
        private Panel? parentPnl;
        Staff? staff;

        public fAddStaffComponent()
        {
            InitializeComponent();
        }

        // Add staff
        public fAddStaffComponent(UIBuild uiBuild, Panel parent)
        {
            InitializeComponent();
            this.uiBuild = uiBuild;
            this.parentPnl = parent;
        }

        // Staff detail
        public fAddStaffComponent(UIBuild uiBuild, Panel parent, Staff staff)
        {
            InitializeComponent();
            this.uiBuild = uiBuild;
            this.parentPnl = parent;
            this.staff = staff;
        }

        private void fAddStaffComponent_Load(object sender, EventArgs e)
        {
            // Show Shift combobox list
            List<Shift> shiftList = ShiftDAO.Instance.LoadShiftList();
            cboShift.DataSource = shiftList;
            cboShift.DisplayMember = "Id";

            if(staff != null)
            {
                txtId.Texts = staff.Id;
                txtName.Texts = staff.Name;
                dtpDateOfBirth.Text = staff.DateOfBirth;
                if (staff.Gender == "Nam")
                {
                    rdoMale.Checked = true;
                }
                else rdoFemale.Checked = true;
                txtLocation.Texts = staff.Location;
                txtPhoneNumber.Texts = staff.PhoneNumber;
                cboShift.Texts = staff.ShiftId;
                txtSalary.Texts = staff.Salary;

                // Disable staff id input
                txtId.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = "";
            foreach (RadioButton item in pnlGender.Controls)
            {
                if (item.Checked) gender = item.Text;
            }

            string dateOfBirth = dtpDateOfBirth.Value.Year.ToString() + "/" +
                              dtpDateOfBirth.Value.Month.ToString() + "/" +
                              dtpDateOfBirth.Value.Day.ToString();

            Staff staffData = null;
            if(checkInputs())
            {
                staffData = new Staff(
                    txtId.Texts,
                    txtName.Texts,
                    cboShift.Texts,
                    dateOfBirth,
                    gender,
                    txtLocation.Texts,
                    txtPhoneNumber.Texts,
                    txtSalary.Texts
                );
            }

            if (staff != null)
            {
                // Update client
                if (staffData != null)
                {
                    int status = StaffDAO.Instance.UpdateStaff(staffData);

                    if (status > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                // Create client
                if (staffData != null)
                {
                    int status = StaffDAO.Instance.CreateStaff(staffData);

                    if (status > 0)
                    {
                        ClearInputs();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (uiBuild != null && parentPnl != null)
            {
                uiBuild.OpenChildForm(new fStaffSearchComponent(uiBuild, parentPnl), parentPnl);
            }
        }

        private bool checkInputs()
        {
            if(
                InputCheck.Instance.EmptyCheck(txtId.Texts, "mã nhân viên") &&
                InputCheck.Instance.EmptyCheck(txtName.Texts, "tên nhân viên") &&
                InputCheck.Instance.PanelRadioCheck(pnlGender, "giới tính") != "" &&
                InputCheck.Instance.EmptyCheck(txtLocation.Texts, "địa chỉ") &&
                InputCheck.Instance.EmptyCheck(txtPhoneNumber.Texts, "số điện thoại") &&
                InputCheck.Instance.EmptyCheck(txtSalary.Texts, "lương tháng")
            )
            {
                return true;
            }

            return false;
        }

        private void ClearInputs()
        {
            txtId.Texts = "";
            txtName.Texts = "";
            foreach(RadioButton item in pnlGender.Controls)
            {
                if (item.Checked) item.Checked = false;
            }
            txtLocation.Texts = "";
            txtPhoneNumber.Texts = "";
            cboShift.Texts = "";
            txtSalary.Texts = "";
        }
    }
}
