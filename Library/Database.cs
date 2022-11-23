using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Database
    {

        public IList<Book> GetListofBooks()
        {
            try
            {
                using (var ctx = new DbContext())
                {

                    var books = ctx.Books
                        .ToArray();
     
                    return books;
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public IList<Book> GetListOfAvailableBooks()
        {
            try
            {
                using (var ctx = new DbContext())
                {

                    var availableBooks = ctx.Books
                        .Where(c=>c.BooksAvailableQuantity != 0)
                        .ToArray();

                    return availableBooks;
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public IList <User> GetUser(string username, string password)
        {
            try
            {
                using (var ctx  = new DbContext())
                {
                    var user = ctx.Users
                        .Where(c => c.Username == username)
                        .Where(c => c.Password == password)
                        .ToArray();


                    return user;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void InsertBorrowedBook(string username, int bookId)
        {
            try
            {
                using (var ctx = new DbContext())
                {

                    BorrowedBook borrowedBook = new BorrowedBook(username, bookId);
                    ctx.BorrowedBooks
                        .Add(borrowedBook);

                    var book = ctx.Books
                        .Where(c => c.BookId == bookId)
                        .FirstOrDefault();
                    book.BooksAvailableQuantity = book.BooksAvailableQuantity - 1;

                    ctx.Books
                        .Update(book);

                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }
        public Book[] GetIdsOfBorrowedBooks()
        {
            try
            {
                using (var ctx = new DbContext())
                {

                    var listOfBorrowedBooks = ctx.BorrowedBooks
                        .Where(c => c.Username == UserStaticData.Username)
                        .Select(c => c.Book)
                        .ToArray();

                   

                    return listOfBorrowedBooks;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public IList<Book> GetListOfBorrowedBooks(int[] idsOfBorrowedBooks)
        {
            try
            {
                using (var ctx = new DbContext())
                {

                    var listOfBorrowedBooks = ctx.Books
                        .Where(c => idsOfBorrowedBooks.Contains(c.BookId))
                        .ToArray();

                    return listOfBorrowedBooks;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteBorrowedBook(int bookToReturn)
        {
            try
            {
                using (var ctx = new DbContext())
                {

                    var bookToDelete = ctx.BorrowedBooks
                        .Where(c => c.BorrowedBookId == bookToReturn)
                        .FirstOrDefault();

                    ctx.BorrowedBooks.Remove(bookToDelete);

                    var book = ctx.Books
                      .Where(c => c.BookId == bookToReturn)
                      .FirstOrDefault();
                    book.BooksAvailableQuantity = book.BooksAvailableQuantity + 1;

                    ctx.Books
                        .Update(book);

                    ctx.SaveChanges();
                     
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }

    }
}