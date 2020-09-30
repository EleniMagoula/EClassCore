using EClassCore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClassCore.Core.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> AllStudents();
        Student GetStudentById(int studentId);
    }
}
