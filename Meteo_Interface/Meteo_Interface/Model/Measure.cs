namespace Meteo_Interface.Model
{
    public class Measure
    {
        public Measure(int id, DataType type, int data, AlarmType alarm)
        {
            Id = id;
            IsConfiguratedStatus = false;
            Type = type;
            Data = data;
            LastUpdate = 0;
            AlarmType = alarm;
        }

        public int Id { get; set; }

        public bool IsConfiguratedStatus { get; set; }

        public DataType Type { get; set; }

        public int Data { get; set; }

        public int LastUpdate { get; set; }
        
        public AlarmType AlarmType { get; set; }

        public Alarm Alarm { get; set; } = null;
    }

    public enum AlarmType
    {
        Too_Low = 0,
        Low = 1,
        Ok = 2,
        High = 3,
        Too_High = 4
    }

    public enum DataType
    {
        Alarm = 0,
        Co2 = 1,
        Temperature = 2,
        Humidite = 3
    }
}