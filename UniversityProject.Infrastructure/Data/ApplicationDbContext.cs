using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.Domin.Entities;

namespace UniversityProject.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext 
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
       }

        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentSubject> DepartmentSubjects { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
    }
}
