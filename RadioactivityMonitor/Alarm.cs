namespace RadioactivityMonitor
{
    public class Alarm
    {
        private const double LowThreshold = 17;
        private const double HighThreshold = 21;

        Sensor _sensor = new Sensor();

        bool _alarmOn = false;
        private long _alarmCount = 0;

        // Check the value and turn the alarm on if the value is outside of the threshold (else turn alarm off)
        public void Check(double value)
        {
            if (value < LowThreshold || HighThreshold < value)
            {
                _alarmOn = true;
                _alarmCount += 1;
            }
            else
            {
                _alarmOn = false;
            }
        }

        public void Check()
        {
            double value = _sensor.NextMeasure();
            Check(value);
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }
    }
}