using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class ReturnBillDetailDAO
    {
        private static ReturnBillDetailDAO? instance;
        public static ReturnBillDetailDAO Instance
        {
            get { if(instance == null) instance = new ReturnBillDetailDAO(); return instance; }
        }

        private ReturnBillDetailDAO() { }

        public List<ReturnBillDetail> LoadReturnBillDetailList(string returnBillId)
        {
            List<ReturnBillDetail> returnBillDetailList = new List<ReturnBillDetail>();
            DataTable data = DataProvider.Instance.ReadTable($"select * from BookReturnDetail(N'{returnBillId}')");

            foreach (DataRow row in data.Rows)
            {
                ReturnBillDetail returnBillDetail = new ReturnBillDetail(row);
                returnBillDetailList.Add(returnBillDetail);
            }

            return returnBillDetailList;
        }

        // Delete Return Bill Detail
        public int DeleteReturnBillDetail(string? returnBillId)
        {
            if (returnBillId != null)
            {
                return DataProvider.Instance.ExecuteNonQuery($"delete ChiTietTraSach where MaTra = N'{returnBillId}'");
            }

            return 0;
        }

        // Create Return Bill Detail
        public int CreateReturnBillDetail(ReturnBillDetail returnBillDetail)
        {
            if (returnBillDetail != null)
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "insert ChiTietTraSach " +
                    $"values (N'{returnBillDetail.ReturnBillId}', N'{returnBillDetail.BookId}', N'{returnBillDetail.DestructionId}', {returnBillDetail.RentalPrice})"
                    );
            }

            return 0;
        }
    }
}
