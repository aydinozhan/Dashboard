using Dashboard.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DataAccess.Abtract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        int GetIdByName(string categoryName);
    }
}
