using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2021_Week1_Lab1
{
    public class ProductModel
    {
        public class Product
        {
            public int ProductId { get; set; }
            public string Description { get; set; }
            public int QuantityInStock { get; set; }
            public float UnitPrice { get; set; }
            public int CategoryID { get; set; }
        }

        public class Supplier 
        {
            public int SupplierID { get; set; }
            public string SupplierName { get; set; }
            public string SupplierAddressLine1 { get; set; }
            public string SupplierAddressLine2 { get; set; }
        }

        public class Category
        {
            public int ID { get; set; }
            public int Description { get; set; }
        }

        public class SupplierProduct
        {
            public int SupplierID { get; set; }
            public int ProductId { get; set; }
            public DateTime DatefirstSupplied { get; set; }

        }
    }
}
