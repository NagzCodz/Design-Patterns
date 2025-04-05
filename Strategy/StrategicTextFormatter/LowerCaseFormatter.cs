using System;

namespace StrategicTextFormatter
{
    public class LowerCaseFormatter : ITextFormatter
    {
        public string FormatText(string text)
        {
            return text.ToLower();
        }
    }
}