using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Specifications.Base
{
    internal class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _wrapped;

        protected ISpecification<T> Wrapped
        {
            get
            {
                return _wrapped;
            }
        }

        internal NotSpecification(ISpecification<T> spec)
        {
            if (spec == null)
            {
                throw new ArgumentNullException("spec");
            }

            _wrapped = spec;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return !Wrapped.IsSatisfiedBy(candidate);
        } 
    }
}
