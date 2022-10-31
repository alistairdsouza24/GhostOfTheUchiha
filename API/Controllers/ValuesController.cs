using employeeBuisnesslogic.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modellayer;
using ModeLlayer;
using projtrial.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEmployeeInterface _emp;
        public ValuesController(IEmployeeInterface emp)
        {
            _emp = emp;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        [Route("get")]
      //  [Authorize]
        public ActionResult<List<Adduserdetails>> Get()
        {

            return _emp.Get();

        }
        [HttpGet]
        [Route("get/{username}")]
        public ActionResult<Adduserdetails> Get(string username)
        {
            return _emp.Get(username);
        }
        /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        */
        // POST api/<ValuesController>

        [HttpPost("Post")]

        public IActionResult Post([FromBody] Adduserdetails gethedata)
        {
            if (!ModelState.IsValid)
                return BadRequest("not valid");
            _emp.Post(gethedata);
            return Ok();

        }
        [HttpPost("Edit")]

        public IActionResult Edit([FromBody] Adduserdetails gethedata)
        {
            if (!ModelState.IsValid)
                return BadRequest("not valid");
            _emp.Edit(gethedata);
            return Ok();

        }
        /* // PUT api/<ValuesController>/5
         [HttpPut("{id}")]
         public void Put(int id, [FromBody] string value)
         {
         }

         // DELETE api/<ValuesController>/5
         /*[HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
        [HttpDelete]
        [Route("delete/{UserName}")]
        public ActionResult Delete(string UserName)
        {
            _emp.Delete(UserName);
            return Ok();
        }


        [HttpPost("Port")]
       
        public IActionResult Post([FromBody] Designation desdata)
        {
            if (!ModelState.IsValid)
                return BadRequest("not valid");
            _emp.Post(desdata);
            return Ok();

        }
    }

    
}
