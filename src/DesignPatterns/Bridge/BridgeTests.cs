using DesignPatterns.Bridge.Implementation;
using DesignPatterns.Bridge.Implementation.Nodes;
using DesignPatterns.Bridge.Implementation.Servers;
using NUnit.Framework;

namespace DesignPatterns.Bridge
{
    [TestFixture]
    public class BridgeTests
    {
        [Test]
        public void When_Loadbalancer_Not_Used()
        {
            Server server = new RefinedServer();

            server.Node = new ServerNodeOne();
            server.Request();
            server.Request();
        }

        [Test]
        public void When_Loadbalancer_Is_Used()
        {
            var server = new LoadBalancer();
            server.Request();
            server.Request();
        }
    }
}
