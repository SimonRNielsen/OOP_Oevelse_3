using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputOwner = string.Empty;
            string inputLicenseplate = string.Empty;
            string inputType = string.Empty;
            bool openShop = true;
            Queue<Vehicle> carShop = new Queue<Vehicle>();
            Stack<Vehicle> repairedCars = new Stack<Vehicle>();
            while (openShop)
            {
                var keypress = Console.ReadKey(true);
                Console.WriteLine("Tryk A for at tilføje en bil\nTryk S for at reparere en bil\nTryk C for at se reparerede og ventende biler\nTryk escape for at lukke butikken");
                switch (keypress.Key)
                {
                    case ConsoleKey.A:
                        AddNewVehicle(carShop);
                        break;
                    case ConsoleKey.S:
                        RepairCar(carShop, repairedCars);
                        break;
                    case ConsoleKey.D:
                        PrintCars(carShop, repairedCars);
                        break;
                    case ConsoleKey.Escape:
                        openShop = false;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queue"></param>
        static void AddNewVehicle(Queue<Vehicle> queue)
        {
            Console.Clear();
            string inputOwner = string.Empty;
            string inputLicenseplate = string.Empty;
            string inputType = string.Empty;
            bool invalidInput = true;
            while (invalidInput)
            {
                Console.WriteLine("Input client name:");
                inputOwner = Console.ReadLine();
                Console.WriteLine("Input car licenseplate");
                inputLicenseplate = Console.ReadLine();
                Console.WriteLine("Input cartype (Pickup/Hatchback/Van)");
                inputType = Console.ReadLine();
                switch (inputType.ToLower())
                {
                    case "pickup":
                        invalidInput = false;
                        break;
                    case "hatchback":
                        invalidInput = false;
                        break;
                    case "van":
                        invalidInput = false;
                        break;
                    default:
                        break;
                }
            }
            Vehicle vehicle = null;
            switch (inputType.ToLower())
            {
                case "pickup":
                    vehicle = new Pickup(inputOwner, inputLicenseplate);
                    break;
                case "hatchback":
                    vehicle = new Hatchback(inputOwner, inputLicenseplate);
                    break;
                case "van":
                    vehicle = new Van(inputOwner, inputLicenseplate);
                    break;
            }
            queue.Enqueue(vehicle);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="queue"></param>
        /// <param name="stack"></param>
        static void RepairCar(Queue<Vehicle> queue, Stack<Vehicle> stack)
        {
            Console.Clear();
            stack.Push(queue.Dequeue());
            Console.WriteLine("Cars in repairqueue now:");
            foreach (Vehicle car in queue)
            {
                if (car == null)
                {
                    Console.WriteLine("No cars in queue");
                }
                else
                {
                    Console.WriteLine(car.Owner + " " + car.Licenseplate + " " + car.Type);
                }
            }
            Console.WriteLine("Repaired cars now:");
            foreach (Vehicle car in stack)
            {
                if (car == null)
                {
                    Console.WriteLine("No cars repaired");
                }
                else
                {
                    Console.WriteLine(car.Owner + " " + car.Licenseplate + " " + car.Type);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="queue"></param>
        /// <param name="stack"></param>
        static void PrintCars(Queue<Vehicle> queue, Stack<Vehicle> stack)
        {
            Console.Clear();
            Console.WriteLine("Cars in repairqueue:");
            foreach (Vehicle car in queue)
            {
                if (car == null)
                {
                    Console.WriteLine("No cars in queue");
                }
                else
                {
                    Console.WriteLine(car.Owner + " " + car.Licenseplate + " " + car.Type);
                }
            }
            Console.WriteLine("Repaired cars:");
            foreach (Vehicle car in stack)
            {
                if (car == null)
                {
                    Console.WriteLine("No cars repaired");
                }
                else
                {
                    Console.WriteLine(car.Owner + " " + car.Licenseplate + " " + car.Type);
                }
            }
        }
    }
}