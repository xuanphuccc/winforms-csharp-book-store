using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Model
{
    public class Book
    {
        private string? id;
        private string? name;
        private int? totalPages;
        private int? price;
        private int? rentalPrice;
        private int? quantity;
        private string? photoURL;
        private string? note;

        private string? bookTypeId;
        private string? sectorId;
        private string? authorId;
        private string? publishingCpnId;
        private string? languageId;

        public string? Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public int? TotalPages { get => totalPages; set => totalPages = value; }
        public int? Price { get => price; set => price = value; }
        public int? RentalPrice { get => rentalPrice; set => rentalPrice = value; }
        public int? Quantity { get => quantity; set => quantity = value; }
        public string? PhotoURL { get => photoURL; set => photoURL = value; }
        public string? Note { get => note; set => note = value; }
        public string? BookTypeId { get => bookTypeId; set => bookTypeId = value; }
        public string? SectorId { get => sectorId; set => sectorId = value; }
        public string? AuthorId { get => authorId; set => authorId = value; }
        public string? PublishingCpnId { get => publishingCpnId; set => publishingCpnId = value; }
        public string? LanguageId { get => languageId; set => languageId = value; }

        public Book(string? id, string? name, int? totalPages, int? price, int? rentalPrice, int? quantity, string? photoURL, string? note, string? bookTypeId, string? sectorId, string? authorId, string? publishingCpnId, string? languageId)
        {
            Id = id;
            Name = name;
            TotalPages = totalPages;
            Price = price;
            RentalPrice = rentalPrice;
            Quantity = quantity;
            PhotoURL = photoURL;
            Note = note;
            BookTypeId = bookTypeId;
            SectorId = sectorId;
            AuthorId = authorId;
            PublishingCpnId = publishingCpnId;
            LanguageId = languageId;
        }

        public Book(DataRow row)
        {
            Id = row["MaSach"].ToString();
            Name = row["TenSach"].ToString();
            TotalPages = Convert.ToInt32(row["SoTrang"]);
            Price = Convert.ToInt32(row["GiaSach"]);
            RentalPrice = Convert.ToInt32(row["DGThue"]);
            Quantity = Convert.ToInt32(row["SoLuong"]);
            PhotoURL = row["Anh"].ToString();
            Note = row["GhiChu"].ToString();
            BookTypeId = row["MaLS"].ToString();
            SectorId = row["MaLV"].ToString();
            AuthorId = row["MaTG"].ToString();
            PublishingCpnId = row["MaNXB"].ToString();
            LanguageId = row["MaNN"].ToString();
        }
    }
}
