using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityProject.Domin.Abstraction;
using UniversityProject.Domin.Entities;
using UniversityProject.Infrastructure.Data;

namespace UniversityProject.Infrastructure.Repostiories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Student>> GetAllStudentAsync()
        {
            return await _dbContext.Students.AsNoTracking().ToListAsync();
        }
    }
}
