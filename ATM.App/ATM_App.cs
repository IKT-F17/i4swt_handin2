using System;
using System.Globalization;
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
                string[] rawDataSplit = rawData.Split(';');

                string tag = rawDataSplit[0];
                int xcoord = Convert.ToInt32(rawDataSplit[1]);
                int ycoord = Convert.ToInt32(rawDataSplit[2]);
                int altitude = Convert.ToInt32(rawDataSplit[3]);
                DateTime timeStamp = DateTime.ParseExact(rawDataSplit[4], "yyyyMMddHHmmssfff", CultureInfo.InvariantCulture);

                Console.WriteLine(tag);
                Console.WriteLine(xcoord);
                Console.WriteLine(ycoord);
                Console.WriteLine(altitude);
                Console.WriteLine(timeStamp);
            }
        }
    }
}
