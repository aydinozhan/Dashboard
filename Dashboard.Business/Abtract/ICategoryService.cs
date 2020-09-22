using Dashboard.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Business.Abtract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        int GetIdByName(string categoryName);
    }
}
