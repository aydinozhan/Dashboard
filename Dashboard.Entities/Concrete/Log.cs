using Dashboard.Entities.Abtract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Entities.Concrete
{
    public class Log:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastState { get; set; }
        public DateTime LastDate { get; set; }
        public string State { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int Shift { get; set; }
    }
}
