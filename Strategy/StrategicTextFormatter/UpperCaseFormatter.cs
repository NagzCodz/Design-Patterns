using System;

namespace StrategicTextFormatter
{
    public class UpperCaseFormatter : ITextFormatter
    {
        public string FormatText(string text)
        {
            return text.ToUpper();
        }
    }
}