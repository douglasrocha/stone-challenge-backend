﻿using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using Infrastructure.Modules;
using Ninject;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class UpdatePostController : ApiController
    {
        private IPostAppService AppService
        {
            get
            {
                return new StandardKernel(new BlogModule()).Get<IPostAppService>();
            }
        }

        // GET api/updatepost
        public void Get()
        {
        }

        // GET api/updatepost/5
        public void Get(int id)
        {
        }

        // POST api/updatepost
        public int Post(Post value)
        {
            return AppService.Update(value);
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
