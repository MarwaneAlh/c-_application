namespace Meteo_Interface.Model
{
    public class Alarm
    {
        public Alarm(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public int Interval { get; set; }

        public int ConvertedData { get; set; }
        
        public int AlarmPeriod { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public int WarningMin { get; set; }

        public int WarningMax { get; set; }

        public int CriticalMin { get; set; }

        public int CriticalMax { get; set; }
    }
}