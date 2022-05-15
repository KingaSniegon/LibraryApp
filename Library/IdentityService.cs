using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class IdentityService
    {

        //public Identity()
        //{

        //}
        public bool LogIn()
        {
            var userList = CreateUserDB();
            Console.Write("Enter you username: ");
            var username = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            for (int i = 0; i<3; i++)
            {
                if (username == userList[i].username && password == userList[i].password)
                {
                    return true;
                }

            }

            return false;
        }

        public List<User> CreateUserDB()
        {
            var user1 = new User("LM","LM","l@m.pl",123456789,"Lucyfer","Morningstar");
            var user2 = new User("CD", "CD", "c@d.pl", 123456789, "Chloe", "Decker");
            var user3 = new User("DE", "DE", "d@e.pl", 123456789, "Dan", "Espinoza");

            var users = new List<User>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);

            return users;   

        }

           

    

    }
}

