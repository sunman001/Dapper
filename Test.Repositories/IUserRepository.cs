using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core;

namespace Test.Repositories
{
  public   interface IUserRepository:IGenericRepository<User>
    {
        IPagedList<User> FindPagedList(string orderBy, string @where = "", object parameters = null, int pageIndex = 0, int pageSize = 20);
    }
}
