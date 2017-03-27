using System.Threading;

namespace DesignPatterns.Proxy.Implementation.Service
{
    public class Service : IService
    {
        public string GetRequest(int id)
        {
            Thread.Sleep(5000);
            return "OK";
        }
    }
}
