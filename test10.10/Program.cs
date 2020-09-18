using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test10._10
{
    class SQLHelper
    {
        private readonly static string conString = @"Server=LAPTOP-NA9O9SEF;DataBase=db_EMS;Uid=sa;pwd=123456";
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
            string sqlStr = "select * from tb_PDic where  name like '%C#%'";
            SqlDataReader objDataRead = SQLHelper.GetReader(sqlStr);
            Console.WriteLine("ID\t名称\t金额");
            while (objDataRead.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}", objDataRead["ID"], objDataRead["name"], objDataRead["Money"]);
            }
            objDataRead.Close();//关闭数据库
            Console.ReadKey();
        }
    }
}
