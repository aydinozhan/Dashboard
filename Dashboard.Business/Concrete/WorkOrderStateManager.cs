using Dashboard.Business.Abtract;
using Dashboard.DataAccess.Abtract;
using Dashboard.DataAccess.Concrete;
using Dashboard.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Business.Concrete
{
    public class WorkOrderStateManager : IWorkOrderStateService
    {
        private IWorkOrderStateDal _workOrderStateDal;
        public WorkOrderStateManager(IWorkOrderStateDal workOrderStateDal)
        {
            _workOrderStateDal = workOrderStateDal;
        }

        public void Add(WorkOrderState workOrderState, Machine machine)
        {
            _workOrderStateDal.Add(workOrderState,machine);
        }
    }
}
