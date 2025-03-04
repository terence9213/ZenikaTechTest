using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        [TestMethod()]
        public void CheckTest()
        {
            Alarm alarm = new Alarm();
            alarm.Check();

            Assert.IsTrue(alarm.AlarmOn);

        }
    }
}