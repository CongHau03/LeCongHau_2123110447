using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeCongHau_2123110447.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}