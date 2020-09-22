using Dashboard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Business.Abtract
{
    public interface ILogService
    {
        List<Log> GetByDate(string ip,string db,string table,string firstDate,string lastDate);
        TimeSpan SpendTime(string ip, string db, string tableName, string day, string state);
        Log GetLast(string ip, string db, string tableName);
        TimeSpan GetSpendTimes(string serverIp, string serverDb, string tableName, string ip, string day);
    }
}
