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
    public class RoleRepository : IRoleRepository
    {
        public Role Add(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task<Role> AddAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<Role> entities)
        {
            throw new NotImplementedException();
        }

        public Role Get(Expression<Func<Role, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll(Expression<Func<Role, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Role Update(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task<Role> UpdateAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Role>> UpdateRange(List<Role> entities)
        {
            throw new NotImplementedException();
        }
    }
}
