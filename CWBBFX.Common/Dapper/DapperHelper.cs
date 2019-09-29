using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace CWBBFX.Common.Dapper
{
    /// <summary>
    /// 增删改查命令
    /// </summary>
    public static class DapperHelper
    {

        /// <summary>
        /// 执行操作语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static int Execute(string sql,object param = null,IDbTransaction transaction = null)
        {
            int count = 0;
            try
            {
                using(IDbConnection conn = new SQLiteConnection(DapperManager.connectionString))
                {
                    lock (_lock)
                    {
                        conn.Open();
                        count = conn.Execute(sql, param, transaction);
                        return count;
                    }
                }
            }
            catch (Exception ex)
            {
                //封装异常处理
                Log4NetHelper.Error("执行Execute方法时出错",ex);
                return -1;
            }
        }

        /// <summary>
        /// 多表操作--事务
        /// </summary>
        /// <param name="trans"></param>
        /// <param name="databaseOption"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public static Tuple<bool, string> ExecuteTransaction(List<Tuple<string, object>> trans, int databaseOption = 1, int? commandTimeout = null)
        {
            if (trans.Count == 0)
            {
                return new Tuple<bool, string>(false, "SQL语句的数量为0!");
            }
            try
            {
                using (IDbConnection conn = new SQLiteConnection(DapperManager.connectionString))
                {
                    conn.Open();
                    //开启事务
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (var tran in trans)
                            {
                                //执行事务
                                conn.Execute(tran.Item1, tran.Item2, transaction, commandTimeout);
                            }
                            //提交事务
                            transaction.Commit();
                            return new Tuple<bool, string>(true, string.Empty);
                        }
                        catch (Exception ex)
                        {
                            Log4NetHelper.Error("执行ExecuteTransaction方法时出错!", ex);
                            transaction.Rollback();
                            return new Tuple<bool, string>(false, ex.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log4NetHelper.Error("执行ExecuteTransaction方法时出错!", ex);
                return new Tuple<bool, string>(false, ex.ToString());
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static T QuerySingle<T>(string sql, object param = null, IDbTransaction transaction = null)
        {
            try
            {
                using(IDbConnection conn = new SQLiteConnection(DapperManager.connectionString))
                {
                    var model = conn.QuerySingle<T>(sql, param, transaction);
                    return model;
                }
            }
            catch (Exception ex)
            {
                Log4NetHelper.Error("执行QuerySingle方法时出错", ex);
                return default(T);
            }
        }

        public static object _lock = new object();

        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static List<T> Query<T>(string sql, object param = null, IDbTransaction transaction = null)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(DapperManager.connectionString))
                {
                    lock (_lock)
                    {
                        conn.Open();
                        var list = conn.Query<T>(sql, param, transaction);
                        return list as List<T>;
                    }
                }
            }
            catch (Exception ex)
            {
                Log4NetHelper.Error("执行Query方法时出错", ex);
                return null;
                //throw new Exception("执行Query方法时出错", ex);
            }
        }
        
        /// <summary>
        /// 单值查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static int ExecuteScalar(string sql, object param = null, IDbTransaction transaction = null)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(DapperManager.connectionString))
                {
                    conn.Open();
                    var obj = conn.ExecuteScalar<int>(sql, param, transaction, 3, CommandType.Text);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                Log4NetHelper.Error("执行ExecuteScalar方法时出错", ex);
                return -1;
            }
        }

    }
}
