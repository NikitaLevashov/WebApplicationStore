using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationStoreDAL.Entities;

namespace WebApplicationStoreDAL.EF
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=storedb;Trusted_Connection=True");
        }
        public void AddCascadingObject(object rootEntity) 
        {
            ChangeTracker.TrackGraph(
                rootEntity,
                node =>
                    node.Entry.State = !node.Entry.IsKeySet ? EntityState.Added : EntityState.Unchanged
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

             modelBuilder.Entity<Product>()
            .HasOne(e => e.Catalog)
            .WithMany(d => d.Products)
            .HasForeignKey(e => e.CatalogID);

            modelBuilder.Entity<Catalog>().HasData(
                new Catalog { Name = "Mobile phone", Id = 1 },
                new Catalog { Name = "Notebook", Id = 2 },
                new Catalog { Name = "Camera", Id = 3 },
                new Catalog { Name = "Headphones", Id = 4 }
                );
          
            modelBuilder.Entity<Product>().HasData(
                new Product[]
                {
                       new Product { Id = 1, Name = "Xiaomi Redmi Note 8", CatalogID = 1},
                       new Product { Id = 2, Name = "Xiaomi Redmi Note 9 Pro", CatalogID=1 },
                       new Product { Id = 3, Name = "Xiaomi Redmi 7", CatalogID=1},
                       new Product { Id = 4, Name = "Xiaomi Redmi 8", CatalogID=1 },
                       new Product { Id = 5, Name = "Xiaomi Mi Note 10 Lite", CatalogID=1 },
                       new Product { Id = 6, Name = "Xiaomi Redmi 9C", CatalogID=1 },
                       new Product { Id = 7, Name = "Xiaomi RedmiBook 16 JYU4277CN", CatalogID=2 },
                       new Product { Id = 8, Name = "Xiaomi Mi Gaming Laptop Enhanced Edition 2019 JYU4144CN", CatalogID=2},
                       new Product { Id = 9, Name = "Xiaomi Mi Notebook Pro 2020 JYU4222CN", CatalogID=2 },
                       new Product { Id = 10, Name = "Xiaomi RedmiBook 13 Ryzen Edition 2020 JYU4251CN", CatalogID=2 },
                       new Product { Id = 11, Name = "Xiaomi Mi Notebook Air 13.3 JYU4052CN", CatalogID=2 },
                       new Product { Id = 12, Name = "Xiaomi Redmi G JYU4313CN", CatalogID=2 },
                       new Product { Id = 13, Name = "Xiaomi MiJia 360° Sphere Panoramic Camera", CatalogID=3 },
                       new Product { Id = 14, Name = "Xiaomi Mi Home Security Camera 1080p Magnetic Mount", CatalogID=3 },
                       new Product { Id = 15, Name = "Xiaomi MiJia 360°", CatalogID=3 },
                       new Product { Id = 16, Name = "Xiaomi Mi Home Security Camera Basic", CatalogID=3 },
                       new Product { Id = 17, Name = "Xiaomi Dafang PTZ 1080p", CatalogID=3 },
                       new Product { Id = 18, Name = "Xiaomi XiaoFang 1080p", CatalogID=3 },
                       new Product { Id = 19, Name = "Xiaomi Mi True Wireless Earbuds Basic 2 TWSEJ061LS°", CatalogID=4 },
                       new Product { Id = 20, Name = "Xiaomi Mi True Wireless Earphones Lite TWSEJ03WM", CatalogID=4 },
                       new Product { Id = 21, Name = "Xiaomi Mi True Wireless Earphones 2 TWSEJ06WM",  CatalogID=4 },
                       new Product { Id = 22, Name = "Xiaomi Mi In-Ear Pro HD", CatalogID=4 },
                       new Product { Id = 23, Name = "Xiaomi Dual Driver Earphones (черный)", CatalogID=4 },
                       new Product { Id = 24, Name = "Xiaomi Mi Sports Bluetooth Earphones YDLYEJ01LM (белый)", CatalogID=4 },
                       new Product { Id = 25, Name = "Xiaomi Mi Bluetooth TDLYEJ01JY", CatalogID=4 }

                });

        }
    }

}
