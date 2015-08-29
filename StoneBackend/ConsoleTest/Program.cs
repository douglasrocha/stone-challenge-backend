using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using Infrastructure.Modules;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new BlogModule());
            var postApp = kernel.Get<IPostAppService>();

            var post = postApp.GetById(1);
            post.Title = "Douglas";

            var haha = postApp.Update(post);
            
            Console.WriteLine(haha);
        }
    }
}
