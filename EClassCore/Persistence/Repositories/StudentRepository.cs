using EClassCore.Core.Models;
using EClassCore.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClassCore.Persistence.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public IEnumerable<Student> AllStudents()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}
