﻿using Library.API.Entities;
using Library.API.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.API.Data
{
    /// <summary>
    /// Represents the database context for the library application, extending <see cref="IdentityDbContext{TUser}"/>.
    /// </summary>
    public class LibraryDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryDbContext"/> class.
        /// </summary>
        /// <param name="options">The database context options.</param>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        { }

        /// <summary>
        /// Gets or sets the DbSet for managing books in the database.
        /// </summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for managing quotes in the database.
        /// </summary>
        public DbSet<Quote> Quotes { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
        //    modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
        //    modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();
        //    //modelBuilder.Entity<Book>().HasData(
        //    //    new Book
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Title = "To Kill a Mockingbird",
        //    //        ShortDescription = "A powerful novel set in the American South during the struggle for civil rights and social justice.",
        //    //        Author = "Harper Lee",
        //    //        PublishDate = new DateTime(1960, 7, 11).Date
        //    //    },
        //    //    new Book
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Title = "1984",
        //    //        ShortDescription = "A dystopian and political science fiction novel that depicts a society controlled by a totalitarian government.",
        //    //        Author = "George Orwell",
        //    //        PublishDate = new DateTime(1949, 6, 8).Date
        //    //    },
        //    //    new Book
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Title = "The Great Gatsby",
        //    //        ShortDescription = "A distinctive novel that portrays the social elite in the 1920s.",
        //    //        Author = "F. Scott Fitzgerald",
        //    //        PublishDate = new DateTime(1925, 4, 10).Date
        //    //    },
        //    //    new Book
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Title = "The Lord of the Rings",
        //    //        ShortDescription = "An epic fantasy trilogy that follows the journey of Frodo Baggins and his friends to destroy the One Ring.",
        //    //        Author = "J.R.R. Tolkien",
        //    //        PublishDate = new DateTime(1954, 7, 29).Date
        //    //    },
        //    //    new Book
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Title = "The Catcher in the Rye",
        //    //        ShortDescription = "A famous novel that depicts teenage angst and social alienation.",
        //    //        Author = "J.D. Salinger",
        //    //        PublishDate = new DateTime(1951, 7, 16).Date
        //    //    },
        //    //    new Book
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Title = "Brave New World",
        //    //        ShortDescription = "A science fiction novel that describes an advanced future society and how technology and institutions affect humans.",
        //    //        Author = "Aldous Huxley",
        //    //        PublishDate = new DateTime(1932, 1, 17).Date
        //    //    },
        //    //    new Book
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Title = "Pride and Prejudice",
        //    //        ShortDescription = "A classic romance novel that portrays British society in the 19th century.",
        //    //        Author = "Jane Austen",
        //    //        PublishDate = new DateTime(1813, 1, 28).Date
        //    //    },
        //    //    new Book
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Title = "The Chronicles of Narnia",
        //    //        ShortDescription = "A series of seven fantasy novels that follow the adventures of children in the magical land of Narnia.",
        //    //        Author = "C.S. Lewis",
        //    //        PublishDate = new DateTime(1950, 10, 16).Date
        //    //    },
        //    //    new Book
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Title = "Moby-Dick",
        //    //        ShortDescription = "An epic novel that describes the journey of sailors aboard the ship 'Pequod' to hunt a giant whale named Moby Dick.",
        //    //        Author = "Herman Melville",
        //    //        PublishDate = new DateTime(1851, 10, 18).Date
        //    //    },
        //    //    new Book
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Title = "To the Lighthouse",
        //    //        ShortDescription = "A distinctive novel by Virginia Woolf that explores the concept of time, change, and human relationships.",
        //    //        Author = "Virginia Woolf",
        //    //        PublishDate = new DateTime(1927, 5, 5).Date
        //    //    }
        //    //    );


        //    modelBuilder.Entity<Quote>().HasData(
        //        new Quote
        //        {
        //            Id = Guid.NewGuid(),
        //            Content = "The only way to do great work is to love what you do.",
        //            BookName = "Book 1"
        //        },
        //        new Quote
        //        {
        //            Id = Guid.NewGuid(),
        //            Content = "Innovation distinguishes between a leader and a follower.",
        //            BookName = "Book 2"
        //        },
        //        new Quote
        //        {
        //            Id = Guid.NewGuid(),
        //            Content = "The future belongs to those who believe in the beauty of their dreams.",
        //            BookName = "Book 3"
        //        },
        //        new Quote
        //        {
        //            Id = Guid.NewGuid(),
        //            Content = "The only limit to our realization of tomorrow will be our doubts of today.",
        //            BookName = "Book 4"
        //        },
        //        new Quote
        //        {
        //            Id = Guid.NewGuid(),
        //            Content = "Believe you can and you're halfway there.",
        //            BookName = "Book 5"
        //        }
        //    );

        //}
    }
}