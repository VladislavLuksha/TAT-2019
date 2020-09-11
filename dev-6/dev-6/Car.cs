
namespace dev_6
{
    /// <summary>
    /// This class is car(receiver)
    /// </summary>
    public class Car
    {
        /// <summary>
        /// This is the marka of car
        /// </summary>
        public string Mark { get; set; }
        /// <summary>
        /// This is the model of car
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// This is the number of car
        /// </summary>
        public double NumberOfCars { get; set; }
        /// <summary>
        /// This is the cost of one model
        /// </summary>
        public double CostOneModel { get; set; }

        /// <summary>
        /// This is constructor class.
        /// </summary>
        /// <param name="marka"></param>
        /// <param name="model"></param>
        /// <param name="numberOfCars"></param>
        /// <param name="costOneModel"></param>
        public Car(string mark,string model,int numberOfCars,int costOneModel)
        {
            Mark = mark;
            Model = model;
            NumberOfCars = numberOfCars;
            CostOneModel = costOneModel;
        }
    }
}
