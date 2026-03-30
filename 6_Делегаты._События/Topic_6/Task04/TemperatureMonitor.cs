using System;
namespace Task04
{
    public class TemperatureMonitor
    {
        public void EnableSystems(TempertureSensor sensor, CoolingSystem cooling, AlarmSystem alarm)
        {
            sensor.changedTemp += alarm.OnChangedTemp;
            sensor.changedTemp += cooling.OnChangedTemp;
        }
    }
}

