using Dashboard.DataAccess.Abtract;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DataAccess.Concrete.Mysql
{
    public class MysqlMachineDal : IMachineDal
    {
        MySqlConnection _conn;
        string _serverIp = "172.16.0.221";
        string _serverBackupDb = "Backup";

        public void Add(Machine machine)
        {
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1;Allow User Variables=True", _serverIp,_serverBackupDb);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = "insert into Machines (Ip, MachineName,CategoryId) values (@Ip,@MachineName,@CategoryId) ";  
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        cmd.Parameters.AddWithValue("@Ip", machine.Ip);
                        cmd.Parameters.AddWithValue("@MachineName", machine.MachineName);
                        cmd.Parameters.AddWithValue("@CategoryId", machine.CategoryId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("add machine'de sıkıntı var"+e);
            }
        }

        public void Delete(int id)
        {
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1;Allow User Variables=True", _serverIp, _serverBackupDb);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format("delete from Machines where Id={0}", id);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Silmede sıkıntı var\n" + e);
            }
        }

        public List<Machine> GetAll()
        {
            List<Machine> machines = new List<Machine>();
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1",_serverIp,_serverBackupDb);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = "select * from Machines where MachineName <> 'server'";
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Machine machine = new Machine
                                {
                                    Id = reader.GetInt32(0),
                                    Ip = reader.GetString(1),
                                    MachineName = reader.GetString(2),
                                    CategoryId = reader.GetInt32(3)
                                };
                                machines.Add(machine);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("getAllByDate'de sıkıntı var");
            }
            return machines;
        }

        public List<Machine> GetByCategoryId(int categoryId)
        {
            List<Machine> machines = new List<Machine>();
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", _serverIp, _serverBackupDb);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format("select * from Machines where CategoryId = {0} and MachineName <>  'server' ", categoryId);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Machine machine = new Machine();
                                machine.Id = reader.GetInt32(0);
                                machine.Ip = reader.GetString(1);
                                machine.MachineName = reader.GetString(2);
                                machine.CategoryId = reader.GetInt32(3);
                                machines.Add(machine);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("getByCategoryId'de sıkıntı var"+e);
            }
            return machines;
        }

        public void Update(Machine machine) 
        {
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1;Allow User Variables=True", _serverIp, _serverBackupDb);
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format("update Machines set Id=id,Ip=@newIp,MachineName=@newName,CategoryId=@CategoryId where Id={0}",machine.Id);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        cmd.Parameters.AddWithValue("@id", machine.Id);
                        cmd.Parameters.AddWithValue("@newIp", machine.Ip);
                        cmd.Parameters.AddWithValue("@newName", machine.MachineName);
                        cmd.Parameters.AddWithValue("@CategoryId", machine.CategoryId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("machine update sıkınt var"+e);
            }
        }
    }
}
