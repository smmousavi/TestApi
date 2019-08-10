using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Models;

namespace TestAPI.Service
{
    public class StudentService : IService.IStudentService
    {

        private readonly DataSource.IStudentDataSource _dataSource;

        public StudentService(DataSource.IStudentDataSource dataSource)
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
