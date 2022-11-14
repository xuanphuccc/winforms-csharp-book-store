using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    public class RentalBill
    {
        private string? id;
        private string? clientId;
        private string? clientName;
        private string? staffId;
        private string? date;
        private string? deposit; // Tiền đặt cọc

        public string? Id { get => id; set => id = value; }
        public string? ClientId { get => clientId; set => clientId = value; }
        public string? ClientName { get => clientName; set => clientName = value; }
        public string? StaffId { get => staffId; set => staffId = value; }
        public string? Date { get => date; set => date = value; }
        public string? Deposit { get => deposit; set => deposit = value; }

        public RentalBill(string? id, string? clientId, string? staffId, string? date, string? deposit)
        {
            Id = id;
            ClientId = clientId;
            StaffId = staffId;
            Date = date;
            Deposit = deposit;
        }

        public RentalBill(DataRow row)
        {
            Id = row["MaThue"].ToString();
            ClientId = row["MaKH"].ToString();
            ClientName = row["TenKH"].ToString();
            StaffId = row["MaNV"].ToString();
            Date = row["NgayThue"].ToString();
            Deposit = row["TienCoc"].ToString();
        }
    }
}
