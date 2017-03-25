using NUnit.Framework;

namespace ApiNotification.Tests
{
    [TestFixture]
    public class BasicTest
    {
        [Test]
        [Ignore]
        public void InvalidTest()
        {
            Assert.IsTrue(false);
        }

        [Test]
        public void ValidTest()
        {
            Assert.IsTrue(true);
        }
    }
}
