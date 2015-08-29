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

namespace WebServices.Controllers
{
    public class UserController : ApiController
    {
        private IUserAppService AppService
        {
            get
            {
                return new StandardKernel(new BlogModule()).Get<IUserAppService>();
            }
        }

        public string GetAll()
        {
            return JsonConvert.SerializeObject(AppService.GetAll());
        }

        public string Get(int id)
        {
            return JsonConvert.SerializeObject(AppService.GetById(id));
        }

        public int Insert(string jsonObj)
        {
            var user = JsonConvert.DeserializeObject<User>(jsonObj);
            return AppService.Insert(user);
        }

        public int Update(string jsonObj)
        {
            var user = JsonConvert.DeserializeObject<User>(jsonObj);
            return AppService.Update(user);
        }

        public int Delete(string jsonObj)
        {
            var user = JsonConvert.DeserializeObject<User>(jsonObj);
            return AppService.Delete(user);
        }
    }
}
