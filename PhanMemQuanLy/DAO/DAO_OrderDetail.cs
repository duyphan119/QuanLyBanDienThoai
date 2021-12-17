using PhanMemQuanLy.objects;
using System;
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
            DAO_Product dao_p = new DAO_Product();
            string query = $"select masp, soluong from chitiethoadon where sohd = '{invoiceID}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.product = dao_p.getById(reader.GetString(0));
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

        public void insertOne(string invoiceID, OrderDetail orderDetail)
        {
            try
            {
                cnn.Open();
                scm = new SqlCommand($@"execute sp_ThemChiTietHoaDon '{invoiceID}', '{orderDetail.product.id}', {orderDetail.quantity}", cnn);
                scm.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
            
        }

        public void updateOne(string invoiceID, OrderDetail orderDetail)
        {
            try
            {
                cnn.Open();
                scm = new SqlCommand($@"execute sp_CapNhatChiTietHoaDon '{invoiceID}', '{orderDetail.product.id}', {orderDetail.quantity}", cnn);
                scm.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
        }

        public void deleteMany(string invoiceID)
        {
            try
            {
                cnn.Open();
                scm = new SqlCommand($@"execute sp_XoaTatCaChiTietHoaDonCuaHoaDon '{invoiceID}'", cnn);
                scm.ExecuteNonQuery();
                cnn.Close();
            }
            catch(Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
        }

        public void insertMany(string invoiceID, List<OrderDetail> list)
        {
            list.ForEach(od =>
            {
                insertOne(invoiceID, od);
            });
            
        }

        public void deleteOne(string invoiceID, OrderDetail orderDetail)
        {
            try
            {
                cnn.Open();
                scm = new SqlCommand($@"execute sp_XoaChiTietHoaDon '{invoiceID}','{orderDetail.product.id}'", cnn);
                scm.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
        }

        public int getTotal(OrderDetail orderDetail)
        {
            int result = 0;

            return result;
        }
    }
}
