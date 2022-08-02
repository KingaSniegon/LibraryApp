using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Database
    {
        //public IDictionary<string, User> GetUserDB()
        //{
        //    var user1 = new User("LM", "LM", "l@m.pl", 123456789, "Lucyfer", "Morningstar");
        //    var user2 = new User("CD", "CD", "c@d.pl", 123456789, "Chloe", "Decker");
        //    var user3 = new User("DE", "DE", "d@e.pl", 123456789, "Dan", "Espinoza");

        //    var usersdictionary = new Dictionary<string, User>();

        //    usersdictionary.Add(user1.Username, user1);
        //    usersdictionary.Add(user2.Username, user2);
        //    usersdictionary.Add(user3.Username, user3);

        //    return usersdictionary;
        //}

        //public ilist<book> createlistofbooks()

        //{

        //    var book1 = new book(1, "george", "martin", "a game of thrones", "fantasy", 10);
        //    var book2 = new book(2, "agatha", "christie", "death on the nile", "thriller", 5);
        //    var book3 = new book(3, "balague", "guillem", "cristiano ronaldo.biography", "biography", 5);
        //    var book4 = new book(4, "jan", "brzechwa", "akademia pana kleksa", "children's literature", 15);
        //    var book5 = new book(5, "frank", "herbert", "dune", "science fiction", 5);

        //    var books = new list<book>();
        //    books.add(book1);
        //    books.add(book2); 
        //    books.add(book3);
        //    books.add(book4);
        //    books.add(book5);

        //    return books;
        //}



        public IList<Book> GetListofBooks()
        {
            try
            {
                using (var ctx = new DbContext())
                {

                    var books = ctx.Books
                        .ToArray();
     
                    return books;
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public IList <User> GetUser(string username, string password)
        {
            try
            {
                using (var ctx  = new DbContext())
                {
                    var user = ctx.Users
                        .Where(c => c.Username == username)
                        .Where(c => c.Password == password)
                        .ToArray();

                    return user;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
