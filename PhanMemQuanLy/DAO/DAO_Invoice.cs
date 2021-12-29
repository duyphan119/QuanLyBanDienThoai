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
            List<Invoice> result = new List<Invoice>();
            try
            {
                DAO_Customer dao_c = new DAO_Customer();
                DAO_Employee dao_e = new DAO_Employee();
                DAO_OrderDetail dao_od = new DAO_OrderDetail();
                cnn.Open();
                string query = $"execute sp_LayTatCaHoaDon";
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

        public Invoice getById(string id)
        {
            Invoice invoice = null;
            try
            {
                DAO_Customer dao_c = new DAO_Customer();
                DAO_Employee dao_e = new DAO_Employee();
                DAO_OrderDetail dao_od = new DAO_OrderDetail();
                cnn.Open();
                string query = $"execute sp_LayTatCaHoaDonTheoSoHD '{id}'";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                if (reader.Read())
                {
                    invoice = new Invoice();
                    invoice.id = reader.GetString(0);
                    invoice.date = reader.GetDateTime(1);
                    invoice.employee = dao_e.getById(reader.GetString(2));
                    invoice.customer = dao_c.getById(reader.GetString(3));
                    invoice.list = dao_od.getAll(invoice.id);
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
            return invoice;
        }

        public void insertOne(Invoice invoice)
        {
            try
            {
                cnn.Open();
                string query = $"execute sp_ThemHoaDon '{invoice.id}','{invoice.date}','{invoice.employee.id}','{invoice.customer.id}'";
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
            DAO_OrderDetail dao_od = new DAO_OrderDetail();
            invoice.list.ForEach(od =>
            {
                dao_od.insertOne(invoice.id, od);
            });
        }

        public void updateOne(Invoice invoice)
        {
            try
            {
                cnn.Open();
                string query = $"execute sp_CapNhatHoaDon '{invoice.id}','{invoice.date}','{invoice.employee.id}','{invoice.customer.id}'";
                scm = new SqlCommand(query, cnn);
                scm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            DAO_OrderDetail dao_od = new DAO_OrderDetail();
            dao_od.deleteMany(invoice.id);
            invoice.list.ForEach(od =>
            {
                dao_od.insertOne(invoice.id, od);
            });
        }

        public void deleteOne(string id)
        {
            try
            {
                cnn.Open();
                string query = $"execute sp_XoaHoaDon '{id}'";
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
