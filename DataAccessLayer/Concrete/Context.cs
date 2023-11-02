using EntityLayer.Concrete;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=Localhost;database=CoreBlogDBB; integrated security=true");//2 tane ters slaş koy
            optionsBuilder.UseSqlServer("server=LocalHost;database=mvcdata; user id=SA; password=aaBB123;");//2 tane ters slaş koy

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }
        public DbSet<Test> Tests { get; set; }
       


    }
}
