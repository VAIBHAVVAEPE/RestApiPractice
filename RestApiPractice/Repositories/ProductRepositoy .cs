using RestApiPractice.Entities;
using RestApiPractice.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestApiPractice.Repositories
{
    public class ProductRepositoy : IProductRepositoy
    {
        RepositoriesContext context;
        public ProductRepositoy(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddProduct(Product prod)
        {
            context.Products.Add(prod);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteProduct(int id)
        {
            var prod = context.Products.Where(p => p.Id == id).SingleOrDefault();
            if (prod != null)
            {
                context.Products.Remove(prod);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public int ModifyProduct(Product prod)
        {
            var product = context.Products.Where(p => p.Id == prod.Id).SingleOrDefault();
            if (product != null)
            {
                product.Name = prod.Name;
                product.Price = prod.Price;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
