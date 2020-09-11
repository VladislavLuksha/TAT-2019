
namespace dev_6
{
    /// <summary>
    /// This class creates a new command such as average price type.
    /// </summary>
    class AveragePriceType : Command
    {
        private string Marka { get; set; }

        /// <summary>
        /// This is constructor class
        /// </summary>
        /// <param name="autoShow"></param>
        /// <param name="marka"></param>
        public AveragePriceType(AutoShow autoShow, string marka) : base(autoShow)
        {
            this.Marka = marka;
        }

        /// <summary>
        /// This method prints the result of the method average price type
        /// </summary>
        public override void Excecute()
        {
           PrintResult(AutoShow.AveragePriceType(Marka));
        }

        /// <summary>
        /// This method cancels of the method average price type 
        /// </summary>
        public override void Undo()
        {
            AutoShow.AveragePriceType(Marka);
        }
    }
}
