using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using Infrastructure.Modules;
using Ninject;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebServices.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DeletePostController : ApiController
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

        // POST api/deletepost
        public int Post(Post value)
        {
            return AppService.Delete(value);
        }

        // PUT api/deletepost/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/deletepost/5
        public void Delete(int id)
        {
        }
    }
}
