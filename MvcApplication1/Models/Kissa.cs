using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication1.Models
{
    public class Kissa
    {
        public int ID { set; get; }
        public string Nimi { set; get; }
        public int Ika { set; get; }
    }

    public class KissaDBContext : DbContext
    {
        public DbSet<Kissa> Kissat { get; set; }
    }
}