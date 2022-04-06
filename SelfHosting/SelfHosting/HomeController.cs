using System.Collections.Generic;
using System.Web.Http;
namespace SelfHosting
{
    public class HomeController : ApiController
    {
        // GET api/home
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }

        // GET api/home/5 
        public string Get(int id)
        {
            return "Hello, World!";
        }

        // POST api/home 
        public void Post([FromBody] string value)
        {
        }

        // PUT api/home/5 
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/home/5 
        public void Delete(int id)
        {
        }
    }
}
