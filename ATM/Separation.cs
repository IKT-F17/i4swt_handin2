using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Interfaces;

namespace ATM
{
    public class Separation 
    {
        public Separation()
        {
        }
        public DateTime SeparationEventTimestamp { get; private set; }
        public string PlaneTag1 { get; private set; }
        public string PlaneTag2 { get; private set; }





    }
}
