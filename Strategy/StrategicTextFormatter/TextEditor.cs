using System;

namespace StrategicTextFormatter
{
    public class TextEditor
    {
        // The strategy interface is used to define the formatting behavior
        // The concrete strategies implement this interface
        // and provide specific formatting algorithms.
        private ITextFormatter _textFormatter;
        // The constructor accepts a specific strategy implementation
        // and sets it as the current strategy.  
        public TextEditor(ITextFormatter textFormatter)
        {
            _textFormatter = textFormatter;
        }
        // The SetTextFormatter method allows changing the strategy at runtime.
        // This is useful for changing the formatting behavior dynamically.
        public void SetTextFormatter(ITextFormatter textFormatter)
        {
            _textFormatter = textFormatter;
        }
        // The FormatText method uses the current strategy to format the text.
        // It delegates the formatting task to the strategy object.
        public string FormatText(string text)
        {
            return _textFormatter.FormatText(text);
        }
    }
}