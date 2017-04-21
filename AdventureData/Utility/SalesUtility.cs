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
   public class SalesUtility : ISalesUtility
    {

        public SalesOrderDetail GetSales(int salesId)
        {
            return new SalesOrderDetail();
        }


        public List<SalesOrderDetail> FindSales(string query)
        {
            List<SalesOrderDetail> colSales = new List<SalesOrderDetail>();

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["AdventureData.Properties.Settings.AdventureWorksLT2012ConnectionString"].ConnectionString;

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM SALESLT.SALESORDERDETAIL WHERE SALESLT.SALESORDERDETAIL.SALESORDERID =" + query;

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    SalesOrderDetail newS = new SalesOrderDetail
                    {
                        SalesOrderDetailID = (reader["SalesOrderDetailID"] == null) ? 0 : (int)reader["SalesOrderDetailID"],
                        OrderQty = (Int16)reader["OrderQty"],
                        ProductID = (reader["ProductID"] == null) ? 0 : (int)reader["ProductID"],
                        UnitPrice = Convert.ToSingle((decimal)reader["UnitPrice"]),
                        UnitPriceDiscount = Convert.ToSingle((decimal)reader["UnitPriceDiscount"]),
                        LineTotal = Convert.ToSingle((decimal)reader["LineTotal"]),
                        SalesOrderID = (reader["SalesOrderID"] == null) ? 0 : (int)reader["SalesOrderID"],
                        rowguid = (reader["rowguid"] == null) ? Guid.Empty : (Guid)reader["rowguid"],
                        ModifiedDate = (DateTime)reader["ModifiedDate"]
                        
                    };

                    colSales.Add(newS);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return colSales;
        }

        public SalesOrderDetail CreateSale(SalesOrderDetail template)
        {
            return new SalesOrderDetail();
        }

        public void UpdateSale(SalesOrderDetail saleToUpdate)
        {

        }

        public void DeleteSale(SalesOrderDetail saleToDelete)
        {

        }
    }
}
