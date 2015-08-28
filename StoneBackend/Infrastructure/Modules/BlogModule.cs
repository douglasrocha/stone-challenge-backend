using ApplicationServices.Services;
using DomainModel.Interfaces.DomainServices;
using DomainModel.Repository.Interfaces;
using DomainServices.Services;
using Infrastructure.Data;
using Infrastructure.Repository;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Modules
{
    public class BlogModule : NinjectModule
    {
        public override void Load()
        {
            // Repositories
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IPostRepository>().To<PostRepository>();
            Bind<ITagRepository>().To<TagRepository>();

            // Domain Services
            Bind<IUserService>().To<UserService>();
            Bind<IPostService>().To<PostService>();
            Bind<ITagService>().To<TagService>();

            // Application Services
            Bind<IUserAppService>().To<UserAppService>();
            Bind<IPostAppService>().To<PostAppService>();
            Bind<ITagAppService>().To<TagAppService>();
        }
    }
}
