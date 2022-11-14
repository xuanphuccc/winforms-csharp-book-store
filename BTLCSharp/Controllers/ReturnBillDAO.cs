using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class ReturnBillDAO
    {
        private static ReturnBillDAO? instance;

        public static ReturnBillDAO Instance
        {
            get { if(instance == null) instance = new ReturnBillDAO(); return instance; }
        }

        private ReturnBillDAO() { }

        public List<ReturnBill> LoadReturnBillList(string? condition = null)
        {
            List<ReturnBill> returnBillList = new List<ReturnBill>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from TraSach " + condition);
            }
            else
            {
                data = DataProvider.Instance.ReadTable("select * from TraSach");
            }

            foreach (DataRow row in data.Rows)
            {
                ReturnBill returnBill = new ReturnBill(row);
                returnBillList.Add(returnBill);
            }

            return returnBillList;
        }

        public int DeleteReturnBill(string? returnBillId)
        {
            if (returnBillId != null)
            {
                return DataProvider.Instance.ExecuteNonQuery($"delete TraSach where MaTra = N'{returnBillId}'");
            }

            return 0;
        }

        public int CreateReturnBill(ReturnBill returnBill)
        {
            if (returnBill != null)
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "insert TraSach " +
                    $"values (N'{returnBill.Id}', N'{returnBill.RentalBillId}', N'{returnBill.StaffId}', '{returnBill.Date}', {returnBill.TotalMoney})"
                    );
            }

            return 0;
        }

    }
}
