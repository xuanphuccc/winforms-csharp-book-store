using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class BookTypeDAO
    {
        private static BookTypeDAO ?instance;

        internal static BookTypeDAO Instance { 
            get { if(instance == null) instance = new BookTypeDAO(); return instance; }
        }

        private BookTypeDAO() { }

        public List<BookType> LoadBookTypeList(string? condition = null)
        {
            List<BookType> bookTypes = new List<BookType>();
            DataTable data;

            if(condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from LoaiSach" + condition);
            } else
            {
                data = DataProvider.Instance.ReadTable("select * from LoaiSach");
            }

            foreach(DataRow row in data.Rows)
            {
                BookType bookType = new BookType(row);
                bookTypes.Add(bookType);
            }

            return bookTypes;
        }
    }
}
