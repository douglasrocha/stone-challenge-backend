using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException() : base("Invalid domain object")
        {
        }
    }
}
