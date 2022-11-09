using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    // Ca làm việc
    public class Shift
    {
        private string? id;
        private string? name;

        public string? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }

        public Shift(string? id, string? name)
        {
            Id = id;
            Name = name;
        }

        public Shift(DataRow row)
        {
            Id = row["MaCa"].ToString();
            Name = row["TenCa"].ToString();
        }
    }
}
