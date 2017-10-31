using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core
{
    /// <summary>
    /// 分页接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public  interface IPagedList<T>:IList<T>
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        int PageIndex { get; }
        /// <summary>
        /// 分页数量
        /// </summary>
        int PageSize { get; }
        /// <summary>
        /// 总数量
        /// </summary>
        int TotalCount { get; }
        /// <summary>
        /// 是否有上一页
        /// </summary>
        bool HasPreviousPage { get; }
        /// <summary>
        /// 是否有下一页
        /// </summary>
        bool HasNextPage { get; }
    }
}
