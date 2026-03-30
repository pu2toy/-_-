using System;
namespace Task03
{
    public class ElectricCar : Vehicle, IElectric
    {
        public ElectricCar(int speed)
        {
            maxSpeed = speed;
        }

        public override void Drive()
        {
            Console.WriteLine("Электрокар едет со скоростью " + maxSpeed);
        }

        public void BatteryInfo()
        {
            Random rnd = new Random();
            Console.WriteLine("Осталось заряда батареи: " + rnd.Next(0, 100) + "%");
        }
    }
}

