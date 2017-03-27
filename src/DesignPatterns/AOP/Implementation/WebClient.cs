using System.Threading;

namespace DesignPatterns.AOP.Implementation
{
    public class WebClient
    {
        public void CachedRequest()
        {
            Thread.Sleep(2000);
        }

        public void Request()
        {
            Thread.Sleep(2000);
        }
    }
}
