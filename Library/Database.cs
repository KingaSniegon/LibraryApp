using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Database
    {
        public Dictionary<string,User> CreateUserDB()
        {
            var user1 = new User("LM", "LM", "l@m.pl", 123456789, "Lucyfer", "Morningstar");
            var user2 = new User("CD", "CD", "c@d.pl", 123456789, "Chloe", "Decker");
            var user3 = new User("DE", "DE", "d@e.pl", 123456789, "Dan", "Espinoza");
            
            var usersDictionary = new Dictionary<string,User>();

            usersDictionary.Add(user1.Username,user1);
            usersDictionary.Add(user2.Username,user2);
            usersDictionary.Add(user3.Username,user3);

            return usersDictionary;
        }
    }
}

