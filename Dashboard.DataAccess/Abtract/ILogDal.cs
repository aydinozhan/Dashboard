using Dashboard.DataAccess.Concrete;
using Dashboard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DataAccess.Abtract
{
    public interface ILogDal : IEntityRepository<Log>
    {
        List<Log> GetByDate(string ip, string db, string table, string firstDate, string lastDate);
        TimeSpan SpendTime(string ip, string db, string tableName, string day, string state);
        Log GetLast(string ip, string db, string tableName);
        void Add(Log log,Machine machine);
        TimeSpan GetSpendTimes(string serverIp, string serverDb, string tableName, string ip, string day);
        TimeSpan GetHoursByHours(string ip, string db, string tableName,string state, string day, string hour);
        Log GetLastLog(string ip, string db, string tableName);
        List<Log> GetById(string ip, string db, string table, int startId, int finishId);
    }
}
