using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Core.DataSource;
using TestAPI.Core.Model;
using TestAPI.Core.Service;

namespace TestAPI.Domain
{
    public class StudentService : IStudentService
    {

        private readonly IStudentDataSource _dataSource;

        public StudentService(IStudentDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public Student Get(int id)
        {
            return _dataSource.Get(id);
        }

        public List<Student> Get()
        {
            return _dataSource.Get();
        }
    }
}
