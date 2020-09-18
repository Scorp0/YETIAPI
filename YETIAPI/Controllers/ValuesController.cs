using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace YETIAPI.Controllers
{
    public class ValuesController : ApiController
    {
        private YETIEntities db = new YETIEntities();
        // GET api/values
        [Route("api/Person")]
        public IEnumerable<Person> GetPerson()
        {
            return db.Person.ToList();
        }
        [Route("api/Role")]
        public IEnumerable<Role> GetRole()
        {
            return db.Role.ToList();
        }
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
