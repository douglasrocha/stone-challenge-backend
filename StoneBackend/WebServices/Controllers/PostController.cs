using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DomainModel.Entities;

namespace WebServices.Controllers
{
    public class PostController : ApiController
    {
        // GET api/post
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/post/5
        public Post Get(int id)
        {
            return new Post { Id = id, Title = "Titulo", Body = "Body", CreationDate = DateTime.Now, Author = null, Tags = null };
        }

        // POST api/post
        public void Post([FromBody]string value)
        {
        }

        // PUT api/post/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/post/5
        public void Delete(int id)
        {
        }
    }
}
