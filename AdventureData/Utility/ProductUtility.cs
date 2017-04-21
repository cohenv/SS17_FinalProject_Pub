using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureData.Models;

namespace AdventureData.Utility
{
    public class ProductUtility : IProductUtility
    {
        public Product GetProduct(int productId)
        {
            Product prodToReturn = null;

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureData.Properties.Settings.AdventureWorksLT2012ConnectionString"].ConnectionString;

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM SALESLT.PRODUCT WHERE SALESLT.PRODUCT.PRODUCTID = @Id";
            cmd.Parameters.AddWithValue("@Id", productId);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

               if (reader.Read())
                {
                    Product newP = new Product
                    {
                        Name = (reader["Name"] == null) ? string.Empty : (string)reader["Name"],
                        ProductNumber = (reader["ProductNumber"] == null) ? string.Empty : (string)reader["ProductNumber"],
                        Color = (reader["Color"] == null) ? string.Empty : (string)reader["Color"],
                        ListPrice = Convert.ToSingle((decimal)reader["ListPrice"]),
                        Size = (reader["Size"] == null) ? string.Empty : (string)reader["Size"],
                        weight = Convert.ToSingle((decimal)reader["weight"]),
                        ProductCategoryID = (reader["ProductCategoryID"] == null) ? 0 : (int)reader["ProductCategoryID"],
                        ProductModelID = (reader["ProductModelID"] == null) ? 0 : (int)reader["ProductModelID"],
                        ProductID = (reader["ProductId"] == null) ? 0 : (int)reader["ProductId"],
                        ThumbnailPhotoFileName = (reader["ThumbnailPhotoFileName"] == null) ? string.Empty : (string)reader["ThumbnailPhotoFileName"],
                        //DiscontinuedDate = (DateTime)(reader["DiscontinuedDate"]),
                        //SellStartDate = (DateTime)(reader["SellStartDate"]),
                        //SellEndDate = (DateTime)(reader["SellEndDate"]),
                        ModifiedDate = (DateTime)(reader["ModifiedDate"])
                    };

                   
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return prodToReturn;
        }


        public List<Product> FindProduct(string query)
        {
            List<Product> colProducts = new List<Product>();

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureData.Properties.Settings.AdventureWorksLT2012ConnectionString"].ConnectionString;

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM SALESLT.PRODUCT WHERE SALESLT.PRODUCT.PRODUCTID =" + query;

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Product newP = new Product
                    {
                        Name = (reader["Name"] == null) ? string.Empty : (string)reader["Name"],
                        ProductNumber = (reader["ProductNumber"] == null) ? string.Empty : (string)reader["ProductNumber"],
                        Color = (reader["Color"] == null) ? string.Empty : (string)reader["Color"],
                        ListPrice = Convert.ToSingle((decimal)reader["ListPrice"]),
                        Size = (reader["Size"] == null) ? string.Empty : (string)reader["Size"],
                        weight = Convert.ToSingle((decimal)reader["weight"]),
                        ProductCategoryID = (reader["ProductCategoryID"] == null) ? 0 : (int)reader["ProductCategoryID"],
                        ProductModelID = (reader["ProductModelID"] == null) ? 0 : (int)reader["ProductModelID"],
                        ProductID = (reader["ProductId"] == null) ? 0 : (int)reader["ProductId"],
                        ThumbnailPhotoFileName = (reader["ThumbnailPhotoFileName"] == null) ? string.Empty : (string)reader["ThumbnailPhotoFileName"],
                        //DiscontinuedDate = (DateTime)(reader["DiscontinuedDate"]),
                        //SellStartDate = (DateTime)(reader["SellStartDate"]),
                        //SellEndDate = (DateTime)(reader["SellEndDate"]),
                        ModifiedDate = (DateTime)(reader["ModifiedDate"])
                     };

                    colProducts.Add(newP);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return colProducts;
        }

        public Product CreateProduct(Product template)
        {
            Product productToReturn;

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureData.Properties.Settings.AdventureWorksLT2012ConnectionString"].ConnectionString;

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"
                               INSERT INTO PRODUCTS
                               (Name, ProductNumber, Color, StandardCost, ListPrice, Size, Weight, SellStartDate, SellEndDate, DiscontinuedDate, ThumbNailPhoto, ThumbnailPhotoFileName, ModifiedDate)
                               VAULES
                               (@Name, @ProductNumber, @ListPrice)
            ";

            cmd.Parameters.AddWithValue("@name", template.Name);
            cmd.Parameters.AddWithValue("@ProductNumber", template.ProductNumber);
            cmd.Parameters.AddWithValue("@ListPrice", template.ListPrice);
            cmd.Parameters.AddWithValue("@ModifiedDate", template.ModifiedDate);

            object objNewProductId;

            try
            {
                cmd.Connection.Open();
                objNewProductId = cmd.ExecuteScalar();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            productToReturn = GetProduct((int)objNewProductId);

            return productToReturn;
        }


        public void UpdateProduct(Product productToUpdate)
        {

        }

        public void DeleteProduct(Product productToDelete)
        {

        }



    }
}
