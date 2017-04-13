using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureData.Models
{
    class SalesOrderHeader
    {
        public int SalesOrderID { get; set; }
        public byte RevisionNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ShipDate { get; set; }
        public byte Status { get; set; }
        public byte OnlineOrderFlag { get; set; }
        public string SalesOrderNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string AccountNumber { get; set; }
        public int CustomerID { get; set; }
        public int ShipToAddressID { get; set; }
        public int BillToAddressID { get; set; }
        public string ShipMethod { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public float SubTotal { get; set; }
        public float TaxAmt { get; set; }
        public float Freight { get; set; }
        public float TotalDue { get; set; }
        public string Comment { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
