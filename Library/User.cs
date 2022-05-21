using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {

        public string Username { get; private set; }
        public string Password { get; private set; }
        public string EmailAddress { get; private set; }
        public int PhoneNumber { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public User (string username, string password, string emailAddress, int phoneNumber, string firstName, string lastName)
        {
           this.Username = username;
           this.Password = password;
           this.EmailAddress = emailAddress;
           this.PhoneNumber = phoneNumber;
           this.FirstName = firstName;
           this.LastName = lastName;

        }
        
      
            
    }
}
