using System.Collections.Generic;
using AdventureData.Models;

namespace AdventureData.Utility
{
    public interface IProductUtility
    {
        Product CreateProduct(Product template);
        void DeleteProduct(Product productToDelete);
        List<Product> FindProduct(string query);
        Product GetProduct(int productId);
        void UpdateProduct(Product productToUpdate);
    }

}