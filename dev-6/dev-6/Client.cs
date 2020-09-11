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
            List<Car> cars = InitialCarList();
            AutoShow autoShow = new AutoShow(cars);
            CareControl(autoShow, invoker);
        }

        private static List<Car> InitialCarList()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("BMW", "x5", 3, 20000));
            cars.Add(new Car("BMW", "x9", 3, 20000));
            cars.Add(new Car("Ford", "Fokus", 3, 4000));
            cars.Add(new Car("BMW", "x7", 3, 20000));
            return cars;
        }

        private static void CareControl(AutoShow autoShow , Invoker receiver)
        {
            while(true)
            {
                Console.WriteLine("What does car do?");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "average price":
                        {
                            try
                            {
                                receiver.Command = new AveragePrice(autoShow);
                                receiver.RunCommands();
                            }
                            catch(NoSuchAnElementException exception)
                            {
                                Console.WriteLine(exception.Message);
                            }
                        }
                        ; break;
                    case "average price type":
                        {
                            try
                            {
                                receiver.Command = new AveragePriceType(autoShow, "BMW");
                                receiver.RunCommands();
                            }
                            catch(NoSuchAnElementException exception)
                            {
                                Console.WriteLine(exception.Message); 
                            }
                        }
                        ; break;
                    case "count all":
                        {
                            receiver.Command = new CountAll(autoShow);
                            receiver.RunCommands();
                        }
                        ; break;
                    case "count types":
                        {
                            receiver.Command = new CountTypes(autoShow);
                            receiver.RunCommands();
                        }
                        ; break;
                    case "exit":
                        {
                            receiver.Command = new Exit(autoShow);
                            receiver.RunCommands();
                        }
                        ; break;
                }
            }
        }
    }
}
