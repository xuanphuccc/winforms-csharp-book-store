using BTLCSharp.View;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace BTLCSharp
{
    public partial class fHome : Form
    {
        UIBuild uiBuild = new UIBuild(); 
        private IconButton currentBtn;
        private Panel borderLeftBtn;
        private Panel bottomBorder;
        private Panel leftBodyBorder;

        public fHome()
        {
            InitializeComponent();

            // Active button border
            borderLeftBtn = new Panel();
            borderLeftBtn.Size = new Size(6, 72);
            pnlMenu.Controls.Add(borderLeftBtn);

            // Active Home page
            ActiveButton(btnHome);

            // title bottom border
            bottomBorder = new Panel();
            bottomBorder.Size = new Size(pnlTitle.Width, 1);
            bottomBorder.Location = new Point(0, pnlTitle.Height - 1);
            bottomBorder.BackColor = Color.FromArgb(220, 220, 220);
            bottomBorder.Dock = DockStyle.Bottom;
            pnlTitle.Controls.Add(bottomBorder);
            bottomBorder.Visible = true;
            bottomBorder.BringToFront();

            // title bottom border
            leftBodyBorder = new Panel();
            leftBodyBorder.Size = new Size(1, pnlBody.Height);
            leftBodyBorder.Location = new Point(0, 0);
            leftBodyBorder.BackColor = Color.FromArgb(220, 220, 220);
            leftBodyBorder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBody.Controls.Add(leftBodyBorder);
            leftBodyBorder.Visible = true;
            leftBodyBorder.BringToFront();

            // Title
            titleIcon.IconSize = 36;

            // Form
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void ActiveButton(object senderBtn)
        {
            if(senderBtn != null)
            {
                DisableActiveButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(231, 232, 254);

                // Border left
                borderLeftBtn.Location = new Point(0, currentBtn.Location.Y);
                borderLeftBtn.BackColor = Color.Orange;
                borderLeftBtn.Visible = true;
                borderLeftBtn.BringToFront();

                // Title
                titleIcon.IconChar = currentBtn.IconChar;
                titleLabel.Text = currentBtn.Text;

            }
        }

        private void DisableActiveButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255,255,255);
            }
        }


        // Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            // Close curent child form
            uiBuild.CloseCurrentChildForm();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            uiBuild.OpenChildForm(new fBookManagement(), pnlMain);
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            uiBuild.OpenChildForm(new fRentalManagement(), pnlMain);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            uiBuild.OpenChildForm(new fClientManagement(), pnlMain);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            uiBuild.OpenChildForm(new fReport(), pnlMain);

        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            uiBuild.OpenChildForm(new fStaffManagement(), pnlMain);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Back to Home
        private void ptbLogo_Click(object sender, EventArgs e)
        {
            DisableActiveButton();
            ActiveButton(btnHome);
            titleIcon.IconChar = IconChar.Home;
            titleLabel.Text = "Trang chủ";
            //borderLeftBtn.Visible = false;

            // Close curent child form
            uiBuild.CloseCurrentChildForm();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else WindowState = FormWindowState.Normal;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result== DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}