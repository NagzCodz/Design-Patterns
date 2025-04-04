using System;

namespace NewsLetterService
{
    // This interface defines the contract for publishers to implement the Subscribe and Unsubscribe methods.
    // The Subscribe method allows subscribers to register for updates, while the Unsubscribe method allows them to unregister.
    // This is the subject in the observer pattern.
    public interface IPublisher
    {
        //we are using ISubscriber as a generic type here, so we can use any class that implements ISubscriber
        // This allows us to have a flexible and extensible design, as we can add new types of subscribers without changing the publisher code.
        // Follows Dependency Inversion Principle (DIP) of SOLID principles.
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void Notify(string message);
    }
}