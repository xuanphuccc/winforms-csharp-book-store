using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class LanguageDAO
    {
        private static LanguageDAO? instance;

        public static LanguageDAO Instance
        {
            get { if (instance == null) instance = new LanguageDAO(); return LanguageDAO.instance; }
        }

        private LanguageDAO() { }

        public List<Language> LoadLanguageList(string? condition = null)
        {
            List<Language> languageList = new List<Language>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from NgonNgu " + condition);
            }
            else
            {
                data = DataProvider.Instance.ReadTable("select * from NgonNgu");
            }

            foreach (DataRow row in data.Rows)
            {
                Language Language = new Language(row);
                languageList.Add(Language);
            }

            return languageList;
        }
    }
}
