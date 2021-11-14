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
    public class TitleRepository : ITitleRepository
    {
        public Title Add(Title entity)
        {
            throw new NotImplementedException();
        }

        public Task<Title> AddAsync(Title entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Title entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Title entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<Title> entities)
        {
            throw new NotImplementedException();
        }

        public Title Get(Expression<Func<Title, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Title> GetAll(Expression<Func<Title, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Title Update(Title entity)
        {
            throw new NotImplementedException();
        }

        public Task<Title> UpdateAsync(Title entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Title>> UpdateRange(List<Title> entities)
        {
            throw new NotImplementedException();
        }
    }
}
