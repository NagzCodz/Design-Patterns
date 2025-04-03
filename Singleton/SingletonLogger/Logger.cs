using System;

namespace SingletonLogger
{
    public class Logger
    {
        public Logger()
        {
            // Initialization code here (if needed)
            Console.WriteLine("Logger instance created.");
        }
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}