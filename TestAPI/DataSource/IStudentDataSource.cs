using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Models;

namespace TestAPI.DataSource
{
    public interface IStudentDataSource
    {
        Student Get(int id);

        List<Student> Get();
    }
}
