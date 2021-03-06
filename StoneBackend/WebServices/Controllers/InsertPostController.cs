﻿using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using Infrastructure.Modules;
using Ninject;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebServices.Controllers
{
    public class InsertPostController : ApiController
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

        // POST api/insertpost
        public int Post(Post value)
        {
            return AppService.Insert(value);
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
