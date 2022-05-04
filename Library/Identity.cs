using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Identity
    {

        //public Identity()
        //{

        //}
        public bool Login()
        {
            Console.Write("Enter you username: ");
            var username = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            if (username == "1" && password == "1")
            {
                return true;
            }

            return false;
        }



    }
}

