using System;

namespace SingletonLogger
{
    public sealed class LazySingletonLogger
    {
        private static LazySingletonLogger _instance;
        private LazySingletonLogger()
        {
            // Initialization code here (if needed)
            Console.WriteLine("LazySingletonLogger instance created.");
        }
        public static LazySingletonLogger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LazySingletonLogger();
                }
                return _instance;
            }
        }
        // Example method to log messages
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}