using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    public class Client
    {

        private string? id;
        private string? name;
        private string? dateOfBirth;
        private string? gender;
        private string? location;

        public string? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public string? DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string? Gender { get => gender; set => gender = value; }
        public string? Location { get => location; set => location = value; }


        public Client(string? id, string? name, string? dateOfBirth, string? gender, string? location)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Location = location;
        }

        public Client(DataRow row)
        {
            Id = row["MaKH"].ToString();
            Name = row["TenKH"].ToString();
            DateOfBirth = row["NgaySinh"].ToString();
            Gender = row["GioiTinh"].ToString();
            Location = row["DiaChi"].ToString();
        }

    }
}
