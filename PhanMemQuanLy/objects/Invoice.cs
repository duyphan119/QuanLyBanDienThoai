using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLy.objects
{
    public class Invoice
    {
        public string id;
        public DateTime date;
        public Employee employee;
        public Customer customer;
        public List<OrderDetail> list = new List<OrderDetail>();

        public Invoice()
        {
        }

        public Invoice(string id, DateTime date, Employee employee, Customer customer, List<OrderDetail> list)
        {
            this.id = id;
            this.date = date;
            this.employee = employee;
            this.customer = customer;
            this.list = list;
        }

        public decimal getTotal()
        {
            decimal result = 0;
            list.ForEach(item =>
            {
                result += item.getTotal();
            });
            return result;
        }
    }
}
