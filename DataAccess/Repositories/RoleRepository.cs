using Core.DataAccess;
using DataAccess.Contexts;
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
    public class RoleRepository : EFRepository<Role, WorkingLocationContext>, IRoleRepository
    {
    }
}
