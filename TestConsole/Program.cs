using System;
using TestConsole.Types;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($@"Threshold is {Properties.Settings.Default.Threshold}");
                Console.WriteLine($@"REST API: {Properties.Settings.Default.PostTo}");

                var status = new Status(Properties.Settings.Default.Threshold);

                // connecting to server
                Initializer.ConnectToServer("test.mosquitto.org", "sensors/lyse-test-01", status);
            }
            catch(Exception exception)
            {
                Console.WriteLine(@"Something goes wrong.");
                Console.WriteLine(exception);
            }
            
        }

    }
}
