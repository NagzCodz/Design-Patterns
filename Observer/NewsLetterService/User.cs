using System;

namespace NewsLetterService
{
    public class User : ISubscriber
    {
        public string _name;
        public User(string name)
        {
            _name = name;
            Console.WriteLine($"User {_name} created.");
        }
        public void Update(string message)
        {
            // This method will be called by the subject (newsletter) when there is a new message.
            Console.WriteLine($"User {_name} received update: {message}");
        }
    }
}