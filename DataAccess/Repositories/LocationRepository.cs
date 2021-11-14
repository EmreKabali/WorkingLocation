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
    public class LocationRepository : ILocationRepository
    {
        public Location Add(Location entity)
        {
            throw new NotImplementedException();
        }

        public Task<Location> AddAsync(Location entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Location entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Location entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<Location> entities)
        {
            throw new NotImplementedException();
        }

        public Location Get(Expression<Func<Location, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Location> GetAll(Expression<Func<Location, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Location Update(Location entity)
        {
            throw new NotImplementedException();
        }

        public Task<Location> UpdateAsync(Location entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Location>> UpdateRange(List<Location> entities)
        {
            throw new NotImplementedException();
        }
    }
}
