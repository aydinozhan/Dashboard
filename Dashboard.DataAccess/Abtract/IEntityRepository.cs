using Dashboard.Entities.Abtract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DataAccess.Abtract
{
    public interface IEntityRepository<T> where T:class, IEntity,new()  
    {
        List<T> GetAll();
    }
}
