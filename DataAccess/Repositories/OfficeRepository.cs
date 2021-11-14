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
    public class OfficeRepository : IOfficeRepository
    {
        public Office Add(Office entity)
        {
            throw new NotImplementedException();
        }

        public Task<Office> AddAsync(Office entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Office entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Office entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<Office> entities)
        {
            throw new NotImplementedException();
        }

        public Office Get(Expression<Func<Office, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Office> GetAll(Expression<Func<Office, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Office Update(Office entity)
        {
            throw new NotImplementedException();
        }

        public Task<Office> UpdateAsync(Office entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Office>> UpdateRange(List<Office> entities)
        {
            throw new NotImplementedException();
        }
    }
}
