namespace RadioactivityMonitor.Tests
{
    [TestClass()]
    public class AlarmTests
    {

        private NuclearPowerPlantManager nuclearPowerPlantManager = new NuclearPowerPlantManager();

        //lower threshold >  Rad [_alarmOn == true]
        [TestMethod()]
        public void Check01_BelowLowerThreshold_ReturnsTrue()
        {
            nuclearPowerPlantManager.CheckSensor1(0);
            bool alarmOn = nuclearPowerPlantManager.CheckAlarm1();
            Assert.IsTrue(alarmOn);
        }

        //lower threshold == Rad [_alarmOn == false]
        [TestMethod()]
        public void Check02_EqualLowerThreshold_ReturnsFalse()
        {
            nuclearPowerPlantManager.CheckSensor1(17);
            bool alarmOn = nuclearPowerPlantManager.CheckAlarm1();
            Assert.IsFalse(alarmOn);
        }

        //lower threshold < Rad < upper threshold [_alarmOn == false]
        [TestMethod()]
        public void Check03_BetweenLowerAndUpperThreshold_ReturnsFalse()
        {
            nuclearPowerPlantManager.CheckSensor1(19);
            bool alarmOn = nuclearPowerPlantManager.CheckAlarm1();
            Assert.IsFalse(alarmOn);
        }

        //Rad  >  upper threshold [_alarmOn == true]
        [TestMethod()]
        public void Check04_EqualUpperThreshold_ReturnsFalse()
        {
            nuclearPowerPlantManager.CheckSensor1(21);
            bool alarmOn = nuclearPowerPlantManager.CheckAlarm1();
            Assert.IsFalse(alarmOn);
        }

        //Rad  == upper threshold [_alarmOn == false]
        [TestMethod()]
        public void Check05_AboveUpperThreshold_ReturnsTrue()
        {
            nuclearPowerPlantManager.CheckSensor1(22);
            bool alarmOn = nuclearPowerPlantManager.CheckAlarm1();
            Assert.IsTrue(alarmOn);
        }
    }
}