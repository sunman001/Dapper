using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Test.Core;

namespace Test.Repositories
{
    public class UserRepository :  GenericRepository<User>, IUserRepository
    {
        public  IPagedList<User> FindPagedList(string orderBy, string where = "", object parameters = null, int pageIndex = 0, int pageSize = 20)
        {
            string  sql = "select * from jmp_user";
            orderBy = " order by  u_id asc";
            pageIndex = 1;
            pageSize = 20;

            var list = base.FindPagedListBase(sql, orderBy, null, null, pageIndex, pageSize);
            return list;
        }
    }
}
