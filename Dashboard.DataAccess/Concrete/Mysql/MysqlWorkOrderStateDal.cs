using Dashboard.DataAccess.Abtract;
using Dashboard.Entities.Concrete;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dashboard.DataAccess.Concrete.Mysql
{
    public class MysqlWorkOrderStateDal : IWorkOrderStateDal
    {
        private string _raspiDb = "Machine";
        private string _raspiWorkOrderStateTableName = "WorkOrderStates";
        MySqlConnection _conn;
        
        public void Add(WorkOrderState workOrderState , Machine machine)
        {
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1;Allow User Variables=True",machine.Ip,_raspiDb);
            try
            {
                using (MySqlConnection _conn = new MySqlConnection(connString))
                {
                    string query = string.Format("insert into {0} (Id,WorkOrderNo,State) values (@Id,@WorkOrderNo,@State) ",_raspiWorkOrderStateTableName);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        cmd.Parameters.AddWithValue("@Id",workOrderState.Id);
                        cmd.Parameters.AddWithValue("@WorkOrderNo", workOrderState.WorkOrderNo);
                        cmd.Parameters.AddWithValue("@State", workOrderState.State);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("add workorderstate'de sıkıntı var" + e);
            }
        }

        public List<WorkOrderState> GetAll()
        {
            List<WorkOrderState> workOrderStates = new List<WorkOrderState>();
            return workOrderStates;
        }

        public List<WorkOrderState> GetAllByMachine(Machine machine)
        {
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", machine.Ip,_raspiDb);
            List<WorkOrderState> workOrderStates = new List<WorkOrderState>();
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format("select * from {0} order by Id desc", _raspiWorkOrderStateTableName);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                WorkOrderState workOrderState = new WorkOrderState
                                {
                                    Id = reader.GetInt32(0),
                                    WorkOrderNo=reader.GetString(1),
                                    State=reader.GetString(2),
                                    Date=reader.GetDateTime(3)
                                };
                                workOrderStates.Add(workOrderState);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("workorderstate  getAllByMachine'de sıkıntı var\n"+e);
            }
            return workOrderStates;
        }

        public bool IsWorkOrderFinish(Machine machine, string workOrderNo)
        {
            bool isWorkOrderFinish = false;
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", machine.Ip, _raspiDb);
            List<WorkOrderState> workOrderStates = new List<WorkOrderState>();
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format("select * from {0} where WorkOrderNo = '{1}' and State='finish'",_raspiWorkOrderStateTableName,workOrderNo);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    isWorkOrderFinish = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("workorderstate  isworkorderfinish'de sıkıntı var\n" + e);
            }
            return isWorkOrderFinish;
        }

        public List<WorkOrderState> GetByWorkOrderNo(Machine machine, string workOderNo)
        {
            string connString = string.Format("server={0};user=root;database={1};port=3306;password=root;Connection Timeout=1", machine.Ip, _raspiDb);
            List<WorkOrderState> workOrderStates = new List<WorkOrderState>();
            try
            {
                using (_conn = new MySqlConnection(connString))
                {
                    string query = string.Format("select * from {0} where WorkOrderNo='{1}' order by Id desc", _raspiWorkOrderStateTableName,workOderNo);
                    using (MySqlCommand cmd = new MySqlCommand(query, _conn))
                    {
                        _conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                WorkOrderState workOrderState = new WorkOrderState
                                {
                                    Id = reader.GetInt32(0),
                                    WorkOrderNo = reader.GetString(1),
                                    State = reader.GetString(2),
                                    Date = reader.GetDateTime(3)
                                };
                                workOrderStates.Add(workOrderState);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("workorderstate  getAllByMachine'de sıkıntı var\n" + e);
            }
            return workOrderStates;
        }
    }
}
