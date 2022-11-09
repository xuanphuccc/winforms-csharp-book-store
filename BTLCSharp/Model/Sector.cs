using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    // Lĩnh vực
    public class Sector
    {
        private string? id;
        private string? name;

        public string? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }

        public Sector(string? id, string? name)
        {
            Id = id;
            Name = name;
        }
        public Sector(DataRow row)
        {
            Id = row["MaLV"].ToString();
            Name = row["TenLV"].ToString();
        }
    }
}
