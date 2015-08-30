using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using Infrastructure.Modules;
using Ninject;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebServices.Controllers
{
    public class InsertTagController : ApiController
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

        // POST api/inserttag
        public int Post(Tag value)
        {
            return AppService.Insert(value);
        }

        // PUT api/inserttag/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/inserttag/5
        public void Delete(int id)
        {
        }
    }
}
