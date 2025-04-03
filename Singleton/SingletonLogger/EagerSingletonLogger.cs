using System;

namespace SingletonLogger
{
    public sealed class EagerSingletonLogger
    {
        // Private static instance of the logger, created eagerly
        private static readonly EagerSingletonLogger _instance = new EagerSingletonLogger();

        // Private constructor to prevent instantiation from outside
        private EagerSingletonLogger()
        {
            // Initialization code here (if needed)
            Console.WriteLine("EagerSingletonLogger instance created.");
        }

        // Public property to access the singleton instance
        public static EagerSingletonLogger Instance => _instance;

        // Example method to log messages
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}