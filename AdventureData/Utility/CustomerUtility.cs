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
    public class CustomerUtility : ICustomerUtility
    {
        public Customer GetCustomer(int customerId)
        {
            return new Customer();
        }


        public List<Customer> FindCustomer(string query)
        {
            List<Customer> colCustomer = new List<Customer>();

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureData.Properties.Settings.AdventureWorksLT2012ConnectionString"].ConnectionString;

            SqlCommand cmd = conn.CreateCommand();
            
            cmd.CommandText = "SELECT * FROM SALESLT.CUSTOMER WHERE SALESLT.CUSTOMER.CUSTOMERID =" + query;

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Customer newC = new Customer
                    {
                          Title = (reader["Title"] == null) ? string.Empty : (string)reader["Title"],
                          FirstName = (reader["FirstName"] == null) ? string.Empty : (string)reader["FirstName"],
                          MiddleName = (reader["MiddleName"] == null) ? string.Empty : (string)reader["MiddleName"],
                          LastName = (reader["LastName"] == null) ? string.Empty : (string)reader["LastName"],
                          Suffix = (reader["Suffix"] == DBNull.Value) ? string.Empty : (string)reader["Suffix"],
                          CompanyName = (reader["CompanyName"] == null) ? string.Empty : (string)reader["CompanyName"],
                          SalesPerson = (reader["SalesPerson"] == null) ? string.Empty : (string)reader["SalesPerson"],
                          EmailAddress = (reader["EmailAddress"] == null) ? string.Empty : (string)reader["EmailAddress"],
                          Phone = (reader["Phone"] == null) ? string.Empty : (string)reader["Phone"],
                          PasswordHash = (reader["PasswordHash"] == null) ? string.Empty : (string)reader["PasswordHash"],
                          PasswordSalt = (reader["PasswordSalt"] == null) ? string.Empty : (string)reader["PasswordSalt"],
                          rowguid = (reader["rowguid"] == null) ? Guid.Empty : (Guid)reader["rowguid"],
                          CustomerId = (reader["CustomerId"] == null) ? 0 : (int)reader["CustomerId"]
                    };

                    colCustomer.Add(newC);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return colCustomer;
        }

        public Customer CreateCustomer(Customer template)
        {
            return new Customer();
        }

        public void UpdateCustomer(Customer productToUpdate)
        {

        }

        public void DeleteCustomer(Customer productToDelete)
        {

        }

        

    }
}
