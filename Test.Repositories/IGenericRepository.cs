using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core;

namespace Test.Repositories
{
    /// <summary>
    /// 基类接口 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class//泛型约束必须是引用类型
    {
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int  Insert(T t);
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool  Update(T t);       
        bool Delete(T t);

     




    }

}
