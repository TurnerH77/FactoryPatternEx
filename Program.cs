using System;
using System.IO;

namespace FactoryPatternEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Wheels? 2? or 4?:");
            Console.WriteLine("--------------------------");
            int userInput = Convert.ToInt32(Console.ReadLine());

            VehicleFactory factory = new VehicleFactory();
            IVehicle myCar = factory.GetVehicle(userInput);
            myCar.Drive();

        }
    }

    public class Car : IVehicle
    {
        public int Wheels { get; set; }
        public bool isCoupe { get; set; }

        public void Drive()
        {
            Console.WriteLine("You now have a Car.");
        }

    }
    public class Motorcycle : IVehicle
    {
        public int Wheels { get; set; }

        public bool hasSideCar { get; set; }

        public void Drive()
        {
            Console.WriteLine("you now have a Motorcycle.");
        }
    }

    public class VehicleFactory
    {
        public IVehicle GetVehicle(int userInput)
        {
            switch (userInput)
            {
                case 2:
                    return new Car();
                case 4:
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }

}
