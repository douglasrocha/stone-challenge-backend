﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class UpdateTagController : ApiController
    {
        // GET api/updatetag
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/updatetag/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/updatetag
        public void Post([FromBody]string value)
        {
        }

        // PUT api/updatetag/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/updatetag/5
        public void Delete(int id)
        {
        }
    }
}
