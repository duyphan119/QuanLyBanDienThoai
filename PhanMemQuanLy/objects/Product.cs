using System.Collections.Generic;

namespace PhanMemQuanLy.objects
{
    public class Product
    {
        public string id;
        public string name, color, memorySpace, image;
        public int quantity;
        public decimal price;
        public Manufacturer group;
        

        public Product()
        {
        }
    }
}
