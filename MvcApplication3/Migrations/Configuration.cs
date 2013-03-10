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
                    ReadBy = DateTime.Parse("2013-3-20"),
                    Approved = true
                },

                 new Book
                 {
                     Title = "The Sense Of An Ending",
                     Writer = "Julian Barnes",
                     PublishDate = DateTime.Parse("2011-1-11"),
                     Genre = "Modern Literature",
                     ReadBy = DateTime.Parse("2013-3-27"),
                     Approved = true
                 },

                 new Book
                 {
                     Title = "Flow",
                     Writer = "Mihaly Csikszentmihalyi",
                     PublishDate = DateTime.Parse("1972-2-23"),
                     Genre = "Non-Fiction",
                     ReadBy = DateTime.Parse("2013-3-13"),
                     Approved = true
                 },

               new Book
               {
                   Title = "Kaiken käsikirja",
                   Writer = "Esko Valtaoja",
                   PublishDate = DateTime.Parse("2012-12-1"),
                   Genre = "Non-Fiction",
                   ReadBy = DateTime.Parse("2013-4-3"),
                   Approved = true
               }
           );

        }
    }
}
