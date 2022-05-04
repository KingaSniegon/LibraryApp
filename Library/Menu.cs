using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Menu
    {
        public void StartUp()
        {
            var identity = new Identity();
            var isLoginCorrect = identity.Login();
            var isLogged = false;


            do

            {
                if (isLoginCorrect == true)
                {
                    isLogged = true;
                    DisplayMenu();
                    Console.Write("Select one of three options (enter 1, 2 or 3): ");
                    var selectedOption = Console.ReadLine();
                    OptionsMenu(selectedOption);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Username or password is incorrect. Please enter your credentials again");
                    isLoginCorrect = identity.Login();
                }
            }
            while (isLoginCorrect == false || isLogged == false);


        }


        public void DisplayMenu ()
        {
            Console.Clear();
            Console.WriteLine("Hello in our Library!");
            Console.WriteLine("1.Book catalog");
            Console.WriteLine("2.Your borrowed books");
            Console.WriteLine("3.Returns");

        }

        public void OptionsMenu(string selectedOption)
        {

           

                if (selectedOption == "1")
                {
                    //TO BE DONE
                    Console.WriteLine("Title");
                    Console.WriteLine("Title2");
                    Console.WriteLine("Title3");
                    Console.ReadLine();
                }
                else if (selectedOption == "2")
                {
                    //TO BE DONE
                    Console.WriteLine("Borrowed book");
                }
                else if (selectedOption == "3")
                {
                    //TO BE DONE
                    Console.WriteLine("Return book");

                }
                else
                {
                    Console.WriteLine("Enter correct number of options");
                    Console.Write("Select one of three options (enter 1, 2 or 3): ");
                    var selectedWrongOption = Console.ReadLine();
                    OptionsMenu(selectedWrongOption);
                }
         
           
            
        }
    }
}
