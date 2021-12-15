namespace PhanMemQuanLy.objects
{
    public class OrderDetail
    {
        public ProductDetail detail;
        public int quantity;

        public OrderDetail()
        {
        }

        public OrderDetail(ProductDetail detail, int quantity)
        {
            this.detail = detail;
            this.quantity = quantity;
        }

        public decimal getTotal()
        {
            return detail.price * quantity;
        }
    }
}
