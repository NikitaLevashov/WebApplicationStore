using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationStoreWEB;

namespace WebApplicationStoreDAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Catalog Catalog { get; set; }
       
    }
}
