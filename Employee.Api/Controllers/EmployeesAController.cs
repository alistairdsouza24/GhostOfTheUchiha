using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesAController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeesAController(IEmployeeService service)
        {
            _service = service;
        }
        // GET: api/<EmployeesAController>
        [HttpGet]
        public ActionResult <List<EmployeeInfo>>Get()
        {
            var Employeedatafromservice = _service.Get();
            return Ok(Employeedatafromservice);
        }

        // GET api/<EmployeesAController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeesAController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeesAController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesAController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
