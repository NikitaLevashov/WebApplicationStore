using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationStoreWEB;

namespace WebApplicationStoreDAL.Entities
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
