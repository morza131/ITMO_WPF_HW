using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    public enum ProductType
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductPicturePath { get; set; }
        public int Price { get; set; }
        public ProductType ProductType { get; set;}

    }
}
