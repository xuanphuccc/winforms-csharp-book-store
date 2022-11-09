using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class StaffDAO
    {
        private static StaffDAO ?instance;

        public static StaffDAO Instance
        {
            get { if(instance == null) instance = new StaffDAO(); return instance; }
        }

        private StaffDAO() { }

        public List<Staff> LoadStaffList(string? condition = null)
        {
            List<Staff> staffList = new List<Staff>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from NhanVien " + condition);
            }
            else
            {
                data = DataProvider.Instance.ReadTable("select * from NhanVien");
            }

            foreach (DataRow row in data.Rows)
            {
                Staff staff = new Staff(row);
                staffList.Add(staff);
            }

            return staffList;
        }

        public int DeleteStaff(string? staffId)
        {
            if (staffId != null)
            {
                return DataProvider.Instance.ExecuteNonQuery($"delete NhanVien where MaNV = N'{staffId}'");
            }

            return 0;
        }

        public int CreateStaff(Staff staff)
        {
            if (staff != null)
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "insert NhanVien " +
                    $"values (N'{staff.Id}', N'{staff.Name}', N'{staff.ShiftId}', '{staff.DateOfBirth}', N'{staff.Gender}', N'{staff.Location}', N'{staff.PhoneNumber}', {staff.Salary})"
                    );
            }

            return 0;
        }

        public int UpdateStaff(Staff staff)
        {
            if (staff != null)
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "update NhanVien " +
                    $"set TenNV = N'{staff.Name}', MaCa = N'{staff.ShiftId}', NgaySinh = '{staff.DateOfBirth}', GioiTinh = N'{staff.Gender}', DiaChi = N'{staff.Location}', SDT = N'{staff.PhoneNumber}', Luong = {staff.Salary} " +
                    $"where MaNV = N'{staff.Id}'"
                    );
            }

            return 0;
        }
    }
}
