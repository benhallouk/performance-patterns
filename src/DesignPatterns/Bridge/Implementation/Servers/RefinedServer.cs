namespace DesignPatterns.Bridge.Implementation.Servers
{
    public class RefinedServer : Server
    {
        public override void Request()
        {
            Node.Request();
        }
    }
}
