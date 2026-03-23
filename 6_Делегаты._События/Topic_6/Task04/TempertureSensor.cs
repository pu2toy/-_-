using System;
namespace Task04
{
    public class TempertureSensor
    {
        public event EventHandler? changedTemp;

        public void TemperatureChanged()
        {
            changedTemp?.Invoke(this, EventArgs.Empty);
        }
    }
}

