using System.Collections.Generic;
using AdventureData.Models;

namespace AdventureData
{
    public interface IProductUtility
    {
        Product CreateProduct(Product template);
       

        void DeleteProduct(Product productToDelete);
        public List<Product> FindProduct(string query)
        {
            List<Product> colProducts = new List<Product>();

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Server=(local)\\sqlexpress;Database=AdventureWorksLT2012;Trust_Connection=Trust;";

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM Product";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while(reader.read())
                {
                    Product newP = new Product
                    {
                        Name = (string)reader["Name"],
                        ProductNumber = (string)reader["ProductNumber"],
                        Color = (string)reader["Color"],
                        ListPrice = (float)reader["ListPrice"],
                        ProductID = (int)reader["Id"]
                    };

                    colProducts.Add(newP);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
            return colProducts;
        }
        Product GetProduct(int productId);
        void UpdateProduct(Product productToUpdate);
    }
}