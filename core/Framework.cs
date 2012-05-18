using Moq;

namespace Cru.Specifications.Core
{
    public class Framework
    {
        public static T Stub<T>() where T : class
        {
            return new Mock<T>().Object;
        }
    }
}