using PhanMemQuanLy.objects;
using PhanMemQuanLy.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class DAO_Manufacturer
    {
        private SqlConnection cnn;
        private SqlCommand scm;
        private SqlDataReader reader;

        public DAO_Manufacturer()
        {
            ConnectDatabase cb = new ConnectDatabase();
            cnn = cb.Connect();
        }

        public List<Manufacturer> getAll()
        {
            List<Manufacturer> result = new List<Manufacturer>();
            try
            {
                cnn.Open();
                string query = $"execute sp_LayTatCaNhaSanXuat";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                while (reader.Read())
                {
                    Manufacturer group = new Manufacturer();
                    group.id = reader.GetString(0);
                    group.name = reader.GetString(1);
                    result.Add(group);
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

        public Manufacturer getById(string id)
        {
            Manufacturer group = null;
            try
            {
                cnn.Open();
                string query = $"execute sp_LayNhaSanXuatTheoMaNSX '{id}'";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                if (reader.Read())
                {
                    group = new Manufacturer();
                    group.id = reader.GetString(0);
                    group.name = reader.GetString(1);
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
            return group;
        }

        public void insertOne(Manufacturer group)
        {
            try
            {
                cnn.Open();
                string query = $"execute sp_ThemNhaSanXuat '{group.id}', '{group.name}'";
                scm = new SqlCommand(query, cnn);
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

        public void updateOne(Manufacturer group)
        {
            try
            {
                cnn.Open();
                string query = $"execute sp_CapNhatNhaSanXuat '{group.id}', '{group.name}'";
                scm = new SqlCommand(query, cnn);
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
                string query = $"execute sp_XoaNhaSanXuat '{id}'";
                scm = new SqlCommand(query, cnn);
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

        public List<Manufacturer> searchById(string keyword)
        {
            List<Manufacturer> result = new List<Manufacturer>();
            try
            {
                cnn.Open();
                string query = $"execute sp_TimKiemNhaSanXuatTheoMa '{keyword}'";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                while (reader.Read())
                {
                    Manufacturer group = new Manufacturer();
                    group.id = reader.GetString(0);
                    group.name = reader.GetString(1);
                    result.Add(group);
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

        public List<Manufacturer> searchByName(string keyword)
        {
            List<Manufacturer> result = new List<Manufacturer>();
            try
            {
                cnn.Open();
                string query = $"execute sp_TimKiemNhaSanXuatTheoTen '{keyword}'";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                while (reader.Read())
                {
                    Manufacturer group = new Manufacturer();
                    group.id = reader.GetString(0);
                    group.name = reader.GetString(1);
                    result.Add(group);
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
            int i = 1;
            string id = "NSX" + myMethods.addZeros(length, i);
            while (true)
            {
                if (getById(id) == null)
                {
                    result = id;
                    break;
                }
                else
                {
                    id = "NSX" +  myMethods.addZeros(length, ++i);
                }
            }
            return result;
        }
    }
}
