using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    public class Language
    {
        private string? id;
        private string? name;

        public string? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }

        public Language(string? id, string? name)
        {
            Id = id;
            Name = name;
        }

        public Language(DataRow row)
        {
            Id = row["MaNN"].ToString();
            Name = row["TenNN"].ToString();
        }
    }
}
