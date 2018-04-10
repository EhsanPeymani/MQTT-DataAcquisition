using System;
using System.Net.Http;
using System.Threading.Tasks;
using TestConsole.Types;

namespace TestConsole
{
    public class Utility
    {
        public static async Task UpdateStatus(IncomingMessage message, Status status)
        {
            // first call
            InitializeStatus(message, status);

            // first time it gets above the threshold, we save timestamp   
            if (message.Value > status.Treshold && !status.HighFlag && status.LowFlag)
            {
                status.Timestamp = message.Timestamp;
                status.HighFlag = true;
                status.LowFlag = false;
                Console.WriteLine(@"High Flag");
            }

            if (message.Value <= status.Treshold && !status.LowFlag && status.HighFlag)
            {
                status.Timestamp = message.Timestamp;
                status.HighFlag = false;
                status.LowFlag = true;
                Console.WriteLine(@"Low Flag");
            }

            status.Timer = message.Timestamp.Subtract(status.Timestamp);

            if (status.Timer.TotalMinutes > 5 && status.AllowSend && status.HighFlag)
            {
                status.AllowSend = false;
                await Utility.SendAlarm(status, message);
            }

            if (status.Timer.TotalMinutes > 5 && status.LowFlag)
            {
                status.AllowSend = true;
            }
            ;
        }

        private static void InitializeStatus(IncomingMessage message, Status status)
        {
            if (!status.Initialized)
            {
                status.Initialized = true;

                if (message.Value > status.Treshold)
                {
                    status.HighFlag = false;
                    status.LowFlag = true;
                }
                else
                {
                    status.HighFlag = true;
                    status.LowFlag = false;
                }
            }
        }

        private static async Task SendAlarm(Status status, IncomingMessage message)
        {
            Console.WriteLine(@"Alarm sent.");

            var outgoingMessage = new OutgoingMessage("Threshold value exceeded", message);

            var content = new FormUrlEncodedContent(outgoingMessage.Content);

            var response = await status.HttpClient.PostAsync(Properties.Settings.Default.PostTo, content);

            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);
        }
    }
}