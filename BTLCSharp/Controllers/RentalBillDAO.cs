using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class RentalBillDAO
    {
        private static RentalBillDAO? instance;

        public static RentalBillDAO Instance
        {
            get { if(instance == null) instance = new RentalBillDAO(); return instance; }
        }

        private RentalBillDAO() { }

        public List<RentalBill> LoadRentalBillList(string? condition = null)
        {
            List<RentalBill> rentalBillList = new List<RentalBill>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from LoadBookRental() " + condition);
            }
            else
            {
                data = DataProvider.Instance.ReadTable("select * from LoadBookRental()");
            }

            foreach (DataRow row in data.Rows)
            {
                RentalBill rentalBill = new RentalBill(row);
                rentalBillList.Add(rentalBill);
            }

            return rentalBillList;
        }

        public int DeleteRentalBill(string? rentalBillId)
        {
            if (rentalBillId != null)
            {
                return DataProvider.Instance.ExecuteNonQuery($"delete ThueSach where MaThue = N'{rentalBillId}'");
            }

            return 0;
        }

        public int CreateRentalBill(RentalBill rentalBill)
        {
            if (rentalBill != null)
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "insert ThueSach " +
                    $"values (N'{rentalBill.Id}', N'{rentalBill.ClientId}', N'{rentalBill.StaffId}', '{rentalBill.Date}', {rentalBill.Deposit})"
                    );
            }

            return 0;
        }

    }
}
