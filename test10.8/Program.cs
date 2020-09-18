using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace test10._8
{
    class SQLHelper
    {
        private readonly static string conString = @"Server=LAPTOP-NA9O9SEF;DataBase=Admin_information;Uid=sa;pwd=123456";
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                conn.Close();
                throw;
            }
            finally
            {
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string sqlStr = "select * from information";
            SqlDataReader objDataRead = SQLHelper.GetReader(sqlStr);
            Console.WriteLine("ID\t用户名\t密码\t权限");
            while (objDataRead.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", objDataRead["ID"], objDataRead["account"], objDataRead["passwords"], objDataRead["powers"]);
            }
            objDataRead.Close();//关闭数据库
            Console.ReadKey();
        }
    }
}
