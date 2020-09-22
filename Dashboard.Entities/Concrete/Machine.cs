using Dashboard.Entities.Abtract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DataAccess.Concrete
{
    public class Machine:IEntity
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string MachineName { get; set; }
        public int CategoryId { get; set; }
    }
}
