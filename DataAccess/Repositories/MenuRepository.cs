using Core.DataAccess;
using DataAccess.Contexts;
using DataAccess.Repositories.Interface;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class MenuRepository : EFRepository<MenuItems, WorkingLocationContext>, IMenuRepository
    {
        public List<MenuItems> GetMenuWithSubMenu()
        {
            using (var context=new WorkingLocationContext())
            {
                var query = from mi in context.MenuItems
                            .Include("SubMenuItems")
                            select mi;

                var records = query.ToList();

                return records;
            }
        }
    }
}
