using System;

namespace TestConsole.Types
{
    public class IncomingMessage
    {
        public double Value { get; set; }
        public DateTime Timestamp { get; set; }

        public override string ToString()
        {
            return $"Sampled at {Timestamp:O} -   {Value:F2}";
        }
    }
}