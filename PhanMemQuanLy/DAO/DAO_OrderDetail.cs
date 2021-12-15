using PhanMemQuanLy.objects;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class DAO_OrderDetail
    {
        private SqlConnection cnn;
        private SqlCommand scm;
        private SqlDataReader reader;

        public DAO_OrderDetail()
        {
            ConnectDatabase cb = new ConnectDatabase();
            cnn = cb.Connect();
        }

        public List<OrderDetail> getAll(string invoiceID)
        {
            List<OrderDetail> result = new List<OrderDetail>();
            cnn.Open();
            DAO_ProductDetail dao_pd = new DAO_ProductDetail();
            string query = $"select mact, soluong from chitiethoadon where sohd = '{invoiceID}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.detail = dao_pd.getById(reader.GetString(0));
                orderDetail.quantity = reader.GetInt32(1);
                result.Add(orderDetail);
            }
            cnn.Close();
            return result;
        }

        public OrderDetail getById(string invoiceID, string productID)
        {
            OrderDetail result = new OrderDetail();
            cnn.Open();

            cnn.Close();
            return result;
        }

        public void insertOne(OrderDetail orderDetail)
        {
            cnn.Open();

            cnn.Close();
        }

        public void updateOne(OrderDetail orderDetail)
        {
            cnn.Open();

            cnn.Close();
        }

        public void deleteOne(string id)
        {
            cnn.Open();

            cnn.Close();
        }

        public int getTotal(OrderDetail orderDetail)
        {
            int result = 0;

            return result;
        }
    }
}
