using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BorrowedBook
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int BorrowedBookId { get; set; }
        public Book Book { get; set; }
        



        public BorrowedBook (string username, int borrowedBookId)
        {
           Username = username;
           BorrowedBookId = borrowedBookId;
        }
        
      
            
    }
}
