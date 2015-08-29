using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using Infrastructure.Modules;
using Ninject;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class DeleteTagController : ApiController
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

        // POST api/deletetag
        public int Post(Tag value)
        {
            return AppService.Delete(value);
        }

        // PUT api/deletetag/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/deletetag/5
        public void Delete(int id)
        {
        }
    }
}
