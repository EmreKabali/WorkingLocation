using Core.Configuration;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
   public  class WorkingLocationContext:DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Parameters.ConnectingString);
        }

        public DbSet<User> User { get; set; }
        public DbSet<WorkLogType> WorkLogType { get; set; }
        public DbSet<WorkLog> WorkLog { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Right> Right { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Department> Department { get; set; }

        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<SubMenuItems> SubMenuItems { get; set; }

    }
}
