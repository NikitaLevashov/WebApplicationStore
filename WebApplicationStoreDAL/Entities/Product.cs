using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationStoreWEB;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationStoreDAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CatalogID { get; set; }

        [ForeignKey("CatalogID")]
        public Catalog Catalog { get; set; }
        

       
    }
}
