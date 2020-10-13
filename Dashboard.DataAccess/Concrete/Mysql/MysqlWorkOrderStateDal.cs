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
        public void Add(WorkOrderState workOrderState ,Machine machine)
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
            List<WorkOrderState> workOrderStateList = new List<WorkOrderState>();
            return workOrderStateList;
        }
    }
}
