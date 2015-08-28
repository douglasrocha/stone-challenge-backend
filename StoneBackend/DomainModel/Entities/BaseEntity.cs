﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public abstract bool IsValid();
    }
}
