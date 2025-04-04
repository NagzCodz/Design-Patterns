using System;

namespace NewsLetterService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new newsletter publisher
            var newsletter = NewsLetterService.Instance;

            // Create some subscribers (users)
            var user1 = new User("Alice");
            var user2 = new User("Bob");

            // Subscribe users to the newsletter
            newsletter.Subscribe(user1);
            newsletter.Subscribe(user2);

            // Notify subscribers with a message
            newsletter.Notify("New issue of the newsletter is out!");

            // Unsubscribe one user and notify again
            newsletter.Unsubscribe(user1);
            newsletter.Notify("Second issue of the newsletter is out!");
        }
    }
}