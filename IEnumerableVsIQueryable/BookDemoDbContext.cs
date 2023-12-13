using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableVsIQueryable
{
    public class BookDemoDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Clean Code: By Robert C. Martin",
                    Price = 12
                },
                new Book
                {
                    BookId = 2,
                    Title = "The Art of Computer Programming",
                    Price = 15
                },
                new Book
                {
                    BookId = 3,
                    Title = "Introduction to Algorithms",
                    Price = 8
                },
                new Book
                {
                    BookId = 4,
                    Title = "Breaking Barriers: the Story of a Dalit Chief Secretary",
                    Price = 9
                },
                new Book
                {
                    BookId = 5,
                    Title = "Human Anatomy",
                    Price = 17
                },
                new Book
                {
                    BookId = 6,
                    Title = "Come! Let's Run",
                    Price = 13
                },
                new Book
                {
                    BookId = 7,
                    Title = "The Best of Satyajit Ray",
                    Price = 7
                },
                new Book
                {
                    BookId = 8,
                    Title = "As Good As My Word",
                    Price = 25
                },
                new Book
                {
                    BookId = 9,
                    Title = "Learning C# by Developing Games with Unity 2020",
                    Price = 14
                },
                new Book
                {
                    BookId = 10,
                    Title = "Modern Tkinter for Busy Python Developers",
                    Price = 16
                }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MAYUR-PC;Database=BookDb;User Id=sa;Password=123456;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
