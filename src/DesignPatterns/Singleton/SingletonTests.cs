using DesignPatterns.Singleton.Implementation;
using NUnit.Framework;

namespace DesignPatterns.Singleton
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void When_Sigleton_Is_Not_Used()
        {
            var application1 = new Application();
            application1.Run();

            var application2 = new Application();
            application2.Run();

            Assert.AreNotEqual(application1, application2);
        }

        [Test]
        public void When_Sigleton_Is_Used()
        {
            var application1 = SingleApplication.Instance;
            var application2 = SingleApplication.Instance;
            Assert.AreEqual(application1, application2);
        }
    }
}
