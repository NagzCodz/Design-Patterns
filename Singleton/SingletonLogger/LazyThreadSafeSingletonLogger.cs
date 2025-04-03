using System;

namespace SingletonLogger
{
    public sealed class LazyThreadSafeSingletonLogger
    {
        private static LazyThreadSafeSingletonLogger _instance;
        private static readonly object _lock = new object(); // Lock object for thread safety

        // Private constructor to prevent instantiation from outside
        private LazyThreadSafeSingletonLogger()
        {
            // Initialization code here (if needed)
            Console.WriteLine("LazyThreadSafeSingletonLogger instance created.");
        }

        // Public property to access the singleton instance
        public static LazyThreadSafeSingletonLogger Instance
        {
            get
            {
                lock (_lock) // Ensure thread safety
                {
                    if (_instance == null)
                    {
                        _instance = new LazyThreadSafeSingletonLogger();
                    }
                    return _instance;
                }
            }
        }

        // Example method to log messages
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}