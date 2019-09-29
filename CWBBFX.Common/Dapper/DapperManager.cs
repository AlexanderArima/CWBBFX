using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace CWBBFX.Common.Dapper
{
    public class DapperManager
    {

        public static string connectionString = string.Format(@"Data Source={0}HotelManage.db;Version=3;", System.AppDomain.CurrentDomain.BaseDirectory);

        private static IDbConnection _instance = null;

        private static object _lock = new object();

        private DapperManager()
        {

        }

        /// <summary>
        /// 连接实例
        /// </summary>
        /// <returns></returns>
        public static IDbConnection GetConnection()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        //连接SQLServer数据库
                        //_instance = new SqlConnection(connectionString);
                        //连接Sqlite数据库
                        _instance = new SQLiteConnection(connectionString);
                    }
                }
            }
            return _instance;
        }
    }
}
