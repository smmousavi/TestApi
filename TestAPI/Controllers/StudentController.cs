using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IService.IStudentService _service;

        public StudentController(IService.IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Student>> Get()
        {
            return _service.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Models.Student> Get(int id)
        {
            return _service.Get(id);
        }
    }
}