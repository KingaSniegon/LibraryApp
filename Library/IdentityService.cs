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

            var users = database.CreateUserDB();
            Console.Write("Enter you username: ");
            var username = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            if (users.TryGetValue(username, out var foundUser ))
            {
                if (password == foundUser.Password)
                {

                    return true;

                }
            }

            return false;
        }

    }
}

