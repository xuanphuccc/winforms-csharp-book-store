using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    internal class BookStatus
    {
        private string? id;
        private string? name;

        public string? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }

        public BookStatus(string? id, string? name)
        {
            Id = id;
            Name = name;
        }

        public BookStatus(DataRow row)
        {
            Id = row["MaTT"].ToString();
            Name = row["TenTT"].ToString();
        }
    }
}
