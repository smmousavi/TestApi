using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Core.Model;
using TestAPI.Core.Service;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return _service.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public ActionResult<Student> Post(Student model)
        {
            return _service.Add(model);
        }

    }
}