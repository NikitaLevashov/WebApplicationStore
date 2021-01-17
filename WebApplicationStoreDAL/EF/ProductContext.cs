using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationStoreDAL.Entities;
using WebApplicationStoreWEB;

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
        public void AddCascadingObject(object rootEntity) //Place inside DbContext.cs
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
           //Catalog mobilePhone = new Catalog() { Name = "Mobile phone", Id = 1 };
           // Catalog notebook = new Catalog() { Name = "Notebook", Id = 2 };
           // Catalog camera = new Catalog() { Name = "Camera", Id = 3 };
           // Catalog headphones = new Catalog() { Name = "Headphones", Id = 4 };

            modelBuilder.Entity<Product>().HasData(
                new Product[]
                {
                       new Product { Id = 1, Name = "Xiaomi Redmi Note 8", /*Catalog = mobilePhone,*/ CatalogID = 1},
                       new Product { Id = 2, Name = "Xiaomi Redmi Note 9 Pro", /*Catalog = mobilePhone,*/CatalogID=1 },
                       new Product { Id = 3, Name = "Xiaomi Redmi 7", /*Catalog = mobilePhone,*/ CatalogID=1},
                       new Product { Id = 4, Name = "Xiaomi Redmi 8", /*Catalog = mobilePhone, */CatalogID=1 },
                       new Product { Id = 5, Name = "Xiaomi Mi Note 10 Lite", /*Catalog = mobilePhone,*/ CatalogID=1 },
                       new Product { Id = 6, Name = "Xiaomi Redmi 9C",/* Catalog = mobilePhone,*/ CatalogID=1 },
                       new Product { Id = 7, Name = "Xiaomi RedmiBook 16 JYU4277CN", /*Catalog = notebook,*/ CatalogID=2 },
                       new Product { Id = 8, Name = "Xiaomi Mi Gaming Laptop Enhanced Edition 2019 JYU4144CN", /*Catalog = notebook, */CatalogID=2},
                       new Product { Id = 9, Name = "Xiaomi Mi Notebook Pro 2020 JYU4222CN", /*Catalog = notebook, */CatalogID=2 },
                       new Product { Id = 10, Name = "Xiaomi RedmiBook 13 Ryzen Edition 2020 JYU4251CN", /*Catalog = notebook,*/ CatalogID=2 },
                       new Product { Id = 11, Name = "Xiaomi Mi Notebook Air 13.3 JYU4052CN", /*Catalog = notebook,*/ CatalogID=2 },
                       new Product { Id = 12, Name = "Xiaomi Redmi G JYU4313CN", /*Catalog = notebook, */CatalogID=2 },
                       new Product { Id = 13, Name = "Xiaomi MiJia 360° Sphere Panoramic Camera", /*Catalog = camera,*/ CatalogID=3 },
                       new Product { Id = 14, Name = "Xiaomi Mi Home Security Camera 1080p Magnetic Mount", /*Catalog = camera,*/ CatalogID=3 },
                       new Product { Id = 15, Name = "Xiaomi MiJia 360°", /*Catalog = camera, */CatalogID=3 },
                       new Product { Id = 16, Name = "Xiaomi Mi Home Security Camera Basic", /*Catalog = camera,*/ CatalogID=3 },
                       new Product { Id = 17, Name = "Xiaomi Dafang PTZ 1080p",/* Catalog = camera,*/ CatalogID=3 },
                       new Product { Id = 18, Name = "Xiaomi XiaoFang 1080p",/* Catalog = camera,*/ CatalogID=3 },
                       new Product { Id = 19, Name = "Xiaomi Mi True Wireless Earbuds Basic 2 TWSEJ061LS°", /*Catalog = headphones,*/ CatalogID=4 },
                       new Product { Id = 20, Name = "Xiaomi Mi True Wireless Earphones Lite TWSEJ03WM", /*Catalog = headphones,*/CatalogID=4 },
                       new Product { Id = 21, Name = "Xiaomi Mi True Wireless Earphones 2 TWSEJ06WM", /*Catalog = headphones,*/ CatalogID=4 },
                       new Product { Id = 22, Name = "Xiaomi Mi In-Ear Pro HD", /*Catalog = headphones, */CatalogID=4 },
                       new Product { Id = 23, Name = "Xiaomi Dual Driver Earphones (черный)", /*Catalog = headphones,*/ CatalogID=4 },
                       new Product { Id = 24, Name = "Xiaomi Mi Sports Bluetooth Earphones YDLYEJ01LM (белый)", /*Catalog = headphones,*/ CatalogID=4 },
                       new Product { Id = 25, Name = "Xiaomi Mi Bluetooth TDLYEJ01JY", /*Catalog = headphones,*/ CatalogID=4 }

                });

            //modelBuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Xiaomi Redmi Note 8", Catalog = mobilePhone });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "Xiaomi Redmi Note 9 Pro", Catalog = mobilePhone });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "Xiaomi Redmi 7", Catalog = mobilePhone });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 4, Name = "Xiaomi Redmi 8", Catalog = mobilePhone });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 5, Name = "Xiaomi Mi Note 10 Lite", Catalog = mobilePhone });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 6, Name = "Xiaomi Redmi 9C", Catalog = mobilePhone });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 7, Name = "Xiaomi RedmiBook 16 JYU4277CN", Catalog = notebook });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 8, Name = "Xiaomi Mi Gaming Laptop Enhanced Edition 2019 JYU4144CN", Catalog = notebook });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 9, Name = "Xiaomi Mi Notebook Pro 2020 JYU4222CN", Catalog = notebook });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 10, Name = "Xiaomi RedmiBook 13 Ryzen Edition 2020 JYU4251CN", Catalog = notebook });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 11, Name = "Xiaomi Mi Notebook Air 13.3 JYU4052CN", Catalog = notebook });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 12, Name = "Xiaomi Redmi G JYU4313CN", Catalog = notebook });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 13, Name = "Xiaomi MiJia 360° Sphere Panoramic Camera", Catalog = camera });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 14, Name = "Xiaomi Mi Home Security Camera 1080p Magnetic Mount", Catalog = camera });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 15, Name = "Xiaomi MiJia 360°", Catalog = camera });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 16, Name = "Xiaomi Mi Home Security Camera Basic", Catalog = camera });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 17, Name = "Xiaomi Dafang PTZ 1080p", Catalog = camera });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 18, Name = "Xiaomi XiaoFang 1080p", Catalog = camera });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 19, Name = "Xiaomi Mi True Wireless Earbuds Basic 2 TWSEJ061LS°", Catalog = headphones });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 20, Name = "Xiaomi Mi True Wireless Earphones Lite TWSEJ03WM", Catalog = headphones });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 21, Name = "Xiaomi Mi True Wireless Earphones 2 TWSEJ06WM", Catalog = headphones });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 22, Name = "Xiaomi Mi In-Ear Pro HD", Catalog = headphones });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 23, Name = "Xiaomi Dual Driver Earphones (черный)", Catalog = headphones });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 24, Name = "Xiaomi Mi Sports Bluetooth Earphones YDLYEJ01LM (белый)", Catalog = headphones });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 25, Name = "Xiaomi Mi Bluetooth TDLYEJ01JY", Catalog = headphones });
        }
    }

}
