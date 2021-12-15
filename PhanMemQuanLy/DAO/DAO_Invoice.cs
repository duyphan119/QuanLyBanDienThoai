using PhanMemQuanLy.objects;
using PhanMemQuanLy.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class DAO_Invoice
    {
        private SqlConnection cnn;
        private SqlCommand scm;
        private SqlDataReader reader;

        public DAO_Invoice()
        {
            ConnectDatabase cb = new ConnectDatabase();
            cnn = cb.Connect();
        }

        public List<Invoice> getAll()
        {
            DAO_Customer dao_c = new DAO_Customer();
            DAO_Employee dao_e = new DAO_Employee();
            DAO_OrderDetail dao_od = new DAO_OrderDetail();
            List<Invoice> result = new List<Invoice>();
            cnn.Open();
            string query = $"select sohd, ngayhd, manv, makh from hoadon";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                Invoice invoice = new Invoice();
                invoice.id = reader.GetString(0);
                invoice.date = reader.GetDateTime(1);
                invoice.employee = dao_e.getById(reader.GetString(2));
                invoice.customer = dao_c.getById(reader.GetString(3));
                invoice.list = dao_od.getAll(invoice.id);
                result.Add(invoice);
            }
            cnn.Close();
            return result;
        }

        public Invoice getById(string id)
        {
            DAO_Customer dao_c = new DAO_Customer();
            DAO_Employee dao_e = new DAO_Employee();
            DAO_OrderDetail dao_od = new DAO_OrderDetail();
            cnn.Open();
            string query = $"select sohd, ngayhd, manv, makh from hoadon where sohd = '{id}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            if (reader.Read())
            {
                Invoice invoice = new Invoice();
                invoice.id = reader.GetString(0);
                invoice.date = reader.GetDateTime(1);
                invoice.employee = dao_e.getById(reader.GetString(2));
                invoice.customer = dao_c.getById(reader.GetString(3));
                invoice.list = dao_od.getAll(invoice.id);
                cnn.Close();
                return invoice;
            }
            cnn.Close();
            return null;
        }

        public void insertOne(Invoice invoice)
        {
            cnn.Open();
            string query = $"execute sp_ThemHoaDon '{invoice.id}','{invoice.date}','{invoice.employee.id}','{invoice.customer.id}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void updateOne(Invoice invoice)
        {
            cnn.Open();
            string query = $"execute sp_CapNhatHoaDon '{invoice.id}','{invoice.date}','{invoice.employee.id}','{invoice.customer.id}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void deleteOne(string id)
        {
            cnn.Open();
            string query = $"execute sp_XoaHoaDon '{id}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        internal string generateID(int length)
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
