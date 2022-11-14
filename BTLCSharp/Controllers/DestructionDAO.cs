using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class DestructionDAO
    {
        private static DestructionDAO? instance;

        public static DestructionDAO Instance
        {
            get { if (instance == null) instance = new DestructionDAO(); return instance; }
        }

        private DestructionDAO() { }

        public List<Destruction> LoadDestructionList(string? condition = null)
        {
            List<Destruction> destructionList = new List<Destruction>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from ViPham " + condition);
            }
            else
            {
                data = DataProvider.Instance.ReadTable("select * from ViPham");
            }

            foreach (DataRow row in data.Rows)
            {
                Destruction destruction = new Destruction(row);
                destructionList.Add(destruction);
            }

            return destructionList;
        }

    }
}
