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
using Newtonsoft.Json;

namespace WebServices.Controllers
{
    public class PostController : ApiController
    {
        private IPostAppService AppService
        {
            get
            {
                return new StandardKernel(new BlogModule()).Get<IPostAppService>();
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
            var post = JsonConvert.DeserializeObject<Post>(jsonObj);
            return AppService.Insert(post);
        }

        public int Update(string jsonObj)
        {
            var post = JsonConvert.DeserializeObject<Post>(jsonObj);
            return AppService.Update(post);
        }

        public int Delete(string jsonObj)
        {
            var post = JsonConvert.DeserializeObject<Post>(jsonObj);
            return AppService.Delete(post);
        }
    }
}
