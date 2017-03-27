using DesignPatterns.Bridge.Implementation.Nodes;
using DesignPatterns.Bridge.Implementation.Servers;

namespace DesignPatterns.Bridge.Implementation
{
    public class LoadBalancer : Server
    {
        private bool switchNode;

        public override void Request()
        {
            Server server = new RefinedServer();

            if (switchNode)
            {
                server.Node = new ServerNodeOne();
            }
            else
            {
                server.Node = new ServerNodeTwo();

            }
            server.Request();

            switchNode = !switchNode;
        }
    }
}
