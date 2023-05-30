using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
    {
        [Route(template:"api/[controller]")]
        [ApiController]

        public class UserController : ControllerBase
        {
            // GET: api/<UsersController>
            [HttpGet]
            public IEnumerable<string> Get()
            {
                return new string[]  {"value1", "value2"};
            }


            //Get api/<UserController>/5
            [HttpGet(template:"{id}")]
            public string Get(int id)
            {
                return "value";
            }

            // POST api/<UserController>
            [HttpPost]

            public void Post([FromBody] string value)
            {
            }

            // PUT api/<UsersController>/5
            [HttpPut(template:"{id}")]
            
            public void Put(int id, [FromBody] string value )
            {
            }

            // DELETE api/<UserController>/5
            [HttpDelete(template:"{id}")]
            public void DELETE(int id)
            {
            }


        }
    }