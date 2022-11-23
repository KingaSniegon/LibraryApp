using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Books", new[] { "AuthorFirstName", "AuthorLastName", "BooksTitle", "BooksCategory", "BooksAvailableQuantity" },
    new[,] {
            { "George", "Martin", "A Game of Thrones", "Fantasy", "10" },
            { "Agatha", "Christie", "Death on the Nile", "Thriller", "5" },
            { "Balague", "Guillem", "Cristiano Ronaldo.Biography", "Biography", "5" },
            { "Jan", "Brzechwa", "Akademia Pana Kleksa", "Childrens literature", "15" },
            { "Frank", "Herbert", "Dune", "Science fiction", "5" }});


            migrationBuilder.InsertData("Users", new[] { "Username", "Password", "EmailAddress", "PhoneNumber", "FirstName", "LastName" },
           new[,] {
            { "LM", "LM", "l@m.pl", "123456789", "Lucyfer", "Morningstar" },
            { "CD", "CD", "c@d.pl", "123456789", "Chloe", "Decker" },
            { "DE", "DE", "d@e.pl", "123456789", "Dan", "Espinoza" } });
        
    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
