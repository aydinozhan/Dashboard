using Dashboard.DataAccess.Concrete;
using Dashboard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DataAccess.Abtract
{
    public interface IWorkOrderStateDal : IEntityRepository<WorkOrderState>
    {
        void Add(WorkOrderState workOrderState, Machine machine);
        List<WorkOrderState> GetAllByMachine(Machine machine);
        bool IsWorkOrderFinish(Machine machine, string workOrderNo);
        List<WorkOrderState> GetByWorkOrderNo(Machine machine, string workOderNo);
    }
}
