using Dashboard.Business.Abtract;
using Dashboard.DataAccess.Abtract;
using Dashboard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Business.Concrete
{
    public class LogManager : ILogService
    {
        private ILogDal _logDal;
        public LogManager(ILogDal logDal)
        {
            _logDal = logDal;
        }
        public List<Log> GetByDate(string ip, string db, string table, string firstDate, string lastDate)
        {
            return _logDal.GetByDate(ip, db, table,firstDate,lastDate);
        }

        public Log GetLast(string ip, string db, string tableName)
        {
            return _logDal.GetLast(ip,db,tableName);
        }

        public TimeSpan SpendTime(string ip, string db, string tableName, string day, string state)
        {
            return _logDal.SpendTime(ip,db,tableName,day,state);
        }
    }
}
