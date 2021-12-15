using PhanMemQuanLy.objects;
using PhanMemQuanLy.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class DAO_Customer
    {
        private SqlConnection cnn;
        private SqlCommand scm;
        private SqlDataReader reader;

        public DAO_Customer()
        {
            ConnectDatabase cb = new ConnectDatabase();
            cnn = cb.Connect();
        }

        public List<Customer> getAll()
        {
            List<Customer> result = new List<Customer>();
            cnn.Open();
            string query = $@"select makh, tenkh, diachi, sdt from khachhang";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.id = reader.GetString(0);
                customer.name = reader.GetString(1);
                customer.address = reader.GetString(2);
                customer.phone = reader.GetString(3);
                result.Add(customer);
            }
            cnn.Close();
            return result;
        }

        public Customer getById(string id)
        {
            cnn.Open();
            string query = $@"select makh, tenkh, diachi, sdt from khachhang where makh = '{id}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.id = reader.GetString(0);
                customer.name = reader.GetString(1);
                customer.address = reader.GetString(2);
                customer.phone = reader.GetString(3);
                cnn.Close();
                return customer;
            }
            cnn.Close();
            return null;
        }

        public void insertOne(Customer customer)
        {
            cnn.Open();
            string query = $@"execute sp_ThemKhachHang '{customer.id}',N'{customer.name}',N'{customer.address}',{customer.phone}";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void updateOne(Customer customer)
        {
            cnn.Open();
            string query = $@"execute sp_CapNhatKhachHang '{customer.id}',N'{customer.name}',N'{customer.address}',{customer.phone}";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void deleteOne(string id)
        {
            cnn.Open();
            string query = $@"execute sp_XoaKhachHang '{id}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public List<Customer> searchByName(string keyword)
        {
            List<Customer> result = new List<Customer>();
            string query = $@"select makh, tenkh, diachi, sdt from khachhang where tenkh like N'%{keyword}%'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.id = reader.GetString(0);
                customer.name = reader.GetString(1);
                customer.address = reader.GetString(2);
                customer.phone = reader.GetString(3);
                result.Add(customer);
            }
            return result;
        }

        public string generateID(int length)
        {
            string result = "";
            MyMethods myMethods = new MyMethods();
            int i = 1;
            string generatedString = DateTime.Now.Year.ToString().Substring(2, 2);
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
