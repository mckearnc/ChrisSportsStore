/*The name of the property specifies the table, 
 * and the type parameter of the DbSet result 
 * specifies the model type that the Entity Framework
 * should use to represent rows in that table. 
 * In this case, the property name is Products and the 
 * type parameter is Product, meaning that the Entity 
 * Framework should use the Product model type to represent 
 * rows in the Products table
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    /*This is the repository class. It implements the IProductsRepository
     * interface and uses an instance of EFDbContext to retrieve data 
     * from the database using the Entity Framework. */

    //Creating the Product Repository
    public class EFProductsRepository : IProductsRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
