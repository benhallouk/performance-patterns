namespace DesignPatterns.Singleton.Implementation
{
    public sealed class SingleApplication
    {
        private static volatile object _instance;
        private static object _instanceLock = new object();

        private SingleApplication()
        {
        }

        public static object Instance
        {
            get
            {

                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null) _instance = new object();
                    }

                }
                return _instance;
            }
        }

    }
}
