using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace OASystem.IDAL
{
    public interface IDALSever<T> where T : class
    {
        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="Entity"></param>
        void Add(T Entity);
        /// <summary>
        /// 编辑实体
        /// </summary>
        /// <param name="Entity"></param>
        void Edit(T Entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Entity"></param>
        void Del(T Entity);
        /// <summary>
        /// 提交改变 
        /// </summary>
        /// <returns>成功条数</returns>
        int SaveChange();

        /// <summary>
        /// 无分页查询
        /// </summary>
        /// <param name="lamba">Lambda 表达式</param>
        /// <returns></returns>
        IQueryable<T> LoadEntity(Expression<Func<T, bool>> lambda);

        /// <summary>
        /// 分页查询1  适合使用easyui
        /// </summary>
        /// <param name="pageSize">每页记录条数</param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="total">插叙记录总条数</param>
        /// <param name="lambda">lambda表达式</param>
        /// <param name="isDesc">是否是逆序</param>
        /// <param name="orderkey">排序字段</param>
        /// <returns></returns>
        IQueryable<T> LoadEntityByPage1(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> lambda, bool isDesc, string orderkey);

        /// <summary>
        /// 分页查询2 
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="total"></param>
        /// <param name="lambda"></param>
        /// <param name="isDesc"></param>
        /// <param name="orderkey"></param>
        /// <returns></returns>
        IQueryable<T> LoadEntityByPage2(int limit, int offset, out int total, Expression<Func<T, bool>> lambda, bool isDesc, string orderkey);

    }
}
