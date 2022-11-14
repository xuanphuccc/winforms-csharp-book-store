using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    public class ReturnBill
    {
        private string? id;
        private string? rentalBillId;
        private string? staffId;
        private string? date;
        private int totalMoney;

        public string? Id { get => id; set => id = value; }
        public string? RentalBillId { get => rentalBillId; set => rentalBillId = value; }
        public string? StaffId { get => staffId; set => staffId = value; }
        public string? Date { get => date; set => date = value; }
        public int TotalMoney { get => totalMoney; set => totalMoney = value; }

        public ReturnBill(string? id, string? rentalBillId, string? staffId, string? date, int totalMoney)
        {
            Id = id;
            RentalBillId = rentalBillId;
            StaffId = staffId;
            Date = date;
            TotalMoney = totalMoney;
        }

        public ReturnBill(DataRow row)
        {
            Id = row["MaTra"].ToString();
            RentalBillId = row["MaThue"].ToString();
            StaffId = row["MaNV"].ToString();
            Date = row["NgayTra"].ToString();
            TotalMoney = Convert.ToInt32(row["TongTien"]);
        }
    }
}
