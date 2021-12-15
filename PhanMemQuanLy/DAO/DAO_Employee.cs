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
            cnn.Open();
            string query = $@"select manv, tennv, matkhau, quyen from nhanvien";
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
            cnn.Close();
            return result;
        }

        public Employee getById(string id)
        {
            cnn.Open();
            string query = $@"select manv, tennv, matkhau, quyen from nhanvien where manv = '{id}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            if (reader.Read())
            {
                Employee employee = new Employee();
                employee.id = reader.GetString(0);
                employee.name = reader.GetString(1);
                employee.password = reader.GetString(2);
                employee.permission = reader.GetInt32(3);
                cnn.Close();
                return employee;
            }
            cnn.Close();
            return null;
        }

        public void insertOne(Employee employee)
        {
            cnn.Open();
            string query = $@"execute sp_ThemNhanVien '{employee.id}',N'{employee.name}','{employee.password}',{employee.permission}";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void updateOne(Employee employee)
        {
            cnn.Open();
            string query = $@"execute sp_CapNhatNhanVien '{employee.id}',N'{employee.name}','{employee.password}',{employee.permission}";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void deleteOne(string id)
        {
            cnn.Open();
            string query = $@"execute sp_XoaNhanVien '{id}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public List<Employee> searchByName(string keyword)
        {
            List<Employee> result = new List<Employee>();
            string query = $@"select manv, tennv, matkhau, quyen from nhanvien where tennv like N'%{keyword}%'";
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
