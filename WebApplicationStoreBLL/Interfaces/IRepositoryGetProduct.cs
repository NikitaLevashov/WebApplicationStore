using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplicationStoreBLL.interfaces
{
    public interface IRepositoryGetProduct<T> where T: class
    {
        public IEnumerable<T> GetProducts(string catalog);
       
    }
}
