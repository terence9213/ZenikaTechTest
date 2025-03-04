
namespace RadioactivityMonitor
{
    public class NuclearPowerPlantManager
    {
        private Alarm alarm1 = new Alarm();
        private Sensor sensor1 = new Sensor();

        //Get radioactivity value from sensor1 and performs check
        public void CheckSensor1()
        {
            double value = sensor1.NextMeasure();
            CheckSensor1(value);
        }

        //Pass radioactivity value to alarm1 
        public void CheckSensor1(double value)
        {
            alarm1.Check(value);
        }

        //Check if alarm1 is on
        public bool CheckAlarm1()
        {
            return alarm1.AlarmOn;
        }
    }
}
