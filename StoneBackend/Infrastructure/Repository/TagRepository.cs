﻿using DomainModel.Entities;
using Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TagRepository : IBaseRepository<Tag>, ITagRepository
    {
    }
}
