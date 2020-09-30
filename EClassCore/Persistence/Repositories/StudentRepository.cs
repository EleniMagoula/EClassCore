using EClassCore.Core.Models;
using EClassCore.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClassCore.Persistence.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> AllStudents()
        {
            return _context.Students.Include(s => s.Subjects);
        }

        public Student GetStudentById(int studentId)
        {
            return _context.Students.FirstOrDefault(s => s.Id == studentId);
        }
    }
}
