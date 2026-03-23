namespace Task04
{
    class Program
    {
        public static void Main()
        {
            TempertureSensor tempertureSensor = new TempertureSensor();
            TemperatureMonitor temperatureMonitor = new TemperatureMonitor();
            AlarmSystem alarm = new AlarmSystem();
            CoolingSystem cooling = new CoolingSystem();

            temperatureMonitor.EnableSystems(tempertureSensor, cooling, alarm);
            tempertureSensor.TemperatureChanged();
        }
    }
}