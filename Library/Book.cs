using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int BookId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string BooksTitle { get; set; }
        public string BooksCategory { get; set; }
        public int BooksAvailableQuantity { get; set; }

        public Book(int bookId, string authorFirstName, string authorLastName, string booksTitle, string booksCategory, int booksAvailableQuantity)

        {
            BookId = bookId;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            BooksTitle = booksTitle;
            BooksCategory = booksCategory;
            BooksAvailableQuantity = booksAvailableQuantity;

        }
    }
}
