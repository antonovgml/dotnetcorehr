using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webhr.Models;

namespace webhr.Models
{
    public class HRContext : DbContext
    {
        public HRContext (DbContextOptions<HRContext> options)
            : base(options)
        {
        }

        public DbSet<webhr.Models.Person> Persons { get; set; }

        public DbSet<webhr.Models.Department> Departments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Department>().ToTable("Department");
        }

    }




}
