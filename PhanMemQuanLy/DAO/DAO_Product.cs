using PhanMemQuanLy.objects;
using PhanMemQuanLy.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class DAO_Product
    {
        private SqlConnection cnn;
        private SqlCommand scm;
        private SqlDataReader reader;

        public DAO_Product()
        {
            ConnectDatabase cb = new ConnectDatabase();
            cnn = cb.Connect();
        }

        public List<Product> getAll()
        {
            List<Product> result = new List<Product>();
            cnn.Open();
            DAO_GroupProduct dao_g = new DAO_GroupProduct();
            DAO_ProductImage dao_img = new DAO_ProductImage();
            DAO_ProductDetail dao_pd = new DAO_ProductDetail();
            string query = "select masp, tensp, mahieu from sanpham";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.id = reader.GetString(0);
                product.name = reader.GetString(1);
                product.group = dao_g.getById(reader.GetString(2));
                product.images = dao_img.getAll(product.id);
                product.details = dao_pd.getAll(product.id);
                result.Add(product);
            }
            cnn.Close();
            return result;
        }

        public List<Product> getByGroup(string groupId)
        {
            List<Product> result = new List<Product>();
            cnn.Open();
            DAO_GroupProduct dao_g = new DAO_GroupProduct();
            DAO_ProductImage dao_img = new DAO_ProductImage();
            DAO_ProductDetail dao_pd = new DAO_ProductDetail();
            string query = $"select masp, tensp, mahieu from sanpham where mahieu = '{groupId}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.id = reader.GetString(0);
                product.name = reader.GetString(1);
                product.group = dao_g.getById(reader.GetString(2));
                product.images = dao_img.getAll(product.id);
                product.details = dao_pd.getAll(product.id);
                result.Add(product);
            }
            cnn.Close();
            return result;
        }

        public Product getById(string id)
        {
            cnn.Open();
            DAO_GroupProduct dao_g = new DAO_GroupProduct();
            DAO_ProductImage dao_img = new DAO_ProductImage();
            DAO_ProductDetail dao_pd = new DAO_ProductDetail();
            string query = $"select masp, tensp, mahieu from sanpham where masp = '{id}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            if (reader.Read())
            {
                Product product = new Product();
                product.id = reader.GetString(0);
                product.name = reader.GetString(1);
                product.group = dao_g.getById(reader.GetString(2));
                product.images = dao_img.getAll(product.id);
                product.details = dao_pd.getAll(product.id);
                cnn.Close();
                return product;
            }
            cnn.Close();
            return null;
        }

        public void insertOne(Product product)
        {
            DAO_ProductImage dao_img = new DAO_ProductImage();
            DAO_ProductDetail dao_pd = new DAO_ProductDetail();
            cnn.Open();
            scm = new SqlCommand($"execute sp_ThemSanPham '{product.id}', N'{product.name}', '{product.group.id}'", cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
            product.images.ForEach(image =>
            {
                dao_img.insertOne(product.id, image);
            });
            product.details.ForEach(detail =>
            {
                dao_pd.insertOne(product.id, detail);
            });
        }

        public void updateOne(Product product)
        {
            DAO_ProductImage dao_img = new DAO_ProductImage();
            DAO_ProductDetail dao_pd = new DAO_ProductDetail();
            dao_img.deleteAll(product.id);
            dao_pd.deleteAll(product.id);
            cnn.Open();
            scm = new SqlCommand($"execute sp_CapNhatSanPham '{product.id}', N'{product.name}', '{product.group.id}'", cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
            product.images.ForEach(image =>
            {
                dao_img.insertOne(product.id, image);
            });
            product.details.ForEach(detail =>
            {
                dao_pd.insertOne(product.id, detail);
            });
        }

        public void deleteOne(string id)
        {
            cnn.Open();
            scm = new SqlCommand($"execute sp_XoaSanPham '{id}'", cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public List<Product> searchByName(string keyword)
        {
            List<Product> result = new List<Product>();
            cnn.Open();
            DAO_GroupProduct dao_g = new DAO_GroupProduct();
            DAO_ProductImage dao_img = new DAO_ProductImage();
            DAO_ProductDetail dao_pd = new DAO_ProductDetail();
            string query = $"select masp, tensp, mahieu from sanpham where tensp like N'%{keyword}%'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.id = reader.GetString(0);
                product.name = reader.GetString(1);
                product.group = dao_g.getById(reader.GetString(2));
                product.images = dao_img.getAll(product.id);
                product.details = dao_pd.getAll(product.id);
                result.Add(product);
            }
            cnn.Close();
            return result;
        }

        public Product getByDetail(string detailId)
        {
            cnn.Open();
            DAO_GroupProduct dao_g = new DAO_GroupProduct();
            DAO_ProductImage dao_img = new DAO_ProductImage();
            DAO_ProductDetail dao_pd = new DAO_ProductDetail();
            string query = $"select sp.masp, sp.tensp, sp.mahieu from chitietsanpham ct,sanpham sp where ct.masp = sp.masp and mact = '{detailId}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.id = reader.GetString(0);
                product.name = reader.GetString(1);
                product.group = dao_g.getById(reader.GetString(2));
                product.images = dao_img.getAll(product.id);
                product.details = dao_pd.getAll(product.id);
                cnn.Close();
                return product;
            }
            cnn.Close();
            return null;
        }

        public string generateID(int length)
        {
            string result = "";
            MyMethods myMethods = new MyMethods();
            string generatedString = DateTime.Now.Year.ToString().Substring(2, 2);
            int i = 1;
            string id = generatedString + myMethods.addZeros(length, i);
            while (true)
            {
                if (getById(id) == null)
                {
                    result = id;
                    break;
                }
                else
                {
                    id = generatedString + myMethods.addZeros(length, ++i);
                }
            }
            return result;
        }
    }
}
