using System;
using System.Text;
using Newtonsoft.Json;
using TestConsole.Types;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace TestConsole
{
    public static class Initializer
    {
        public static void ConnectToServer(string server, string task, Status status)
        {
            // create client instance 
            MqttClient client = new MqttClient(server);

            //// register to message received 
            client.MqttMsgPublishReceived += (sender, args) => ClientOnMqttMsgPublishReceivedAsync(sender, args, status);

            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);

            //// subscribe to the topic "/sensors/lyse-test-01" with QoS 2 
            client.Subscribe(new string[] { task }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }

        // event handler which gets messages from server
        private static async void ClientOnMqttMsgPublishReceivedAsync(object sender, MqttMsgPublishEventArgs mqttMsgPublishEventArgs, Status status)
        {
            var jsonString = Encoding.Default.GetString(mqttMsgPublishEventArgs.Message);
            var message = JsonConvert.DeserializeObject<IncomingMessage>(jsonString);

            await Utility.UpdateStatus(message, status);
            Console.WriteLine($@"{message} - T:{status.Timer.TotalMinutes:F2} - H:{status.HighFlag} - L:{status.LowFlag}");
        }

    }
}