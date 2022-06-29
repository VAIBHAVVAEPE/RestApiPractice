using RestApiPractice.Model;
using System.Collections.Generic;

namespace RestApiPractice.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> GetAllProducts();
        int AddProduct(Product prod);
        int ModifyProduct(Product prod);
        int DeleteProduct(int id);

    }
    


}
