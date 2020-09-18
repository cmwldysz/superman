using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test10._7
{
    class SQLHelper {
        private readonly static string conString = @"Server=LAPTOP-NA9O9SEF;DataBase=Admin_information;Uid=sa;pwd=123456";
        public static SqlDataReader GetReader(string sql) {
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand(sql,conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader();
            }
            catch (Exception e) {
                conn.Close();
                throw;
            }
            finally {
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎登录XXX系统");
            Console.Write("请输入登录用户：\t");
            string name = Console.ReadLine();
            Console.Write("请输入登录密码：\t");
            string pwd = Console.ReadLine();
            string sqlStr = "select * from information where account='" + name + "' and passwords='" + pwd + "'";


            SqlDataReader objDataRead = SQLHelper.GetReader(sqlStr);
            if (objDataRead.HasRows)
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine("账号密码错误，登录失败！");
            }
            objDataRead.Close();//关闭数据库
            Console.ReadKey();
        }
    }
}
