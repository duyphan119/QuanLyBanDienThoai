using PhanMemQuanLy.objects;
using PhanMemQuanLy.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class DAO_Employee
    {
        private SqlConnection cnn;
        private SqlCommand scm;
        private SqlDataReader reader;

        public DAO_Employee()
        {
            ConnectDatabase cb = new ConnectDatabase();
            cnn = cb.Connect();
        }

        public List<Employee> getAll(){
            List<Employee> result = new List<Employee>();
            try
            {
                cnn.Open();
                string query = $@"execute sp_LayTatCaNhanVien";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.id = reader.GetString(0);
                    employee.name = reader.GetString(1);
                    employee.password = reader.GetString(2);
                    employee.permission = reader.GetInt32(3);
                    result.Add(employee);
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

        public Employee getById(string id)
        {
            Employee employee = null;
            try
            {
                cnn.Open();
                string query = $@"execute sp_LayNhanVienTheoMaNV '{id}'";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                if (reader.Read())
                {
                    employee = new Employee();
                    employee.id = reader.GetString(0);
                    employee.name = reader.GetString(1);
                    employee.password = reader.GetString(2);
                    employee.permission = reader.GetInt32(3);
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
            return employee;
        }

        public void insertOne(Employee employee)
        {
            try
            {
                cnn.Open();
                string query = $@"execute sp_ThemNhanVien '{employee.id}',N'{employee.name}','{employee.password}',{employee.permission}";
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

        public void updateOne(Employee employee)
        {
            try
            {
                cnn.Open();
                string query = $@"execute sp_CapNhatNhanVien '{employee.id}',N'{employee.name}','{employee.password}',{employee.permission}";
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
                string query = $@"execute sp_XoaNhanVien '{id}'";
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

        public List<Employee> searchById(string keyword)
        {
            List<Employee> result = new List<Employee>();
            try
            {
                cnn.Open();
                string query = $@"execute sp_TimKiemNhanVienTheoMa '{keyword}'";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.id = reader.GetString(0);
                    employee.name = reader.GetString(1);
                    employee.password = reader.GetString(2);
                    employee.permission = reader.GetInt32(3);
                    result.Add(employee);
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

        public List<Employee> searchByName(string keyword)
        {
            List<Employee> result = new List<Employee>();
            try
            {
                cnn.Open();
                string query = $@"execute sp_TimKiemNhanVienTheoTen N'{keyword}'";
                scm = new SqlCommand(query, cnn);
                reader = scm.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.id = reader.GetString(0);
                    employee.name = reader.GetString(1);
                    employee.password = reader.GetString(2);
                    employee.permission = reader.GetInt32(3);
                    result.Add(employee);
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
            string id = generatedString + myMethods.addZeros(length,i);
            while (true)
            {
                if(getById(id) == null)
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
