using RestApiPractice.Model;
using System.Collections.Generic;

namespace RestApiPractice.Repositories
{
    public interface IProductRepositoy
    {
        IEnumerable<Product> GetAllProducts();
        int AddProduct(Product prod);
        int ModifyProduct(Product prod);
        int DeleteProduct(int id);
    }

}
