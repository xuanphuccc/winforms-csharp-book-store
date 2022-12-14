using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class AccountDAO
    {
        private Account? user;
        private static AccountDAO? instance;
        public static AccountDAO Instance
        {
            get { if(instance == null) instance = new AccountDAO(); return instance; }
        }

        public Account? User {
            get => user;
        }

        public bool Login(string username, string password)
        {
            DataTable data = DataProvider.Instance.ReadTable($"select * from DangNhap(N'{username}', N'{password}')");

            if(data != null && data.Rows.Count > 0)
            {
                user = new Account(data.Rows[0]);
                return true;
            }

            return false;
        }
    }
}
