using PhanMemQuanLy.objects;
using PhanMemQuanLy.utils;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class DAO_GroupProduct
    {
        private SqlConnection cnn;
        private SqlCommand scm;
        private SqlDataReader reader;

        public DAO_GroupProduct()
        {
            ConnectDatabase cb = new ConnectDatabase();
            cnn = cb.Connect();
        }

        public List<GroupProduct> getAll()
        {
            List<GroupProduct> result = new List<GroupProduct>();
            cnn.Open();
            string query = "select * from nhanhieu";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                GroupProduct group = new GroupProduct();
                group.id = reader.GetString(0);
                group.name = reader.GetString(1);
                result.Add(group);
            }
            cnn.Close();
            return result;
        }
        public GroupProduct getById(string id)
        {
            cnn.Open();
            string query = $"select * from nhanhieu where mahieu = '{id}'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            if (reader.Read())
            {
                GroupProduct group = new GroupProduct();
                group.id = reader.GetString(0);
                group.name = reader.GetString(1);
                cnn.Close();
                return group;
            }
            cnn.Close();
            return null;
        }

        public void insertOne(GroupProduct group)
        {
            cnn.Open();
            string query = $"execute sp_ThemNhanHieu '{group.id}', '{group.name}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void updateOne(GroupProduct group)
        {
            cnn.Open();
            string query = $"execute sp_CapNhatNhanHieu '{group.id}', '{group.name}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public void deleteOne(string id)
        {
            cnn.Open();
            string query = $"execute sp_XoaNhanHieu '{id}'";
            scm = new SqlCommand(query, cnn);
            scm.ExecuteNonQuery();
            cnn.Close();
        }

        public List<GroupProduct> searchByName(string keyword)
        {
            List<GroupProduct> result = new List<GroupProduct>();
            cnn.Open();
            string query = $"select * from nhanhieu where tenhieu like '%{keyword}%'";
            scm = new SqlCommand(query, cnn);
            reader = scm.ExecuteReader();
            while (reader.Read())
            {
                GroupProduct group = new GroupProduct();
                group.id = reader.GetString(0);
                group.name = reader.GetString(1);
                result.Add(group);
            }
            cnn.Close();
            return result;
        }

        public string generateID(int length)
        {
            string result = "";
            MyMethods myMethods = new MyMethods();
            int i = 1;
            string id = myMethods.addZeros(length, i);
            while (true)
            {
                if (getById(id) == null)
                {
                    result = id;
                    break;
                }
                else
                {
                    id = myMethods.addZeros(length, ++i);
                }
            }
            return result;
        }
    }
}
