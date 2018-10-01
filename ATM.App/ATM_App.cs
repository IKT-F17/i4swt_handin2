using System;
using TransponderReceiver;

namespace ATM.App
{
    class ATM_App
    {
        static void Main(string[] args)
        {
            var myReceiver = TransponderReceiverFactory.CreateTransponderDataReceiver();
            myReceiver.TransponderDataReady += TransponderDataHandler;

            Console.ReadKey();
        }

        private static void TransponderDataHandler(object sender, RawTransponderDataEventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Transponder Data Stream:");

            foreach (var rawData in e.TransponderData)
            {
                Console.WriteLine(rawData);
            }
        }
    }
}
