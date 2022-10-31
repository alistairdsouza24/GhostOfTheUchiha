using employeerepositorylayer;
using Microsoft.AspNetCore.Mvc;
using ModeLlayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        private readonly AppContextDB _employeeContext;

        public DesignationController(AppContextDB employeeContext)
        {
            _employeeContext = employeeContext;
        }
        [HttpPost]
        [Route("designation")]
        public IActionResult Designation([FromBody] Designation designation)
        {
            if (!ModelState.IsValid)
                return BadRequest("not a valid request");
            _employeeContext.Employees.Add(designation);
            _employeeContext.SaveChanges();
            return Ok();
        }


        [HttpGet]
        public List<Designation> Get()
        {
            return _employeeContext.Employees.ToList();
            //var data = _employeeContext.employee.Include(c => c.designations).ToList();
            //return Ok(data);
        }
    }
}
