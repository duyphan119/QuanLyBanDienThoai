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

        public int getQuantity(string productId)
        {
            int result = 0;
            cnn.Open();
            scm = new SqlCommand($@"execute sp_LayTonKhoCuaSanPham '{productId}'", cnn);
            reader = scm.ExecuteReader();
            if (reader.Read())
            {
                result = reader.GetInt32(0);
            }
            cnn.Close();
            return result;
        }
        public List<Product> getAll()
        {
            List<Product> result = new List<Product>();
            cnn.Open();
            DAO_Manufacturer dao_g = new DAO_Manufacturer();
            string query = "execute sp_LayTatCaSanPham";
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
            DAO_Manufacturer dao_g = new DAO_Manufacturer();
            string query = $"execute sp_LayTatCaSanPhamTheoTen N'{name}'";
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
            try
            {
                cnn.Open();
                DAO_Manufacturer dao_g = new DAO_Manufacturer();
                string query = $"execute sp_LayTatCaSanPhamTheoMaNSX '{groupId}'";
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

        public Product getById(string id)
        {
            Product product = null;
            try
            {
                cnn.Open();
                DAO_Manufacturer dao_g = new DAO_Manufacturer();
                string query = $"execute sp_LayTatCaSanPhamTheoMa '{id}'";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                if (reader.Read())
                {
                    product = new Product()
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
            
            return product;
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
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cnn.Close();
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

        public void deleteOne(string id)
        {
            try
            {
                cnn.Open();
                scm = new SqlCommand($"execute sp_XoaSanPham '{id}'", cnn);
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

        public List<Product> searchById(string keyword)
        {
            List<Product> result = new List<Product>();
            try
            {
                cnn.Open();
                DAO_Manufacturer dao_g = new DAO_Manufacturer();
                string query = $"execute sp_TimKiemSanPhamTheoMa '%{keyword}%'";
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

        public List<Product> searchByName(string keyword)
        {
            List<Product> result = new List<Product>();
            try
            {
                cnn.Open();
                DAO_Manufacturer dao_g = new DAO_Manufacturer();
                string query = $"execute sp_TimKiemSanPhamTheoTen N'%{keyword}%'";
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
