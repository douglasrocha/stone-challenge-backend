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
    public class TagController : ApiController
    {
        private ITagAppService AppService
        {
            get
            {
                return new StandardKernel(new BlogModule()).Get<ITagAppService>();
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
            var tag = JsonConvert.DeserializeObject<Tag>(jsonObj);
            return AppService.Insert(tag);
        }

        public int Update(string jsonObj)
        {
            var tag = JsonConvert.DeserializeObject<Tag>(jsonObj);
            return AppService.Update(tag);
        }

        public int Delete(string jsonObj)
        {
            var tag = JsonConvert.DeserializeObject<Tag>(jsonObj);
            return AppService.Delete(tag);
        }
    }
}
