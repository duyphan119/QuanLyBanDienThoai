namespace PhanMemQuanLy.objects
{
    public class Customer
    {
        public string id, name, address, phone;

        public Customer() { }

        public Customer(string id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
    }
}
