using DesignPatterns.Proxy.Implementation;
using DesignPatterns.Proxy.Implementation.Service;
using NUnit.Framework;

namespace DesignPatterns.Proxy
{
    [TestFixture]
    public class ProxyTests
    {
        [Test]
        public void When_Proxy_Is_Not_Used()
        {
            IService service = new Service();
            service.GetRequest(1);
            service.GetRequest(1);
        }

        [Test]
        public void When_Proxy_Is_Used()
        {
            IService service = new Service();
            IService proxy = new ServiceProxy(service);
            proxy.GetRequest(1);
            proxy.GetRequest(1);
        }
    }
}
