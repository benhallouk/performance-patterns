using System.Threading;

namespace DesignPatterns.Bridge.Implementation.Nodes
{
    public class ServerNodeOne : ServerNode
    {
        public override void Request()
        {
            Thread.Sleep(2000);
        }
    }
}
