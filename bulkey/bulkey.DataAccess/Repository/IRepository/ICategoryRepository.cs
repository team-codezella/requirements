using bulkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulkey.DataAccess.Repository.IRepository
{
 public interface ICategoryRepository:IRepository<CategoryRepositery>
    {

        void Update (CategoryRepositery obj);
 
    }
}
