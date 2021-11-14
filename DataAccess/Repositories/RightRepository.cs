using DataAccess.Repositories.Interface;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RightRepository : IRightRepository
    {
        public Right Add(Right entity)
        {
            throw new NotImplementedException();
        }

        public Task<Right> AddAsync(Right entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Right entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Right entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<Right> entities)
        {
            throw new NotImplementedException();
        }

        public Right Get(Expression<Func<Right, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Right> GetAll(Expression<Func<Right, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Right Update(Right entity)
        {
            throw new NotImplementedException();
        }

        public Task<Right> UpdateAsync(Right entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Right>> UpdateRange(List<Right> entities)
        {
            throw new NotImplementedException();
        }
    }
}
