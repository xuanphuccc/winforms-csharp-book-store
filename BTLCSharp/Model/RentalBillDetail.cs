using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    internal class RentalBillDetail
    {
        private string? rentalBillId;
        private string? bookId;
        private string? bookName;
        private string? bookStatusId;
        private int? isReturn;

        public string? RentalBillId { get => rentalBillId; set => rentalBillId = value; }
        public string? BookId { get => bookId; set => bookId = value; }
        public string? BookName { get => bookName; set => bookName = value; }
        public string? BookStatusId { get => bookStatusId; set => bookStatusId = value; }
        public int? IsReturn { get => isReturn; set => isReturn = value; }

        public RentalBillDetail(string? rentalBillId, string? bookId, string? bookName, string? bookStatusId, int? isReturn)
        {
            RentalBillId = rentalBillId;
            BookId = bookId;
            BookName = bookName;
            BookStatusId = bookStatusId;
            IsReturn = isReturn;
        }

        public RentalBillDetail(DataRow row)
        {
            RentalBillId = row["MaThue"].ToString();
            BookId = row["MaSach"].ToString();
            BookName = row["TenSach"].ToString();
            BookStatusId = row["MaTT"].ToString();
            IsReturn = Convert.ToInt32(row["DaTra"]);
        }
    }
}
