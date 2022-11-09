using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    // Nhà xuât bản
    public class PublishingCompany
    {
        private string? id;
        private string? name;
        private string? location;
        private string? phoneNumber;

        public string? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public string? Location { get => location; set => location = value; }
        public string? PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public PublishingCompany(string? id, string? name, string? location, string? phoneNumber)
        {
            Id = id;
            Name = name;
            Location = location;
            PhoneNumber = phoneNumber;
        }

        public PublishingCompany(DataRow row)
        {
            Id = row["MaNXB"].ToString();
            Name = row["TenNXB"].ToString();
            Location = row["DiaChi"].ToString();
            PhoneNumber = row["SDT"].ToString();
        }
    }
}
