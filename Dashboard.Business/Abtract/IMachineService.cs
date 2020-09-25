using Dashboard.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Business.Abtract
{
    public interface IMachineService
    {
        /// <returns>
        /// It returns all machine.
        /// </returns>
        List<Machine> GetAll();
        List<Machine> GetByCategoryId(int categoryId);
        void Add(Machine machine);
        void Delete(int id);
        void Update(Machine machine);
    }
}
