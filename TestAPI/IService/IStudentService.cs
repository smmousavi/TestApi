using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Models;

namespace TestAPI.IService
{
    interface IStudentService
    {
        Student Get(int id);

        List<Student> Get();
    }
}
