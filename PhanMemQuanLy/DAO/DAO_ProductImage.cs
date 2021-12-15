using PhanMemQuanLy.objects;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class DAO_ProductImage
    {
        private SqlConnection cnn;
        private SqlCommand scm;
        private SqlDataReader reader;

        public DAO_ProductImage()
        {
            ConnectDatabase cb = new ConnectDatabase();
            cnn = cb.Connect();
        }

        public List<string> getAll(string id)
        {
            List<string> result = new List<string>();
            cnn.Open();
            string query = $"select hinhanh from hinhanhsanpham where masp = '{id}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader.GetString(0));
            }
            cnn.Close();
            return result;
        }

        public Product getById(string id)
        {
            Product result = new Product();
            cnn.Open();

            cnn.Close();
            return result;
        }

        public void insertOne(string productId, string image)
        {
            cnn.Open();
            string query = $@"execute sp_ThemHinhAnhSanPham '{productId}','{image}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void updateOne(string productId, string image)
        {
            cnn.Open();
            
            cnn.Close();
        }

        public void deleteOne(string productId, string image)
        {
            cnn.Open();
            string query = $@"execute sp_XoaHinhAnhSanPham '{productId}','{image}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void deleteAll(string productId)
        {
            cnn.Open();
            string query = $@"execute sp_XoaTatCaHinhAnhSanPham '{productId}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public List<Product> searchByName(string keyword)
        {
            List<Product> result = new List<Product>();

            return result;
        }
    }
}
