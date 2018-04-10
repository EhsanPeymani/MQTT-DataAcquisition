using System;
using System.Net.Http;

namespace TestConsole.Types
{
    public class Status
    {
        public Status(float treshold)
        {
            this.Treshold = treshold;
            this.AllowSend = true;
            this.HighFlag = false;
            this.LowFlag = false;
            this.Initialized = false;
            this.HttpClient = new HttpClient();
        }

        public float Treshold { get; set; }
        public TimeSpan Timer { get; set; }
        public bool AllowSend { get; set; }
        public bool HighFlag { get; set; }
        public bool LowFlag { get; set; }
        public bool Initialized { get; set; }
        public DateTime Timestamp { get; set; }
        public HttpClient HttpClient { get; set; }

    }
}