using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class PublishingCompanyDAO
    {
        private static PublishingCompanyDAO? instance;

        public static PublishingCompanyDAO Instance
        {
            get { if (instance == null) instance = new PublishingCompanyDAO(); return PublishingCompanyDAO.instance; }
        }

        private PublishingCompanyDAO() { }

        public List<PublishingCompany> LoadPublishingCompanyList(string? condition = null)
        {
            List<PublishingCompany> publishingCompanyList = new List<PublishingCompany>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from NXB " + condition);
            }
            else
            {
                data = DataProvider.Instance.ReadTable("select * from NXB");
            }

            foreach (DataRow row in data.Rows)
            {
                PublishingCompany publishingCompany = new PublishingCompany(row);
                publishingCompanyList.Add(publishingCompany);
            }

            return publishingCompanyList;
        }
    }
}
