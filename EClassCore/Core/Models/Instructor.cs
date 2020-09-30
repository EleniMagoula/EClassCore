using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClassCore.Core.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
