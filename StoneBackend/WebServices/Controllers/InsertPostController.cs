﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class InsertPostController : ApiController
    {
        // GET api/updatepost
        public void Get()
        {
        }

        // GET api/updatepost/5
        public void Get(int id)
        {
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
