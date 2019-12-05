using System;

namespace dev_6
{
    /// <summary>
    /// This class is car(receiver)
    /// </summary>
    public class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int NumberOfCars { get; set; }
        public int CostOneModel { get; set; }

        /// <summary>
        /// This is constructor class.
        /// </summary>
        /// <param name="marka"></param>
        /// <param name="model"></param>
        /// <param name="numberOfCars"></param>
        /// <param name="costOneModel"></param>
        public Car(string marka,string model,int numberOfCars,int costOneModel)
        {
            Marka = marka;
            Model = model;
            NumberOfCars = numberOfCars;
            CostOneModel = costOneModel;
        }
    
        public int CountTypes()
        {
            return 1;
        }

        public int CountAll()
        {
            return 1;
        }
        public int AveragePrice()
        {
            return 1;
        }
        public int AveragePriceType()
        {
            return 1;
        }
         
        public void Exit()
        {
            Environment.FailFast("exit");
        }
    }
}
