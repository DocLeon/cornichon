using NUnit.Framework;

namespace cornichon.core
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