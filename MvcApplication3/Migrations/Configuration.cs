namespace MvcApplication3.Migrations
{
    using MvcApplication3.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcApplication3.Models.BookDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcApplication3.Models.BookDBContext context)
        {
            context.Books.AddOrUpdate(i => i.Title,
                new Book
                {
                    Title = "Catch-22",
                    Writer = "Joseph Heller",
                    PublishDate = DateTime.Parse("1962-11-11"),
                    Genre = "Satirical War",
                    Price = 7.99M
                },

                 new Book
                 {
                     Title = "The Sense Of An Ending",
                     Writer = "Julian Barnes",
                     PublishDate = DateTime.Parse("2011-1-11"),
                     Genre = "Modern Literature",
                     Price = 8.99M
                 },

                 new Book
                 {
                     Title = "Flow",
                     Writer = "Mihaly Csikszentmihalyi",
                     PublishDate = DateTime.Parse("1972-2-23"),
                     Genre = "Non-Fiction",
                     Price = 9.99M
                 },

               new Book
               {
                   Title = "Kaiken käsikirja",
                   Writer = "Esko Valtaoja",
                   PublishDate = DateTime.Parse("2012-12-1"),
                   Genre = "Non-Fiction",
                   Price = 3.99M
               }
           );

        }
    }
}
