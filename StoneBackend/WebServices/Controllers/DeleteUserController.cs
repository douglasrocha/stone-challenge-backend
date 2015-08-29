﻿using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using Infrastructure.Modules;
using Ninject;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class DeleteUserController : ApiController
    {
        private IUserAppService AppService
        {
            get
            {
                return new StandardKernel(new BlogModule()).Get<IUserAppService>();
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

        // POST api/deleteuser
        public int Post(User value)
        {
            return AppService.Delete(value);
        }

        // PUT api/deleteuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/deleteuser/5
        public void Delete(int id)
        {
        }
    }
}
