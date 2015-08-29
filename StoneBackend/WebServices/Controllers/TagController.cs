using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DomainModel.Entities;
using Ninject;
using Infrastructure.Modules;
using DomainModel.Interfaces.DomainServices;

namespace WebServices.Controllers
{
    public class TagController : ApiController
    {
        private ITagAppService AppService
        {
            get
            {
                return new StandardKernel(new BlogModule()).Get<ITagAppService>();
            }
        }

        // GET api/tag
        public IEnumerable<Tag> Get()
        {
            return AppService.GetAll();
        }

        // GET api/tag/5
        public Tag Get(int id)
        {
            return AppService.GetById(id);
        }

        // POST api/tag
        public void Post([FromBody]string value)
        {
        }

        // PUT api/tag/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/tag/5
        public void Delete(int id)
        {
        }
    }
}
