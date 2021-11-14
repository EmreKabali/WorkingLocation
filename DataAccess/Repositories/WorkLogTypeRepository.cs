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
    public class WorkLogTypeRepository : IWorkLogTypeRepository
    {
        public WorkLog Add(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public WorkLogType Add(WorkLogType entity)
        {
            throw new NotImplementedException();
        }

        public Task<WorkLog> AddAsync(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public Task<WorkLogType> AddAsync(WorkLogType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WorkLogType entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(WorkLogType entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<WorkLog> entities)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<WorkLogType> entities)
        {
            throw new NotImplementedException();
        }

        public WorkLog Get(Expression<Func<WorkLog, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public WorkLogType Get(Expression<Func<WorkLogType, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<WorkLog> GetAll(Expression<Func<WorkLog, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<WorkLogType> GetAll(Expression<Func<WorkLogType, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public WorkLog Update(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public WorkLogType Update(WorkLogType entity)
        {
            throw new NotImplementedException();
        }

        public Task<WorkLog> UpdateAsync(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public Task<WorkLogType> UpdateAsync(WorkLogType entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkLog>> UpdateRange(List<WorkLog> entities)
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkLogType>> UpdateRange(List<WorkLogType> entities)
        {
            throw new NotImplementedException();
        }
    }
}
