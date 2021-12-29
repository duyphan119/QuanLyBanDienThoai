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

        public decimal getRevenueOfDate(DateTime date)
        {
            decimal result = 0;

            try
            {
                cnn.Open();
                scm = new SqlCommand($@"
                        declare @doanhthu decimal;
                        execute @doanhthu = sp_DoanhThuCuaNgay { date.Day}, {date.Month}, {date.Year};
                        select @doanhthu", cnn);
                reader = scm.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetDecimal(0);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cnn.Close();
            }

            return result;
        }

        public decimal getRevenueOfMonth(DateTime date)
        {
            decimal result = 0;

            try
            {
                cnn.Open();
                scm = new SqlCommand($@"
                        declare @doanhthu decimal;
                        execute @doanhthu = sp_DoanhThuCuaThang {date.Month}, {date.Year};
                        select @doanhthu", cnn);
                reader = scm.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetDecimal(0);
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

        public int countProductSelledAll()
        {
            int result = 0;

            try
            {
                cnn.Open();
                scm = new SqlCommand($"execute sp_SoLuongSanPhamDaHet", cnn);
                reader = scm.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetInt32(0);
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

        public decimal getRevenueOfYear(DateTime date)
        {
            decimal result = 0;

            try
            {
                cnn.Open();
                scm = new SqlCommand($@"
                        declare @doanhthu decimal;
                        execute @doanhthu = sp_DoanhThuCuaNam {date.Year};
                        select @doanhthu", cnn);
                reader = scm.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetDecimal(0);
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

        public List<Revenue> getRevenueDaysOfMonth(DateTime date)
        {
            List<Revenue> result = new List<Revenue>();
            try
            {
                cnn.Open();
                scm = new SqlCommand($"execute sp_DoanhThuCacNgayTrongThang '{date.Month}', '{date.Year}'", cnn);
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
            catch (Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
            return result;
        }
        public List<Revenue> getRevenueMonthsOfYear(DateTime date)
        {
            List<Revenue> result = new List<Revenue>();
            try
            {
                cnn.Open();
                scm = new SqlCommand($"execute sp_DoanhThuCacThangTrongNam '{date.Year}'", cnn);
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
            catch (Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
            return result;
        }
        public List<Revenue> getRevenueQuartersOfYear(DateTime date)
        {
            List<Revenue> result = new List<Revenue>();
            try
            {
                cnn.Open();
                scm = new SqlCommand($"execute sp_DoanhThuCacQuyTrongNam '{date.Year}'", cnn);
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
            catch (Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
            return result;
        }
        public List<Revenue> getRevenueYears(int num)
        {
            List<Revenue> result = new List<Revenue>();
            try
            {
                cnn.Open();
                scm = new SqlCommand($"execute sp_DoanhThuCacNamGanDay {num}", cnn);
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
            catch (Exception ex)
            {
                cnn.Close();
                Console.WriteLine(ex);
            }
            return result;
        }
    }
}

