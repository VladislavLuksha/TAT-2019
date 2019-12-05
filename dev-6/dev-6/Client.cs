using System;
using System.Collections.Generic;

namespace dev_6
{
    /// <summary>
    /// This class creates commands and sets her receiver. 
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            //List<Car> cars = InitialCarList();
            Car car = new Car("BMW", "x5", 3, 10000);

            CareControl(car, invoker);
        }

        private static List<Car> InitialCarList()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("BMW", "x5", 3, 10000));
            cars.Add(new Car("Ford", "Fokus", 3, 4000));
            return cars;
        }

        private static void PrintResult(int result)
        {
            Console.WriteLine($"Result = {result}");
        }

        private static void CareControl(Car car, Invoker receiver)
        {
            Console.WriteLine("What does car do?");
            string command = Console.ReadLine();
            switch (command)
            {
                case "average price":
                    {
                        receiver.Command = new AveragePrice(car);
                        PrintResult(receiver.RunCommands());
                    }
                    ; break;
                case "average price type":
                    {
                        receiver.Command = new AveragePriceType(car);
                        PrintResult(receiver.RunCommands());
                    }
                    ; break;
                case "count all":
                    {
                        receiver.Command = new CountAll(car);
                        PrintResult(receiver.RunCommands());
                    }
                    ; break;
                case "count types":
                    {
                        receiver.Command = new CountTypes(car);
                        PrintResult(receiver.RunCommands());
                    }
                    ; break;
                case "exit":
                    {
                        receiver.Command = new Exit(car);
                        receiver.RunCommands();
                    }
                    ; break;
            }
        }
    }
}
