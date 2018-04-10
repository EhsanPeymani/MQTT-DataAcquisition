using System.Collections.Generic;

namespace TestConsole.Types
{
    public class OutgoingMessage
    {
        public OutgoingMessage(string message, IncomingMessage incomingMessage)
        {
            this.Content = new Dictionary<string, string>()
            {
                {"message", message },
                {"lastSensorValue", incomingMessage.Value.ToString("F2")},
                {"lastSensorTimestamp", incomingMessage.Timestamp.ToString("O") }
            };
        }

        public Dictionary<string, string> Content { get; set; }
    }
}
