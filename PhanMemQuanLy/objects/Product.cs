using System.Collections.Generic;

namespace PhanMemQuanLy.objects
{
    public class Product
    {
        public string id;
        public string name;
        public GroupProduct group;
        public List<string> images = new List<string>();
        public List<ProductDetail> details = new List<ProductDetail>();

        public Product()
        {
        }

        public Product(string id, string name, GroupProduct group, List<string> images, List<ProductDetail> details)
        {
            this.id = id;
            this.name = name;
            this.group = group;
            this.images = images;
            this.details = details;
        }
    }
}
