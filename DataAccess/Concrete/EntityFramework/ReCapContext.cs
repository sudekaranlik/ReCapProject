using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;DataBase=ReCapProject;Trusted_Connection=true");
        }

        public DbSet<Car> Tbl_Cars { get; set; }
        public DbSet<Brand> Tbl_Brands { get; set; }
        public DbSet<Color> Tbl_Colors { get; set; }
    }
}
