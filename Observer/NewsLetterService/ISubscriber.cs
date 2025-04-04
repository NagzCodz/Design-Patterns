using System;

namespace NewsLetterService
{
    // This interface defines the contract for subscribers to implement the Update method.
    // The Update method will be called by the subject (newsletter) when there is a new message.
    // This is the observer in the observer pattern.
    public interface ISubscriber
    {
        void Update(string message);
    }
}