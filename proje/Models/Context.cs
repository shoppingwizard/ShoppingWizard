using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class Context : DbContext
    {
      
        public DbSet<Roller> Roller { get; set; }
        public DbSet<Favoriler> Favoriler { get; set; }
        public DbSet<firmaAdres> firmaAdres { get; set; }
        public DbSet<FirmaGaleri> FirmaGaleri { get; set; }
        public DbSet<Firmalar> Firmalar { get; set; }
        public DbSet<Kategoriler> Kategoriler { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<TelefonNo> TelefonNo { get; set; }
        public DbSet<YorumvePuan> YorumvePuan { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}