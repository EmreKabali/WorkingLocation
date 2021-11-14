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
    public class WorkLogRepository : IWorkLogRepository
    {
        public WorkLog Add(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public Task<WorkLog> AddAsync(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<WorkLog> entities)
        {
            throw new NotImplementedException();
        }

        public WorkLog Get(Expression<Func<WorkLog, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<WorkLog> GetAll(Expression<Func<WorkLog, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public WorkLog Update(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public Task<WorkLog> UpdateAsync(WorkLog entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkLog>> UpdateRange(List<WorkLog> entities)
        {
            throw new NotImplementedException();
        }
    }
}
