using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class IdentityService
    {
        public bool LogIn()
        {
            var database = new Database();

           
            Console.Write("Enter you username: ");
            var username = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            var users = database.GetUser(username, password);


            return false;
        }

    }
}

