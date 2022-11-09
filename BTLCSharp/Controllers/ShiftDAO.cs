using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class ShiftDAO
    {
        private static ShiftDAO? instance;

        public static ShiftDAO Instance
        {
            get { if (instance == null) instance = new ShiftDAO(); return ShiftDAO.instance; }
        }

        private ShiftDAO() { }

        public List<Shift> LoadShiftList(string? condition = null)
        {
            List<Shift> shiftList = new List<Shift>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from CaLam " + condition);
            }
            else
            {
                data = DataProvider.Instance.ReadTable("select * from CaLam");
            }

            foreach (DataRow row in data.Rows)
            {
                Shift shift = new Shift(row);
                shiftList.Add(shift);
            }

            return shiftList;
        }
    }
}
