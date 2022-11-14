using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class RentalBillDetailDAO
    {
        private static RentalBillDetailDAO? instance;

        public static RentalBillDetailDAO Instance
        {
            get { if(instance == null) instance = new RentalBillDetailDAO(); return instance; }
        }

        private RentalBillDetailDAO() { }

        public List<RentalBillDetail> LoadRentalBillDetailList(string rentalBillId)
        {
            List<RentalBillDetail> rentalBillDetailList = new List<RentalBillDetail>();
            DataTable data = DataProvider.Instance.ReadTable($"select * from BookRentalDetail(N'{rentalBillId}')");

            foreach (DataRow row in data.Rows)
            {
                RentalBillDetail rentalBillDetail = new RentalBillDetail(row);
                rentalBillDetailList.Add(rentalBillDetail);
            }

            return rentalBillDetailList;
        }

        public int DeleteRentalBillDetail(string? rentalBillId)
        {
            if (rentalBillId != null)
            {
                return DataProvider.Instance.ExecuteNonQuery($"delete ChiTietThueSach where MaThue = N'{rentalBillId}'");
            }

            return 0;
        }

        public int CreateRentalBillDetail(RentalBillDetail rentalBillDetail)
        {
            if (rentalBillDetail != null)
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "insert ChiTietThueSach " +
                    $"values (N'{rentalBillDetail.RentalBillId}', N'{rentalBillDetail.BookId}', N'{rentalBillDetail.BookStatusId}', {rentalBillDetail.IsReturn})"
                    );
            }

            return 0;
        }

    }
}
