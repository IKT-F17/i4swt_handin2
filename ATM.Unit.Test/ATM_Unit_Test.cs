using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ATM.Unit.Test
{


    [TestFixture]
    public class ATM_Unit_Test
    {
        private string RAWTESTDATA = "PIE284;29388;49932;2000;20151006213456789";

        [Test]
        public void addtest()
        {
            var uut = new TrackFactory();
            Assert.That(uut.Add(2,4), Is.EqualTo(6) );
        }
    }
}
