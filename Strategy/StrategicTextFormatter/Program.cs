using System;

namespace StrategicTextFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a TextEditor with an UpperCaseFormatter
            var upFormat = new UpperCaseFormatter();
            TextEditor editor = new TextEditor(upFormat);
            // TextEditor editor = new TextEditor(new UpperCaseFormatter());
            string text = "Hello, World!";
            Console.WriteLine(editor.FormatText(text)); // Output: HELLO, WORLD!

            // Change the formatter to LowerCaseFormatter
            editor.SetTextFormatter(new LowerCaseFormatter());
            Console.WriteLine(editor.FormatText(text)); // Output: hello, world!
        }
    }
}