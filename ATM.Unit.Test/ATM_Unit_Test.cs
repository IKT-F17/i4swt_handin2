using System;
using System.Collections.Generic;
using System.Globalization;
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
        private TrackFactory _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new TrackFactory();
        }

        

        [Test]
        public void SpawnTrack_FromRawTestData()
        {
            ITrack testTrack = _uut.SpawnTrack(RAWTESTDATA);
            DateTime tesTime = new DateTime(2015,10,06,21,34,56,789);

            Assert.That(testTrack.Tag, Is.EqualTo("PIE284"));
            Assert.That(testTrack.XCoord, Is.EqualTo(29388));
            Assert.That(testTrack.YCoord, Is.EqualTo(49932));
            Assert.That(testTrack.Altitude, Is.EqualTo(2000));
            Assert.That(testTrack.TimeStamp, Is.EqualTo(tesTime));

        }

    }
}
