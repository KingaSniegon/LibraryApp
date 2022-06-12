using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Database
    {
        public IDictionary<string, User> CreateUserDB()
        {
            var user1 = new User("LM", "LM", "l@m.pl", 123456789, "Lucyfer", "Morningstar");
            var user2 = new User("CD", "CD", "c@d.pl", 123456789, "Chloe", "Decker");
            var user3 = new User("DE", "DE", "d@e.pl", 123456789, "Dan", "Espinoza");

            var usersDictionary = new Dictionary<string, User>();

            usersDictionary.Add(user1.Username, user1);
            usersDictionary.Add(user2.Username, user2);
            usersDictionary.Add(user3.Username, user3);

            return usersDictionary;
        }

        public IList<Book> CreateListofBooks()

        {

            var Book1 = new Book(1, "George", "Martin", "A Game of Thrones", "Fantasy", 10);
            var Book2 = new Book(2, "Agatha", "Christie", "Death on the Nile", "Thriller", 5);
            var Book3 = new Book(3, "Balague", "Guillem", "Cristiano Ronaldo.Biography", "Biography", 5);
            var Book4 = new Book(4, "Jan", "Brzechwa", "Akademia Pana Kleksa", "Children's literature", 15);
            var Book5 = new Book(5, "Frank", "Herbert", "Dune", "Science fiction", 5);

            var books = new List<Book>();
            books.Add(Book1);
            books.Add(Book2); 
            books.Add(Book3);
            books.Add(Book4);
            books.Add(Book5);

            return books;
        }




    }
}

