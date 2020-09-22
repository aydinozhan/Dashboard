using Dashboard.DataAccess.Abtract;
using Dashboard.Entities.Concrete;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DataAccess.Concrete.Mysql
{
    public class MysqlLogDal : ILogDal
    {
        string _serverIp = "172.16.0.221";
        string _serverBackupDb = "Backup";
        MySqlConnection _conn;
        List<Log> _Logs = new List<Log>();
        public List<Log> GetAll()
        {
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", _serverIp, _serverBackupDb);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string table = "KuruAcma1";
                    string query = string.Format("select * from {0} order by Id desc", table);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Log log = new Log
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    LastState = reader.GetString(2),
                                    LastDate = reader.GetDateTime(3),
                                    State = reader.GetString(4),
                                    Date = reader.GetDateTime(5),
                                    Time = reader.GetTimeSpan(6),
                                    Shift = reader.GetInt32(7)
                                };
                                _Logs.Add(log);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("getAllByDate'de sıkıntı var");
            }
            return _Logs;
        }
        public List<Log> GetByDate(string ip,string db,string table,string firstDate,string lastDate)
        {
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1",ip,db);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format( "select * from {0} where Date between '{1} 00:00:00' and '{2} 23:59:59' order by Id desc",table,firstDate,lastDate);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Log log = new Log
                                {
                                    Id=reader.GetInt32(0),
                                    Name=reader.GetString(1),
                                    LastState = reader.GetString(2),
                                    LastDate=reader.GetDateTime(3),
                                    State=reader.GetString(4),
                                    Date = reader.GetDateTime(5),
                                    Time = reader.GetTimeSpan(6),
                                    Shift = reader.GetInt32(7)
                                };
                                _Logs.Add(log);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("getByDate'de sıkıntı var");
            }
            return _Logs;
        }
        public Log GetLast(string ip, string db, string tableName)
        {
            Log log = new Log();
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1",ip,db);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query =string.Format("select State,Date from {0} where (LastState = 'open' and State = 'close') or (LastState = 'close' and State = 'open') order by Id desc limit 1",tableName);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            log.LastState = reader.GetString(0);
                            log.LastDate = reader.GetDateTime(1);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("getLast'da sıkıntı var"+ e);
            }
            return log;
        }

        public TimeSpan GetSpendTimes(string serverIp, string serverDb, string tableName, string ip, string day)
        {
            TimeSpan time = new TimeSpan(0, 0, 0);
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", serverIp, serverDb);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format("select Time from {0} where date = '{1}' and Ip='{2}'", tableName, day, ip);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            if (!reader.IsDBNull(0))
                            {
                                time = reader.GetTimeSpan(0);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return time;
        }

        public TimeSpan SpendTime(string ip, string db,string tableName, string date, string state)
        {
            TimeSpan timeSum = new TimeSpan(0, 0, 0);
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", ip, db);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format("select SEC_TO_TIME(SUM(TIME_TO_SEC(time))) as timeSum from {0} where LastState='{1}' and (date between '{2} 00:00:00' and '{3} 23:59:59')",tableName,state,date,date);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            if (!reader.IsDBNull(0))
                            {
                                timeSum = reader.GetTimeSpan(0);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("SpendTime sıkıntısı \n"+e);
            }
            return timeSum;
        }
    }
}
