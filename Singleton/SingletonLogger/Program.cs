// See https://aka.ms/new-console-template for more information
using System;
using SingletonLogger;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nNormal Logger:");
        // Create instances of the normal Logger class
        var log1 = new Logger();
        var log2 = new Logger();
        Console.WriteLine($"Are both logger instances the same? {log1 == log2}"); // Should print 'False'

        Console.WriteLine("\nEager Singleton Logger:");
        // Create instances of the EagerSingletonLogger class
        var Eagerlogger1 = EagerSingletonLogger.Instance;
        var Eagerlogger2 = EagerSingletonLogger.Instance;
        Console.WriteLine($"Are both logger instances the same? {Eagerlogger1 == Eagerlogger2}"); // Should print 'True'

        Console.WriteLine("\nLazy Singleton Logger:");
        // Create instances of the LazySingletonLogger class
        var lazyLogger1 = LazySingletonLogger.Instance;
        var lazyLogger2 = LazySingletonLogger.Instance;
        Console.WriteLine($"Are both lazy logger instances the same? {lazyLogger1 == lazyLogger2}"); // Should print 'True'

        Console.WriteLine("\nLazy Thread-Safe Singleton Logger:");
        // Create instances of the LazyThreadSafeSingletonLogger class
        var lazyThreadSafeLogger1 = LazyThreadSafeSingletonLogger.Instance;
        var lazyThreadSafeLogger2 = LazyThreadSafeSingletonLogger.Instance;
        Console.WriteLine($"Are both lazy thread-safe logger instances the same? {lazyThreadSafeLogger1 == lazyThreadSafeLogger2}"); // Should print 'True'

        Console.WriteLine("\nLazy Singleton Built-In Lock Logger:");
        // Create instances of the LazySingletonBuiltInLockLogger class
        var lazyBuiltInLockLogger1 = LazySingletonBuiltInLockLogger.Instance;
        var lazyBuiltInLockLogger2 = LazySingletonBuiltInLockLogger.Instance;
        Console.WriteLine($"Are both lazy built-in lock logger instances the same? {lazyBuiltInLockLogger1 == lazyBuiltInLockLogger2}"); // Should print 'True'
    }
}
