using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using Dapper;
using Infrastructure;
using Test.Core;
using Dapper.Contrib.Extensions;

namespace Test.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        protected readonly IDbConnection _connection = new ConnectionFactory().GetConnection;

        public virtual bool Delete(T t)
        {
            using (_connection)
            {
                _connection.Delete<T>(t);
            }
            throw new NotImplementedException();
        }

        public virtual int Insert(T t)
        {
            using (_connection)
            {
                return (int)_connection.Insert(t);
            }
        }

        public virtual IEnumerable<TResult> ExecuteProc<TResult>(string sql, string @where)
        {
            var p = new DynamicParameters();
            p.Add("@a", 11);
            p.Add("@b", dbType: DbType.Int32, direction: ParameterDirection.Output);
            p.Add("@c", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            _connection.Execute("spMagicProc", p, commandType: CommandType.StoredProcedure);

            int totalCount = p.Get<int>("@b");
            var users = p.Get<TResult>("@c");
            yield return users;
        }

        public virtual IPagedList<T> FindPagedListBase(string sql, string orderBy, string @where = "", object parameters = null, int pageIndex = 0, int pageSize = 20)
        {
            var p = new DynamicParameters();
            p.Add("@Sql", sql);
            p.Add("@Order", orderBy);
            p.Add("@pageIndex", pageIndex);
            p.Add("@pageSize", pageSize);
            p.Add("@TotalCount", dbType: DbType.Int32, direction: ParameterDirection.Output);
            var result = _connection.QueryMultiple("SqlPager", p, commandType: CommandType.StoredProcedure);
            var list = result.Read<T>().ToList(); //p.Get<TResult>("@c");
            int totalCount = p.Get<int>("@TotalCount"); //p.Get<int>("@b");
            var items = new PagedList<T>(list, pageIndex, pageSize, int.Parse(totalCount.ToString()));
            return items;
        }

        public virtual bool Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
