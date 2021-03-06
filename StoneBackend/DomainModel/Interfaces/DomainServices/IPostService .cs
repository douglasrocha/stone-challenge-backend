﻿using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Interfaces.DomainServices
{
    public interface IPostService : IBaseAppService<Post>
    {
        int GetAllPostsCount();

        List<Post> GetFirstPostsOrderedByDate(int numberOfPosts, int startIndex);
    }
}
