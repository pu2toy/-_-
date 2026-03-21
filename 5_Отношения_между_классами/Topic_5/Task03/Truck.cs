using System;
namespace Task03
{
    public class Truck : Vehicle, IDiesel
    {
        public Truck(int speed)
        {
            maxSpeed = speed;
        }

        public Truck() { }

        public override void Drive()
        {
            Console.WriteLine("Грузовик едет со скоростью " + maxSpeed);
        }

        public void DieselInfo()
        {
            Random rnd = new Random();
            Console.WriteLine("Осталось дизеля: " + rnd.Next(0, 100) + "%.");
        }
    }
}

