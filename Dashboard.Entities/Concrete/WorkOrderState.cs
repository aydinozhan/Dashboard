using Dashboard.Entities.Abtract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Entities.Concrete
{
    public class WorkOrderState:IEntity
    {
        public int Id { get; set; }
        public  string WorkOrderNo { get; set; }
        public string  State { get; set; }
        public DateTime Date { get; set; }
    }
}
