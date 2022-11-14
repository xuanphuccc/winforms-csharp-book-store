using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    // Sự phá hủy (làm hỏng)
    internal class Destruction
    {
        private string? id;
        private string? name;
        private int? repairMonney; // Tiền bồi thường

        public string? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public int? RepairMonney { get => repairMonney; set => repairMonney = value; }

        public Destruction(string? id, string? name, int? repairMonney)
        {
            Id = id;
            Name = name;
            RepairMonney = repairMonney;
        }

        public Destruction(DataRow row)
        {
            Id = row["MaVP"].ToString();
            Name = row["TenVP"].ToString();
            RepairMonney = Convert.ToInt32(row["TienPhat"]);
        }
    }
}
