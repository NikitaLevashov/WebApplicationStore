using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplicationStoreBLL.interfaces;
using WebApplicationStoreDAL.EF;
using WebApplicationStoreDAL.Entities;

namespace WebApplicationStoreDAL.Repositories
{
    public class ProductRepositoryEFCore : IRepositoryGetProduct<Product>
    {
        public IEnumerable<Product> GetProducts(string catalog)
        {
            using (ProductContext db = new ProductContext())
            {
                var query = db.Products.Where(product => product.Catalog.Name == catalog).Select(product => product).ToList();
                                           
                return query;
            }

        }
    }
}
