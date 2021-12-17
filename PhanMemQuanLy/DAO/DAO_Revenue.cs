using PhanMemQuanLy.objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PhanMemQuanLy.DAO
{
    public class DAO_Revenue
    {
        private SqlConnection cnn;
        private SqlCommand scm;
        private SqlDataReader reader;

        public DAO_Revenue()
        {
            ConnectDatabase cb = new ConnectDatabase();
            cnn = cb.Connect();
        }

        public List<Revenue> getRevenueDaysOfWeek(DateTime date)
        {
            List<Revenue> result = new List<Revenue>();
            try
            {
                cnn.Open();
                scm = new SqlCommand($"execute sp_DoanhThuCacNgayTrongTuan '{date}'", cnn);
                reader = scm.ExecuteReader();
                while (reader.Read())
                {
                    Revenue re = new Revenue()
                    {
                        time = reader.GetInt32(0),
                        value = reader.GetDecimal(1)
                    };
                    result.Add(re);
                }
                cnn.Close();
            }
            catch(Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
            return result;
        }
    }
}
