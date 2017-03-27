using DesignPatterns.Bridge.Implementation.Nodes;

namespace DesignPatterns.Bridge.Implementation.Servers
{
    public class Server
    {
        public ServerNode Node { get; set; }

        public virtual void Request()
        {
            Node.Request();
        }
    }
}
