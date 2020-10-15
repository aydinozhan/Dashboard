using Dashboard.DataAccess.Concrete;
using Dashboard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Business.Abtract
{
    public interface IWorkOrderStateService
    {
        void Add(WorkOrderState workOrderStat, Machine machine);
        List<WorkOrderState> GetAllByMachine(Machine machine);
        bool IsWorkOrderFinish(Machine machine, string workOrderNo);

        List<WorkOrderState> GetByWorkOrderNo(Machine machine,string workOderNo);
    }
}
