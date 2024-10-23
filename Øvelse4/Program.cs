using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    /// <summary>
    /// Lite version of car-mechanic simulator
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args">Arguements for program initiation</param>
        static void Main(string[] args)
        {
            bool openShop = true;
            Queue<Vehicle> carShop = new Queue<Vehicle>();
            Stack<Vehicle> repairedCars = new Stack<Vehicle>();
            while (openShop)
            {
                Console.Clear();
                Console.WriteLine("Tryk A for at tilføje en bil\nTryk R for at reparere en bil\nTryk P for at se reparerede og ventende biler\nTryk Escape for at lukke butikken");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        AddNewVehicle(carShop);
                        break;
                    case ConsoleKey.R:
                        RepairCar(carShop, repairedCars);
                        break;
                    case ConsoleKey.P:
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
        #region Functions
        /// <summary>
        /// Function to add a new car to the queue needing repairs
        /// </summary>
        /// <param name="queue">Queue for cars needing repair</param>
        static void AddNewVehicle(Queue<Vehicle> queue)
        {
            string inputOwner;
            string inputLicenseplate;
            string inputType;
            bool invalidInput = true;
            Vehicle vehicle = null;
            while (invalidInput)
            {
                Console.Clear();
                Console.WriteLine("Klientens navn:");
                inputOwner = Console.ReadLine();
                Console.WriteLine("Bilens nummerplade");
                inputLicenseplate = Console.ReadLine();
                Console.WriteLine("Bilens type (Pickup/Hatchback/Van)");
                inputType = Console.ReadLine();
                switch (inputType.ToLower())
                {
                    case "pickup":
                        vehicle = new Pickup(inputOwner, inputLicenseplate);
                        invalidInput = false;
                        break;
                    case "hatchback":
                        vehicle = new Hatchback(inputOwner, inputLicenseplate);
                        invalidInput = false;
                        break;
                    case "van":
                        vehicle = new Van(inputOwner, inputLicenseplate);
                        invalidInput = false;
                        break;
                    default:
                        break;
                }
            }
            queue.Enqueue(vehicle);
        }
        /// <summary>
        /// Function to initiate repair of first car in the queue
        /// </summary>
        /// <param name="queue">Repairqueue</param>
        /// <param name="stack">Finished cars</param>
        static void RepairCar(Queue<Vehicle> queue, Stack<Vehicle> stack)
        {
            Console.Clear();
            stack.Push(queue.Dequeue());
            Console.WriteLine("Cars in repairqueue now:");
            foreach (Vehicle car in queue)
            {
                Console.WriteLine(car.Owner + " " + car.Licenseplate + " " + car.Type);
            }
            Console.WriteLine("\nRepaired cars now:");
            foreach (Vehicle car in stack)
            {
                Console.WriteLine(car.Owner + " " + car.Licenseplate + " " + car.Type);
            }
            Console.WriteLine("\nTryk enter for at fortsætte");
            Console.ReadKey();
        }
        /// <summary>
        /// Function to view the repairqueue and cars already repaired
        /// </summary>
        /// <param name="queue">Repairqueue</param>
        /// <param name="stack">Finished cars</param>
        static void PrintCars(Queue<Vehicle> queue, Stack<Vehicle> stack)
        {
            Console.Clear();
            Console.WriteLine("Cars in repairqueue:");
            foreach (Vehicle car in queue)
            {
                Console.WriteLine(car.Owner + " " + car.Licenseplate + " " + car.Type);
            }
            Console.WriteLine("\nRepaired cars:");
            foreach (Vehicle car in stack)
            {
                Console.WriteLine(car.Owner + " " + car.Licenseplate + " " + car.Type);
            }
            Console.WriteLine("\nTryk enter for at fortsætte");
            Console.ReadKey();
        }
        #endregion
    }
}