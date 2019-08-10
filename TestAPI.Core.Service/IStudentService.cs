using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Core.Model;

namespace TestAPI.Core.Service
{
    public interface IStudentService
    {
        Student Get(int id);

        List<Student> Get();
    }
}
