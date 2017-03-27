using DesignPatterns.AOP.Implementation;
using NUnit.Framework;

namespace DesignPatterns.AOP
{
    [TestFixture]
    public class AOPTests
    {
        [Test]
        public void When_Interceptiors_Not_Used()
        {
            var webClient = new WebClient();
            webClient.Request();
            webClient.Request();
        }

        [Test]
        public void When_Interceptiors_Is_Used()
        {
            var webClient = new WebClient();
            webClient.CachedRequest();
            webClient.CachedRequest();
        }
    }
}
