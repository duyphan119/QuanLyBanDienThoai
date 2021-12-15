namespace PhanMemQuanLy.objects
{
    public class ProductDetail
    {
        public string id, color, memorySpace;
        public int quantity;
        public decimal price;

        public ProductDetail()
        {
        }

        public ProductDetail(string id, string color, string memorySpace, int quantity, decimal price)
        {
            this.id = id;
            this.color = color;
            this.memorySpace = memorySpace;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
