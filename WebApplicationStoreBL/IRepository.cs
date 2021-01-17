using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplicationStoreBL
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetProducts(string catalog);
    }
}
