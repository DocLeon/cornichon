using NUnit.Framework;

namespace Cru.Specifications.Core
{
    public abstract class Specification
    {
        protected abstract void Given();
        protected abstract void When();

        [SetUp]
        public void BeforeEachTest()
        {
            Given();
            When();
        }
        
    }
}