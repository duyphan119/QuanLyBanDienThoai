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
            try
            {
                cnn.Open();
                DAO_Product dao_p = new DAO_Product();
                string query = $"execute sp_LayTatCaChiTietHoaDonCuaHoaDon '{invoiceID}'";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                while (reader.Read())
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.product = dao_p.getById(reader.GetString(0));
                    orderDetail.quantity = reader.GetInt32(1);
                    result.Add(orderDetail);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cnn.Close();
            }
            return result;
        }

        public void insertOne(string invoiceID, OrderDetail orderDetail)
        {
            try
            {
                cnn.Open();
                scm = new SqlCommand($@"execute sp_ThemChiTietHoaDon '{invoiceID}', '{orderDetail.product.id}', {orderDetail.quantity}", cnn);
                scm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cnn.Close();
            }
        }

        public void deleteMany(string invoiceID)
        {
            try
            {
                cnn.Open();
                scm = new SqlCommand($@"execute sp_XoaTatCaChiTietHoaDonCuaHoaDon '{invoiceID}'", cnn);
                scm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
