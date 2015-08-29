using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class InsertPostController : ApiController
    {
        // GET api/insertpost
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/insertpost/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/insertpost
        public void Post([FromBody]string value)
        {
        }

        // PUT api/insertpost/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/insertpost/5
        public void Delete(int id)
        {
        }
    }
}
