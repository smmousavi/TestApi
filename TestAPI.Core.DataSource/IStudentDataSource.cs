using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Core.Model;

namespace TestAPI.Core.DataSource
{
    public interface IStudentDataSource
    {
        Student Get(int id);

        List<Student> Get();

        Student Add(Student model);
    }
}
