using System.Collections.Generic;
using AdventureData.Models;

namespace AdventureData.Utility
{
    interface ISalesUtility
    {
        SalesOrderDetail CreateSale(SalesOrderDetail template);
        void DeleteSale(SalesOrderDetail saleToDelete);
        List<SalesOrderDetail> FindSales(string query);
        SalesOrderDetail GetSales(int salesId);
        void UpdateSale(SalesOrderDetail saleToUpdate);
    }
}