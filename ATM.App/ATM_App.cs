using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TransponderReceiver;

namespace ATM.App
{
    class ATM_App
    {
        static void Main(string[] args)
        {
            //var receiver = TransponderReceiverFactory.CreateTransponderDataReceiver();
            //var tracks = new List<ITrack>();
            //ITrackFactory trackFactory = new TrackFactory();

            //var controller = new ATM(receiver, trackFactory, tracks);

            //var myPlane1 = new Planes("TAG001", 920);
            //var myPlane1_2 = new Planes("TAG001", 910);
            //var myPlane2 = new Planes("TAG002", 940);




            ///////////////////////////////////////////////////////////
            // List examples and help: https://www.dotnetperls.com/list


            //Try 1:

            //var innerList = new List<Object>(new string[] {"TAG01", "TAG02", "TAG03"});
            //var outerList = new List<Object>();

            //innerList.Add("PIE284");
            //innerList.Add("PIE284");
            //outerList.Add(innerList);

            //innerList = new List<Object>();

            //innerList.Add("MAX242");
            //innerList.Add("MAX242");
            //outerList.Add(innerList);



            //Try 2:

            //
            // Add rows and columns to the List.
            //
            var jaggedList = new List<List<int>>();     // 2D List

            var rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                //
                // Put some integers in the inner lists.
                //
                var sublist = new List<int>();

                int top = rand.Next(1, 15);

                for (int v = 0; v < top; v++)
                {
                    sublist.Add(rand.Next(1, 5));
                }
                //
                // Add the sublist to the top-level List reference.
                //
                jaggedList.Add(sublist);
            }















            // THE END
            Console.ReadKey();
        }
    }

    public class Planes
    {
        public Planes(string tag, int speed)
        {
            _tag = tag;
            _speed = speed;
        }

        public string _tag { get; private set; }
        public int _speed { get; private set; }
    }
}
