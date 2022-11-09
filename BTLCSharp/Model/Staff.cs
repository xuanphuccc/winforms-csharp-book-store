using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    public class Staff
    {
        private string? id;
        private string? name;
        private string? shiftId;
        private string? dateOfBirth;
        private string? gender;
        private string? location;
        private string? phoneNumber;
        private string? salary;

        public string? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public string? ShiftId { get => shiftId; set => shiftId = value; }
        public string? DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string? Gender { get => gender; set => gender = value; }
        public string? Location { get => location; set => location = value; }
        public string? PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string? Salary { get => salary; set => salary = value; }

        public Staff(string? id, string? name, string? shift, string? dateOfBirth, string? gender, string? location, string? phoneNumber, string? salary)
        {
            Id = id;
            Name = name;
            ShiftId = shift;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Location = location;
            PhoneNumber = phoneNumber;
            Salary = salary;
        }

        public Staff(DataRow row)
        {
            Id = row["MaNV"].ToString();
            Name = row["TenNV"].ToString();
            ShiftId = row["MaCa"].ToString();
            DateOfBirth = row["NgaySinh"].ToString();
            Gender = row["GioiTinh"].ToString();
            Location = row["DiaChi"].ToString();
            PhoneNumber = row["SDT"].ToString();
            Salary = row["Luong"].ToString();
        }
    }
}
