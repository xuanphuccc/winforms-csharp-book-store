using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    internal class ReturnBillDetail
    {
        private string? returnBillId;
        private string? bookId;
        private string? bookName;
        private string? destructionId;
        private int? rentalPrice;

        public string? ReturnBillId { get => returnBillId; set => returnBillId = value; }
        public string? BookId { get => bookId; set => bookId = value; }
        public string? BookName { get => bookName; set => bookName = value; }
        public string? DestructionId { get => destructionId; set => destructionId = value; }
        public int? RentalPrice { get => rentalPrice; set => rentalPrice = value; }


        public ReturnBillDetail(string? returnBillId, string? bookId, string? bookName, string? destructionId, int? rentalPrice)
        {
            ReturnBillId = returnBillId;
            BookId = bookId;
            BookName = bookName;
            DestructionId = destructionId;
            RentalPrice = rentalPrice;
        }

        public ReturnBillDetail(DataRow row)
        {
            ReturnBillId = row["MaTra"].ToString();
            BookId = row["MaSach"].ToString();
            BookName = row["TenSach"].ToString();
            DestructionId = row["MaVP"].ToString();
            RentalPrice = Convert.ToInt32(row["ThanhTien"]);
            // Không thể convert DBNull sang int và kiểu dữ liệu khác
            // Nên trong database không được insert null
        }
    }
}
