using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class IdentityService
    {
        public void LogIn()
        {
            var database = new Database();

            Console.Write("Enter you username: ");
            var username = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            var users = database.GetUser(username, password);
            

            if (users.Any())
            {
                UserStaticData.Username = users[0].Username;
            }
            else
            {
                UserStaticData.Username = null;
            }
        }

    }
}

