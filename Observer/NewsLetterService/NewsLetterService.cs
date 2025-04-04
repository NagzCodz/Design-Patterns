using System;

namespace NewsLetterService
{
    // This class implements the IPublisher interface and represents a newsletter service.
    // It allows subscribers to register for updates and notifies them when there is a new message.
    public class NewsLetterService : IPublisher
    {
        private static readonly Lazy<NewsLetterService> _instance = new Lazy<NewsLetterService>(() => new NewsLetterService());
        public static NewsLetterService Instance => _instance.Value;

        // this list is used to store the subscribers (users) who have registered for updates
        // This is a private field that holds the list of subscribers.
        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

        private NewsLetterService()
        {
            // Private constructor to prevent instantiation from outside
            // This ensures that only one instance of the NewsLetterService exists (singleton pattern)
            Console.WriteLine("NewsLetterService instance created.");
        } // Private constructor to enforce singleton pattern

        public void Subscribe(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
            {
                _subscribers.Add(subscriber);
                Console.WriteLine("Subscriber added.");
            }
            else
            {
                Console.WriteLine("Subscriber already exists.");
            }
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
            {
                _subscribers.Remove(subscriber);
                Console.WriteLine("Subscriber removed.");
            }
            else
            {
                Console.WriteLine("Subscriber not found.");
            }
        }

        public void Notify(string message)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(message);
            }
        }
    }
}