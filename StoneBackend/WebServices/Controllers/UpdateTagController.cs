using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using Infrastructure.Modules;
using Ninject;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class UpdateTagController : ApiController
    {
        private ITagAppService AppService
        {
            get
            {
                return new StandardKernel(new BlogModule()).Get<ITagAppService>();
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

        // POST api/updatetag
        public int Post(Tag value)
        {
            return AppService.Update(value);
        }

        // PUT api/updatetag/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/updatetag/5
        public void Delete(int id)
        {
        }
    }
}
