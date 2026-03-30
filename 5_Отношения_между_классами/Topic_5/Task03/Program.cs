namespace Task03
{
    class Program
    {
        public static void Main()
        {
            Vehicle[] vehicles = new Vehicle[10];
            GenerateArray(vehicles);
            PrintArray(vehicles);
            Console.WriteLine("\nОтсортированный массив: ");
            SortVehicles(vehicles);
            PrintArray(vehicles);
            Console.WriteLine("\nФильтрация по типу интерфейса:");
            FiltredByType(vehicles, "IDiesel");
        }

        static void GenerateArray(Vehicle[] vehicles)
        {
            Random rnd = new Random();
            for (int i = 0; i < vehicles.Length; i++)
            {
                int val = rnd.Next(0, 2);
                if (val == 0)
                {
                    vehicles[i] = new Truck(rnd.Next(100, 180));
                }
                else
                {
                    vehicles[i] = new ElectricCar(rnd.Next(150, 250));
                }
            }
        }
        static void PrintArray(Vehicle[] vehicles)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                vehicles[i].Drive();

                if (vehicles[i] is Truck truck)
                {
                    truck.DieselInfo();
                }
                if (vehicles[i] is ElectricCar car)
                {
                    car.BatteryInfo();
                }
            }
        }
        static void SortVehicles(Vehicle[] vehicles)
        {
            Array.Sort(vehicles, (a, b) =>
            {
                string typeA = a is IDiesel ? "IDiesel" : "IElectric";
                string typeB = b is IDiesel ? "IDiesel" : "IElectric";

                return typeA.CompareTo(typeB);
            });
        }

        static void FiltredByType(Vehicle[] vehicles, string type)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (type == "IDiesel" && vehicles[i] is IDiesel)
                {
                    Console.WriteLine(vehicles[i].GetType().ToString());
                    vehicles[i].Drive();
                }
                if (type == "IElectric" && vehicles[i] is IElectric)
                {
                    Console.WriteLine(vehicles[i].GetType().ToString());
                    vehicles[i].Drive();
                }
            }
        }
    }
}