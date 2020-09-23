using Dashboard.Business.Abtract;
using Dashboard.DataAccess.Abtract;
using Dashboard.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Business.Concrete
{
    public class MachineManager : IMachineService
    {
        private IMachineDal _machineDal;
        public MachineManager(IMachineDal machineDal)
        {
            _machineDal = machineDal;
        }

        public void Add(Machine machine)
        {
            _machineDal.Add(machine);
        }

        public void Delete(int id)
        {
            _machineDal.Delete(id);
        }

        public List<Machine> GetAll()
        {
            return _machineDal.GetAll();
        }

        public List<Machine> GetByCategoryId(int categoryId)
        {
            return _machineDal.GetByCategoryId(categoryId);
        }

        public void Update(Machine machine)
        {
            _machineDal.Update(machine);
        }
    }
}
