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
    public class DepartmentRepository : IDepartmentRepository
    {
        public Department Add(Department entity)
        {
            throw new NotImplementedException();
        }

        public Task<Department> AddAsync(Department entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Department entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Department entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<Department> entities)
        {
            throw new NotImplementedException();
        }

        public Department Get(Expression<Func<Department, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll(Expression<Func<Department, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Department Update(Department entity)
        {
            throw new NotImplementedException();
        }

        public Task<Department> UpdateAsync(Department entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> UpdateRange(List<Department> entities)
        {
            throw new NotImplementedException();
        }
    }
}
