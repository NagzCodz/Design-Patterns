🎯 Strategy Design Pattern
🔍 What is the Strategy Pattern?
The Strategy Pattern is a behavioral design pattern that enables selecting an algorithm's behavior at runtime. Instead of implementing a single algorithm directly, you define a family of algorithms (strategies), encapsulate each one, and make them interchangeable.

💡 Use Case: When you want to define multiple behaviors and switch between them dynamically without using conditional statements.

🧠 Real-Life Analogy
Think of a payment system. A customer can pay using a credit card, UPI, or PayPal. Each payment method is a strategy. At runtime, the user selects which one to use.

🧱 Pattern Components
Strategy Interface: Defines a common method signature for all strategies.

Concrete Strategies: Implement different versions of the behavior.

Context Class: Uses a strategy object to execute the behavior.

🧪 This Example – Text Formatter
Let's say you want to format text in different ways: UpperCase or LowerCase. The format strategy can be swapped at runtime.
