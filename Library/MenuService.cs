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


            do

            {
                if (isLoginCorrect == true)
                {
                    isLogged = true;
                    DisplayMenu();
                    Console.Write("Select one of the options: ");
                    var selectedOption = Console.ReadLine();

                    if (!OptionsMenu(selectedOption))
                    {
                        isLogged = false;
                        isLoginCorrect = false;
                    };

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Username or password is incorrect. Please enter your credentials again");
                    isLoginCorrect = identity.LogIn();
                }
            }
            while (isLogged == false);


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
                //TO BE DONE
                Console.Clear();
                Console.WriteLine("Title");
                Console.WriteLine("Title2");
                Console.WriteLine("Title3");
                Console.ReadLine();
                return true;    
            }
            else if (selectedOption == "2")
            {
                //TO BE DONE
                Console.Clear();
                Console.WriteLine("Borrowed book");
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
    }
}
