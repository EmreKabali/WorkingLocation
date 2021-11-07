using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {

        #region Get
        TEntity Get(Expression<Func<TEntity, bool>> filter = null);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        #endregion
        #region Add

        TEntity Add(TEntity entity);
        Task<TEntity> AddAsync(TEntity entity);
        #endregion

        #region Update

        TEntity Update(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);

        Task<List<TEntity>> UpdateRange(List<TEntity> entities); 
        #endregion

        #region Delete
        //Not hard delete. Status Active=0
        void Delete(TEntity entity);
        void DeleteRange(List<TEntity> entities);
        Task DeleteAsync(TEntity entity); 
        #endregion

    }
}
