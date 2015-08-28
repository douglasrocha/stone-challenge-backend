using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Specifications.Base
{
    internal class XorSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _spec1;
        private readonly ISpecification<T> _spec2;

        protected ISpecification<T> Spec1
        {
            get
            {
                return _spec1;
            }
        }

        protected ISpecification<T> Spec2
        {
            get
            {
                return _spec2;
            }
        }

        internal XorSpecification(ISpecification<T> spec1, ISpecification<T> spec2)
        {
            if (spec1 == null)
                throw new ArgumentNullException("spec1");

            if (spec2 == null)
                throw new ArgumentNullException("spec2");

            _spec1 = spec1;
            _spec2 = spec2;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return Spec1.IsSatisfiedBy(candidate) ^ Spec2.IsSatisfiedBy(candidate);
        }
    }
}
