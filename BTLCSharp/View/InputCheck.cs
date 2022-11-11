using BTLCSharp.RJElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.View
{
    internal class InputCheck
    {
        private static InputCheck? instance;

        public static InputCheck Instance
        {
            get { if (instance == null) instance = new InputCheck(); return instance; }
        }

        private InputCheck() { }

        public bool EmptyCheck(string input = "", string message = "")
        {
            if(input == "")
            {
                MessageBox.Show("Vui lòng nhập " + message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        public string PanelRadioCheck(Panel pnl, string message)
        {
            foreach(RJRadioButton radio in pnl.Controls)
            {
                if(radio.Checked) return radio.Text;
            }

            MessageBox.Show("Vui lòng nhập " + message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return "";
        }
    }
}
