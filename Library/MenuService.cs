using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MenuService
    {
        public void StartUp()
        {
            var identity = new IdentityService();
            var returnMenu = false;
            identity.LogIn();


            do
            {
                if (UserStaticData.Username != null)
                {
                    
                    DisplayMenu();
                    Console.Write("Select one of the options: ");
                    var selectedOption = Console.ReadLine();
                    
                    
                    if (!OptionsMenu(selectedOption))
                    {

                        UserStaticData.Username = null;
                    }
                    else
                    {
                        returnMenu = true;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Username or password is incorrect. Please enter your credentials again");

                    identity.LogIn();
                }
            }
            while (returnMenu == true);
        }

        public void DisplayMenu ()
        {
            Console.Clear();
            Console.WriteLine("Hello in our Library!");
            Console.WriteLine("1.Book catalog");
            Console.WriteLine("2.Borrow book");
            Console.WriteLine("3.Return book");
            Console.WriteLine("4.Your borrowed books");
            Console.WriteLine("8.Sign Out");

        }

        public bool OptionsMenu(string selectedOption)
        {
            var database = new Database();
            if (selectedOption == "1")
            {
                var listOfBooks = database.GetListofBooks();
                ShowCatalog(listOfBooks);
                Console.WriteLine("");
                Console.Write("To return menu, enter 0: ");
                Console.ReadLine();
                return true;
            }
            else if (selectedOption == "2")
            {
                var listOfAvailableBooks = database.GetListOfAvailableBooks();
                Console.Clear();
                Console.WriteLine("Borrow book");
                ShowCatalog(listOfAvailableBooks);
                BorrowBook(UserStaticData.Username);
                Console.ReadLine();
                return true;
            }
            else if (selectedOption == "3")
            {
                Console.Clear();
                ShowBorrowedBooks();
                Console.WriteLine("");
                Console.Write("To return to menu, enter 0. To return book, enter id of book: ");
                var bookToReturn = int.Parse(Console.ReadLine());
                if (bookToReturn == 0)
                {
                    return true;
                }
                if (bookToReturn != null)
                {
                    database.DeleteBorrowedBook(bookToReturn);
                }
                return true;

            }
            else if (selectedOption == "4")
            {
               
                Console.Clear();
                Console.WriteLine("Borrowed books");
                ShowBorrowedBooks();
                Console.WriteLine("");
                Console.Write("To return menu, enter 0: ");
                var selectedNumber = Console.ReadLine();
                Console.ReadLine();
                return true;

            }
            else if (selectedOption == "8")
            {

                Console.Clear();
                Console.WriteLine("You have been logged out.");
                Console.Write("Press enter to log in again");
                Console.ReadLine();
                return false;

            }
            else
                {

                    Console.WriteLine("Enter correct number of options");
                    Console.Write("Select one of three options (enter 1, 2, 3, 4 or 8): ");
                    var selectedWrongOption = Console.ReadLine();
                    OptionsMenu(selectedWrongOption);
                    return true;
                }
         
           
            
        }
        public void ShowCatalog (IList<Book> listOfBooks)
        {

            Console.Clear();
            Console.WriteLine("ID".PadRight(3) + " | "
                + "Author first name".PadRight(20) + " | "
                + "Author last name".PadRight(20) + " | "
                + "Book title".PadRight(30) + " | "
                + "Book category".PadRight(25) + " | "
                + "Book available quantity".ToString().PadRight(3));

            Console.WriteLine("");

            foreach (var book in listOfBooks)
            {
                Console.WriteLine(book.BookId.ToString().PadRight(3) + " | "
                    + book.AuthorFirstName.PadRight(20) + " | "
                    + book.AuthorLastName.PadRight(20) + " | "
                    + book.BooksTitle.PadRight(30) + " | "
                    + book.BooksCategory.PadRight(25) + " | "
                    + book.BooksAvailableQuantity.ToString().PadRight(3));
            }

        }
        
        private void BorrowBook(string username)
        {
            try
            {
                var database = new Database();
                Console.WriteLine("");
                Console.Write("To borrow book, enter id of selected book: ");
                int bookId = int.Parse(Console.ReadLine());
                database.InsertBorrowedBook(username,bookId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private void ShowBorrowedBooks()
        {
            var database = new Database();
            var listOfBorrowedBooks = database.GetIdsOfBorrowedBooks();
            

            Console.WriteLine("ID".PadRight(3) + " | "
                + "Author first name".PadRight(20) + " | "
                + "Author last name".PadRight(20) + " | "
                + "Book title".PadRight(30) + " | "
                + "Book category".PadRight(25));

            Console.WriteLine("");


            foreach (var book in listOfBorrowedBooks)
            {
                Console.WriteLine(book.BookId.ToString().PadRight(3) + " | "
                    + book.AuthorFirstName.PadRight(20) + " | "
                    + book.AuthorLastName.PadRight(20) + " | "
                    + book.BooksTitle.PadRight(30) + " | "
                    + book.BooksCategory.PadRight(25));
            }

        }


    }
  

}
