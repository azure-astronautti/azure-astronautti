namespace MvcApplication1.Migrations
{
    using MvcApplication1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcApplication1.Models.KissaDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcApplication1.Models.KissaDBContext context)
        {
            context.Kissat.AddOrUpdate(i => i.Nimi,
        new Kissa
        {
            Nimi = "Musti",
            Ika = 5
        },

       new Kissa
       {
           Nimi = "Mirri",
           Ika = 3
       }
   );

        }
    }
}
