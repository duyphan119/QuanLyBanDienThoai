namespace PhanMemQuanLy.objects
{
    public class OrderDetail
    {
        public Product product;
        public int quantity;

        public OrderDetail()
        {
        }

        public decimal getTotal()
        {
            return product.price * quantity;
        }
    }
}
