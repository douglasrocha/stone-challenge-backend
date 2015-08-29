using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class UpdatePostController : ApiController
    {
        // GET api/updatepost
        public void Get()
        {
        }

        // GET api/updatepost/5
        public void Get(int id)
        {
        }

        // POST api/updatepost
        public void Post([FromBody]Post value)
        {
        }

        // PUT api/updatepost/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/updatepost/5
        public void Delete(int id)
        {
        }
    }
}
