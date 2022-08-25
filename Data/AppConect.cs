using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf2.Model;

namespace Wpf2.Data
{
    class AppConect : DbContext
     {
        //public DbSet<Salary> salaries { get; set; }
        //public DbSet<Credits> Credits { get; set; }
        //public DbSet<HomeWarehouse> HomeWarehouse { get; set; }
        //public DbSet<Dish> Dish { get; set; }
        public DbSet<Test> Tests { get; set; }
        public AppConect() : base("DefaultConnection") { }
    }
}
