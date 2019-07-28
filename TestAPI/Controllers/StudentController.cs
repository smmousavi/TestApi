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
        private Service.StudentService service = null;

        public StudentController()
        {
            service = new Service.StudentService();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Student>> Get()
        {
            return service.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Models.Student> Get(int id)
        {
            return service.Get(id);
        }
    }
}