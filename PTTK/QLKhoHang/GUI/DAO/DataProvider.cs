using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DAO
{
    public class DataProvider
    {
        private static string _connectionString;

        public static string ConnectionString
        {
            get { return MakeString(); }
            set { _connectionString = value; }
        }
        //@"Data Source=THIEUQUANG\SQLEXPRESS;Initial Catalog=QLKhoHang;Integrated Security=True"
        private static List<string> ReadTextConnection()
        {
            List<string> str = new List<string>();
            try
            {
                string currentpath = Directory.GetCurrentDirectory().ToString();
                string dir = Directory.GetParent(currentpath).ToString();
                for (int i = 0; i < 2; i++)                
                    dir = Directory.GetParent(dir).ToString();                                
                dir+=@"\ConnectText.txt";
                StreamReader reader = new StreamReader(dir);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    str.Add(line);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }                        
            return str;
        }

        private static string MakeString()
        {
            string strConn;
            List<string> lst = new List<string>();
            lst = ReadTextConnection();
            if(lst.Count<=2)
            {
                strConn = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", lst[0], lst[1]);
            }
            else
            {
                strConn = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=SSPI;User ID={2};Password={3};",lst[0],lst[1],lst[2],lst[3]);
            }
            return strConn;
        }
        //ExecuteNoneQuery
        public static bool ExecuteNoneQuery(String spName, List<SqlParameter> sqlParams)
        {
            //Kết nối Database
            SqlConnection connect = new SqlConnection(ConnectionString);
            connect.Open();

            //Tạo câu truy vấn
            SqlCommand command = connect.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = spName;
            if (sqlParams != null)
            {
                foreach (SqlParameter param in sqlParams)
                {
                    command.Parameters.Add(param);
                }
            }

            //Thực thi câu truy vấn và nhận kết quả
            int res = command.ExecuteNonQuery();

            //Đóng kết nối Database
            connect.Close();

            if (res >= 0)
                return true;
            else
                return false;
        }

        public static bool ExecuteNoneQuery(String spName)
        {
            return ExecuteNoneQuery(spName, null);
        }

        //ExecuteReader
        //ExecuteReader
        public static DataTable ExecuteReader(String spName, List<SqlParameter> sqlParams)
        {
            //Kết nối Database
            SqlConnection connect = new SqlConnection(ConnectionString);
            connect.Open();

            //Tạo câu truy vấn
            SqlCommand command = connect.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = spName;
            if (sqlParams != null)
            {
                foreach (SqlParameter param in sqlParams)
                {
                    command.Parameters.Add(param);
                }
            }

            //Thực thi câu truy vấn và nhận kết quả
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            //Đóng kết nối Database
            connect.Close();
            return dt;
        }

        public static DataTable ExecuteReader(String spName)
        {
            return ExecuteReader(spName, null);
        }


        //ExecuteScalar
        public static object ExecuteScalar(String spName, List<SqlParameter> sqlParams)
        {
            //Kết nối Database
            SqlConnection connect = new SqlConnection(ConnectionString);
            connect.Open();

            //Tạo câu truy vấn
            SqlCommand command = connect.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = spName;
            if (sqlParams != null)
            {
                foreach (SqlParameter param in sqlParams)
                {
                    command.Parameters.Add(param);
                }
            }

            //Thực thi câu truy vấn và nhận kết quả
            object res = command.ExecuteScalar();

            //Đóng kết nối Database
            connect.Close();
            return res;
        }

        public static object ExecuteScalar(String spName)
        {
            return ExecuteScalar(spName, null);
        }
    }
}
