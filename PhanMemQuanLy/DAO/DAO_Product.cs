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
            string query = "select masp, tensp, mausac, bonhotrong, soluong, giaban, hinhanh, mahieu from sanpham";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    id = reader.GetString(0),
                    name = reader.GetString(1),
                    color = reader.GetString(2),
                    memorySpace = reader.GetString(3),
                    quantity = reader.GetInt32(4),
                    price = reader.GetDecimal(5),
                    image = reader.GetString(6),
                    group = dao_g.getById(reader.GetString(7))
                };
                result.Add(product);
            }
            cnn.Close();
            return result;
        }

        public List<Product> getByName(string name)
        {
            List<Product> result = new List<Product>();
            cnn.Open();
            DAO_GroupProduct dao_g = new DAO_GroupProduct();
            string query = $"select masp, tensp, mausac, bonhotrong, soluong, giaban, hinhanh, mahieu from sanpham where tensp = N'{name}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    id = reader.GetString(0),
                    name = reader.GetString(1),
                    color = reader.GetString(2),
                    memorySpace = reader.GetString(3),
                    quantity = reader.GetInt32(4),
                    price = reader.GetDecimal(5),
                    image = reader.GetString(6),
                    group = dao_g.getById(reader.GetString(7))
                };
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
            string query = $"select masp, tensp, mausac, bonhotrong, soluong, giaban, hinhanh, mahieu from sanpham where mahieu = '{groupId}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    id = reader.GetString(0),
                    name = reader.GetString(1),
                    color = reader.GetString(2),
                    memorySpace = reader.GetString(3),
                    quantity = reader.GetInt32(4),
                    price = reader.GetDecimal(5),
                    image = reader.GetString(6),
                    group = dao_g.getById(reader.GetString(7))
                };
                result.Add(product);
            }
            cnn.Close();
            return result;
        }

        public Product getById(string id)
        {
            cnn.Open();
            DAO_GroupProduct dao_g = new DAO_GroupProduct();
            string query = $"select masp, tensp, mausac, bonhotrong, soluong, giaban, hinhanh, mahieu from sanpham where masp = '{id}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            if (reader.Read())
            {
                Product product = new Product()
                {
                    id = reader.GetString(0),
                    name = reader.GetString(1),
                    color = reader.GetString(2),
                    memorySpace = reader.GetString(3),
                    quantity = reader.GetInt32(4),
                    price = reader.GetDecimal(5),
                    image = reader.GetString(6),
                    group = dao_g.getById(reader.GetString(7))
                };
                cnn.Close();
                return product;
            }
            cnn.Close();
            return null;
        }

        public void insertOne(Product product)
        {
            try
            {
                cnn.Open();
                scm = new SqlCommand($@"execute sp_ThemSanPham '{product.id}', N'{product.name}', 
                '{product.image}', N'{product.color}', '{product.memorySpace}', {product.quantity},
                {product.price}, '{product.group.id}'", cnn);
                scm.ExecuteNonQuery();
                cnn.Close();
            }
            catch(Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
        }

        public void updateOne(Product product)
        {
            try
            {
                cnn.Open();
                scm = new SqlCommand($@"execute sp_CapNhatSanPham '{product.id}', N'{product.name}', 
                '{product.image}', N'{product.color}', '{product.memorySpace}', {product.quantity},
                {product.price}, '{product.group.id}'", cnn);
                scm.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
        }

        public void deleteOne(string id)
        {
            try
            {
                cnn.Open();
                scm = new SqlCommand($"execute sp_XoaSanPham '{id}'", cnn);
                scm.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
        }

        public List<Product> searchByName(string keyword)
        {
            List<Product> result = new List<Product>();
            cnn.Open();
            DAO_GroupProduct dao_g = new DAO_GroupProduct();
            string query = $"select masp, tensp, mausac, bonhotrong, soluong, giaban, hinhanh, mahieu from sanpham where tensp like N'%{keyword}%'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    id = reader.GetString(0),
                    name = reader.GetString(1),
                    color = reader.GetString(2),
                    memorySpace = reader.GetString(3),
                    quantity = reader.GetInt32(4),
                    price = reader.GetDecimal(5),
                    image = reader.GetString(6),
                    group = dao_g.getById(reader.GetString(7))
                };
                result.Add(product);
            }
            cnn.Close();
            return result;
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
