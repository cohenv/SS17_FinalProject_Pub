using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureData.Models
{
    class ProductModelProductDescription
    {
        public int ProductModelID { get; set; }
        public int ProductDescriptionID { get; set; }
        public string Culture { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
