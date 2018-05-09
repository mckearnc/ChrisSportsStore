using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;


namespace SportsStore.Domain.Abstract
{
    //This interface uses IEnumerable<T> to allow a caller
    //to obtain a sequence of Product objects, without saying 
    //    how or where the data is stored or retrieved.A class
    //    that depends on the IProductRepository interface can 
    //    obtain Product objects without needing to know anything 
    //    about where they are coming from or how the implementation 
    //    class will deliver them.This is the essence of the repository pattern. 
    public interface IProductsRepository{
        IEnumerable<Product> Products { get; }
    }
}