using System;

namespace SingletonLogger
{
    public sealed class LazySingletonBuiltInLockLogger
    {
        private static readonly Lazy<LazySingletonBuiltInLockLogger> _instance = new Lazy<LazySingletonBuiltInLockLogger>(() => new LazySingletonBuiltInLockLogger());
        public static LazySingletonBuiltInLockLogger Instance => _instance.Value;
        public LazySingletonBuiltInLockLogger()
        {
            // Initialization code here (if needed)
            Console.WriteLine("LazySingletonBuiltInLockLogger instance created.");
        }
        // Example method to log messages
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}