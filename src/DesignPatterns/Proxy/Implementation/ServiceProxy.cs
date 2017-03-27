using DesignPatterns.Proxy.Implementation.Service;
using System.Collections.Generic;

namespace DesignPatterns.Proxy.Implementation
{
    public class ServiceProxy : IService
    {
        private readonly IService _service;
        private Dictionary<int, string> memoryCache = new Dictionary<int, string>();

        public ServiceProxy(IService service)
        {
            _service = service;
        }

        public string GetRequest(int id)
        {
            if (memoryCache.ContainsKey(id)) return memoryCache[id];

            var result = _service.GetRequest(id);
            memoryCache.Add(id, result);

            return result;
        }
    }
}
