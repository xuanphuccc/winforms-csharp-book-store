using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    internal class Account
    {
        private string? staffId;
        private string? username;
        private string? password;

        public string? StaffId { get => staffId; set => staffId = value; }
        public string? Username { get => username; set => username = value; }
        public string? Password { get => password; set => password = value; }

        public Account(string? staffId, string? username, string? password)
        {
            StaffId = staffId;
            Username = username;
            Password = password;
        }

        public Account(DataRow row)
        {
            StaffId = row["MaNV"].ToString();
            Username = row["TenDangNhap"].ToString();
            Password = row["MatKhau"].ToString();
        }
    }
}
