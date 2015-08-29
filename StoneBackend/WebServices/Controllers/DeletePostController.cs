using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class DeletePostController : ApiController
    {
        // GET api/deletepost
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/deletepost/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/deletepost
        public void Post([FromBody]string value)
        {
        }

        // PUT api/deletepost/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/deletepost/5
        public void Delete(int id)
        {
        }
    }
}
