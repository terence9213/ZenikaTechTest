using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using RadioactivityMonitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactivityMonitor.Tests
{
    [TestClass()]
    public class AlarmTests
    {

        private Alarm alarm = new Alarm();

        [TestInitialize()]
        public void Startup()
        {
        }

        //lower >  Rad [_alarmOn == true]
        [TestMethod()]
        public void Check01_BelowLowerThreshold_ReturnsTrue()
        {
            alarm.Check(0);
            Assert.IsTrue(alarm.AlarmOn);
        }

        //lower == Rad [_alarmOn == false]
        [TestMethod()]
        public void Check02_EqualLowerThreshold_ReturnsFalse()
        {
            alarm.Check(17);
            Assert.IsFalse(alarm.AlarmOn);
        }

        //lower < Rad < upper [_alarmOn == false]
        [TestMethod()]
        public void Check03_BetweenLowerAndUpperThreshold_ReturnsFalse()
        {
            alarm.Check(19);
            Assert.IsFalse(alarm.AlarmOn);
        }

        //Rad  >  upper [_alarmOn == true]
        [TestMethod()]
        public void Check04_EqualUpperThreshold_ReturnsFalse()
        {
            alarm.Check(21);
            Assert.IsFalse(alarm.AlarmOn);
        }

        //Rad  == upper [_alarmOn == false]
        [TestMethod()]
        public void Check05_AboveUpperThreshold_ReturnsTrue()
        {
            alarm.Check(22);
            Assert.IsTrue(alarm.AlarmOn);
        }
    }
}