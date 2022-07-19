using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }  

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Book>()
                .ToTable("Books");

            builder.Entity<Book>()
                .Property(c => c.AuthorFirstName)
                .HasColumnName("AuthorFirstName");

            builder.Entity<Book>()
                .Property(c => c.AuthorLastName)
                .HasColumnName("AuthorLastName");

            builder.Entity<Book>()
                .Property(c => c.BooksTitle)
                .HasColumnName("BooksTitle");

            builder.Entity<Book>()
                .Property(c => c.BooksCategory)
                .HasColumnName("BooksCategory");

            builder.Entity<Book>()
                .Property(c => c.BooksAvailableQuantity)
                .HasColumnName("BooksAvailableQuantity");

            builder.Entity<User>()
                .ToTable("Users");

            builder.Entity<User>()
                .Property(c =>c.Username)
                .HasColumnName("Username");

            builder.Entity<User>()
                .Property(c =>c.Password)
                .HasColumnName("Password");

            builder.Entity<User>()
               .Property(c => c.EmailAddress)
               .HasColumnName("EmailAddress");

            builder.Entity<User>()
             .Property(c => c.PhoneNumber)
             .HasColumnName("PhoneNumber");

            builder.Entity<User>()
                .Property(c => c.FirstName)
                .HasColumnName("FirstName");

            builder.Entity<User>()
                .Property(c => c.LastName)
                .HasColumnName("LastName");
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=localhost;Database=Library;Integrated Security=True;");
        }
    }
}
