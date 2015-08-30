using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using Infrastructure.Modules;
using Newtonsoft.Json;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebServices.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PostController : ApiController
    {
        private IPostAppService AppService
        {
            get
            {
                return new StandardKernel(new BlogModule()).Get<IPostAppService>();
            }
        }

        // GET api/post
        public IEnumerable<Post> Get()
        {
            return AppService.GetAll();
        }

        // GET api/post/5
        public Post Get(int id)
        {
            return AppService.GetById(id);
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
