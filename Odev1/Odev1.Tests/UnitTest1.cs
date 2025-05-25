using Xunit;
using Odev1;

namespace Odev1.Tests
{
    public class OdevTest
    {
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(5, Odev.Add(2, 3));
            Assert.Equal(0, Odev.Add(-2, 2));
            Assert.Equal(-7, Odev.Add(-3, -4));
        }
    }
}
