using Dashboard.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DataAccess.Abtract
{
    public interface IMachineDal : IEntityRepository<Machine>
    {
        List<Machine> GetByCategoryId(int categoryId);
    }
}
