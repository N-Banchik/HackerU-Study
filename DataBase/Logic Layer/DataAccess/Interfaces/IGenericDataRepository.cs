using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
    public interface IGenericDataRepository<T> where T: class 
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetById(int Id);
        Task<bool> Add(T entity);
        Task Delete(int id);
        Task<bool> Upsert(T entity);
        Task<ICollection<T>> GetByCondition(Expression<Func<T, bool>> predicate);
        Task<T> GetOneByCondition(Expression<Func<T, bool>> predicate);
    }
}
