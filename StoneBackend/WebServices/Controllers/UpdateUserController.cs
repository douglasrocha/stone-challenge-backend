using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using Infrastructure.Modules;
using Ninject;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebServices.Controllers
{
    public class UpdateUserController : ApiController
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

        // POST api/updateuser
        public int Post(User value)
        {
            return AppService.Update(value);
        }

        // PUT api/updateuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/updateuser/5
        public void Delete(int id)
        {
        }
    }
}
