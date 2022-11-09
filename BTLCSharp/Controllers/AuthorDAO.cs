using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class AuthorDAO
    {
        private static AuthorDAO? instance;

        public static AuthorDAO Instance
        {
            get { if (instance == null) instance = new AuthorDAO(); return AuthorDAO.instance; }
        }

        private AuthorDAO() { }

        public List<Author> LoadAuthorList(string? condition = null)
        {
            List<Author> authorList = new List<Author>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from TacGia " + condition);
            }
            else
            {
                data = DataProvider.Instance.ReadTable("select * from TacGia");
            }

            foreach (DataRow row in data.Rows)
            {
                Author author = new Author(row);
                authorList.Add(author);
            }

            return authorList;
        }
    }
}
