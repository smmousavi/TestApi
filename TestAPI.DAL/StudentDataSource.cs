using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Core.DataSource;
using TestAPI.Core.Model;

namespace TestAPI.DAL
{
    public class StudentDataSource : IStudentDataSource
    {

        private List<Student> students = null;

        public StudentDataSource()
        {
            students = new List<Student>();

            students.Add(new Student { Id = 1, FirstName = "Hamid", LastName = "Ghods" });
            students.Add(new Student { Id = 2, FirstName = "Mostafa", LastName = "Mousavi" });
            students.Add(new Student { Id = 3, FirstName = "Reza", LastName = "Ektefa" });
            students.Add(new Student { Id = 4, FirstName = "Ali", LastName = "Alavi" });
        }

        public Student Get(int id)
        {
            return students[id - 1];
        }

        public List<Student> Get()
        {
            return students;
        }

        public Student Add(Student model)
        {
            students.Add(model);

            return Get(model.Id);
        }
    }
}
