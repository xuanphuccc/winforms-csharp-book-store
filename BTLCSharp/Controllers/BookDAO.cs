using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class BookDAO
    {
        private static BookDAO ?instance;

        public static BookDAO Instance
        {
            get { if (instance == null) instance = new BookDAO(); return instance; }
        }

        private BookDAO() { }

        public List<Book> LoadBooksList(string? condition = null)
        {
            List<Book> booksList = new List<Book>();
            DataTable data;

            if(condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from Sach " + condition);
            } else
            {
                data = DataProvider.Instance.ReadTable("select * from Sach");
            }

            foreach(DataRow row in data.Rows)
            {
                Book book = new Book(row);
                booksList.Add(book);
            }

            return booksList;
        }

        public int DeleteBook(string? bookId)
        {
            if (bookId != null)
            {
                return DataProvider.Instance.ExecuteNonQuery($"delete Sach where MaSach = N'{bookId}'");
            }

            return 0;
        }

        public int CreateBook(Book book)
        {
            if (book != null)
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "insert Sach " +
                    $"values (N'{book.Id}', N'{book.Name}', N'{book.BookTypeId}', N'{book.SectorId}', N'{book.AuthorId}', N'{book.PublishingCpnId}', N'{book.LanguageId}', {book.TotalPages}, {book.Price}, {book.RentalPrice}, {book.Quantity}, N'{book.PhotoURL}', N'{book.Note}')"
                    );
            }

            return 0;
        }

        public int UpdateBook(Book book)
        {
            if (book != null)
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "update Sach " +
                    $@"set TenSach = N'{book.Name}', MaLS = N'{book.BookTypeId}', MaLV = N'{book.SectorId}', MaTG = N'{book.AuthorId}', MaNXB = N'{book.PublishingCpnId}', MaNN = N'{book.LanguageId}', SoTrang = {book.TotalPages}, GiaSach = {book.Price}, DGThue = {book.RentalPrice}, SoLuong = {book.Quantity}, Anh = N'{book.PhotoURL}', GhiChu = N'{book.Note}' " +
                    $"where MaSach = N'{book.Id}'"
                    );
            }

            return 0;
        }
    }
}
