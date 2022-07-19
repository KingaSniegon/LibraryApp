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
            var isLoginCorrect = identity.LogIn();
            var isLogged = false;
            var returnMenu = false;


            do

            {
                if (isLoginCorrect = true)
                {
                    isLogged = true;
                    DisplayMenu();
                    Console.Write("Select one of the options: ");
                    var selectedOption = Console.ReadLine();

                    
                    if (!OptionsMenu(selectedOption))
                    {
                        isLogged = false;
                        isLoginCorrect = false;
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
                    isLoginCorrect = identity.LogIn();
                }
            }
            while (isLogged == false || returnMenu == true);
        }

        public void DisplayMenu ()
        {
            Console.Clear();
            Console.WriteLine("Hello in our Library!");
            Console.WriteLine("1.Book catalog");
            Console.WriteLine("2.Your borrowed books");
            Console.WriteLine("3.Returns");
            Console.WriteLine("8.Sign Out");

        }

        public bool OptionsMenu(string selectedOption)
        {
            if (selectedOption == "1")
            {
               
                ShowCatalog();
                return true;
            }
            else if (selectedOption == "2")
            {
                //TO BE DONE
                Console.Clear();
                Console.WriteLine("Borrowed book");
                Console.ReadLine();
                return true;
            }
            else if (selectedOption == "3")
            {
                //TO BE DONE
                Console.Clear();
                Console.WriteLine("Return book");
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
                    Console.Write("Select one of three options (enter 1, 2 or 3): ");
                    var selectedWrongOption = Console.ReadLine();
                    OptionsMenu(selectedWrongOption);
                    return true;
                }
         
           
            
        }
        public void ShowCatalog ()
        {


            Console.Clear();


            var database = new Database();
            var listOfBooks = database.CreateListofBooks();

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

            Console.WriteLine("");
            Console.Write("To return menu, enter 0: ");
            var selectedNumber = Console.ReadLine();

            
        }
        


    }
  

}
