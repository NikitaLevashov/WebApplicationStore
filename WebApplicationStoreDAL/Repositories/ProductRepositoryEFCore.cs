using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplicationStoreBL;
using WebApplicationStoreDAL.EF;
using WebApplicationStoreDAL.Entities;

namespace WebApplicationStoreDAL.Repositories
{
    class ProductRepositoryEFCore : IRepository<Product>
    {
        public IEnumerable<Product> GetProducts(string catalog)
        {
            using (ProductContext db = new ProductContext())
            {
                var query = db.Products.Include(u => u.Catalog.Name==catalog).ToList();
                
                return query;
            }

        }
    }
}
