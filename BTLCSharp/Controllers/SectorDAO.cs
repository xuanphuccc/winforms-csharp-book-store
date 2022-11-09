using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class SectorDAO
    {
        private static SectorDAO? instance;

        public static SectorDAO Instance
        {
            get { if (instance == null) instance = new SectorDAO(); return SectorDAO.instance; }
        }

        private SectorDAO() { }

        public List<Sector> LoadSectorList(string? condition = null)
        {
            List<Sector> sectorList = new List<Sector>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from LinhVuc " + condition);
            }
            else
            {
                data = DataProvider.Instance.ReadTable("select * from LinhVuc");
            }

            foreach (DataRow row in data.Rows)
            {
                Sector Sector = new Sector(row);
                sectorList.Add(Sector);
            }

            return sectorList;
        }
    }
}
