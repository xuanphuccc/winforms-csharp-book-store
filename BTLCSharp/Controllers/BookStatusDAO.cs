using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class BookStatusDAO
    {
        private static BookStatusDAO? instance;

        public static BookStatusDAO Instance
        {
            get { if (instance == null) instance = new BookStatusDAO(); return instance; }
        }

        private BookStatusDAO() { }

        public List<BookStatus> LoadBookStatusList(string? condition = null)
        {
            List<BookStatus> bookStatusList = new List<BookStatus>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from TinhTrang " + condition);
            }
            else
            {
                data = DataProvider.Instance.ReadTable("select * from TinhTrang");
            }

            foreach (DataRow row in data.Rows)
            {
                BookStatus bookStatus = new BookStatus(row);
                bookStatusList.Add(bookStatus);
            }

            return bookStatusList;
        }
    }
}
