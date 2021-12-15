using PhanMemQuanLy.objects;
using PhanMemQuanLy.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class DAO_ProductDetail
    {
        private SqlConnection cnn;
        private SqlCommand scm;
        private SqlDataReader reader;

        public DAO_ProductDetail()
        {
            ConnectDatabase cb = new ConnectDatabase();
            cnn = cb.Connect();
        }

        public List<ProductDetail> getAll(string productId)
        {
            List<ProductDetail> result = new List<ProductDetail>();
            cnn.Open();
            scm = new SqlCommand($"select mact, mausac, bonhotrong, soluong, giaban from chitietsanpham where masp = '{productId}'",cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                ProductDetail pd = new ProductDetail();
                pd.id = reader.GetString(0);
                pd.color = reader.GetString(1);
                pd.memorySpace = reader.GetString(2);
                pd.quantity = reader.GetInt32(3);
                pd.price = reader.GetDecimal(4);
                result.Add(pd);
            }
            cnn.Close();
            return result;
        }

        public ProductDetail getById(string id)
        {
            cnn.Open();
            scm = new SqlCommand($"select mact, mausac, bonhotrong, soluong, giaban from chitietsanpham where mact = '{id}'", cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                ProductDetail pd = new ProductDetail();
                pd.id = reader.GetString(0);
                pd.color = reader.GetString(1);
                pd.memorySpace = reader.GetString(2);
                pd.quantity = reader.GetInt32(3);
                pd.price = reader.GetDecimal(4);
                cnn.Close();
                return pd;
            }
            cnn.Close();
            return null;
        }

        public void insertOne(string productId, ProductDetail pd)
        {
            cnn.Open();
            scm = new SqlCommand($@"execute sp_ThemChiTietSanPham 
              '{pd.id}' , '{productId}',  N'{pd.color}', '{pd.memorySpace}', {pd.quantity}, {pd.price}", cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void updateOne(string productId, ProductDetail pd)
        {
            cnn.Open();
            scm = new SqlCommand($@"execute sp_CapNhatChiTietSanPham 
              '{pd.id}' , '{productId}',  N'{pd.color}', '{pd.memorySpace}', {pd.quantity}, {pd.price}", cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void deleteOne(string id)
        {
            cnn.Open();
            scm = new SqlCommand($"execute sp_XoaChiTietSanPham '{id}'", cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void deleteAll(string productId)
        {
            cnn.Open();
            scm = new SqlCommand($"execute sp_XoaTatCaChiTietSanPham '{productId}'", cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public List<ProductDetail> searchByName(string keyword)
        {
            List<ProductDetail> result = new List<ProductDetail>();

            return result;
        }

        
    }
}
