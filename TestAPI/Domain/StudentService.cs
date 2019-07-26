using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Models;

namespace TestAPI.Service
{
    public class StudentService
    {
        List<Student> students = null;

        public StudentService()
        {
            students = new List<Student>();

            students.Add(new Student { Id = 1, FirstName = "Hamid", LastName = "Ghods"  });
            students.Add(new Student { Id = 1, FirstName = "Mostafa", LastName = "Mousavi"  });
            students.Add(new Student { Id = 1, FirstName = "Reza", LastName = "Ektefa"  });
            students.Add(new Student { Id = 1, FirstName = "Ali", LastName = "Alavi"  });
        }

        public Student Get(int id)
        {
            return students[id - 1];
        }

        public List<Student> Get()
        {
            return students;
        }
    }
}
