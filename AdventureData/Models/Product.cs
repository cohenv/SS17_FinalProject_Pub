using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureData.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public float StandardCost { get; set; }
        public float ListPrice { get; set; }
        public string Size { get; set; }
        public float weight { get; set; }
        public int ProductCategoryID { get; set; }
        public int ProductModelID { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime SellEndDate { get; set; }
        public DateTime DiscontinuedDate { get; set; }
        public byte[] ThumbnailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
