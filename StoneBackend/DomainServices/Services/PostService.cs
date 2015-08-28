﻿using DomainModel.Entities;
using DomainModel.Interfaces.DomainServices;
using DomainModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Services
{
    public class PostService : BaseService<Post>, IPostService
    {
        public PostService(IBaseRepository<Post> repository) : base(repository)
        {

        }
    }
}
