using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.DAL.Context
{
    using Microsoft.EntityFrameworkCore;

    using PROJECT.ENTITIES.Concrete;

    public class MyContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-KHRJFI9\\SQLEXPRESS; initial catalog=FoodyDB; integrated security=true;TrustServerCertificate=True");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasNoKey();
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
