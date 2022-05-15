using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {

        public string username;
        public string password;
        public string emailAddress;
        public int phoneNumber;
        public string firstName;
        public string lastName;

        public User (string name, string pass, string email, int phone, string first, string last)
        {
           username = name;
           password = pass;
           emailAddress = email;
           phoneNumber = phone;
           firstName = first;
           lastName = last;

        }
        
      
            
    }
}
