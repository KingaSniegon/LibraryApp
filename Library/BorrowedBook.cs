using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BorrowedBook
    {

        public string Username { get; set; }
        public int BorrowedBookId { get; set; }
        

        public BorrowedBook (string username, int borrowedBookId)
        {
           Username = username;
           BorrowedBookId = borrowedBookId;
        }
        
      
            
    }
}
