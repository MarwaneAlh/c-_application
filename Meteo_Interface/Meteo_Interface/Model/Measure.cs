namespace Meteo_Interface.Model
{
    public class Measure
    {
        public Measure(int id, DataType type, int data, AlarmType alarm)
        {
            Id = id;
            ConfigStatus = false;
            Type = type;
            Data = data;
            LastUpdate = 0;
            Alarm = alarm;
        }

        public int Id { get; set; }

        public bool ConfigStatus { get; set; }

        public DataType Type { get; set; }

        public int Data { get; set; }

        public int LastUpdate { get; set; }
        
        public AlarmType Alarm { get; set; }
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