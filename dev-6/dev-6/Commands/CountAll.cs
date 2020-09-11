
namespace dev_6
{
    class CountAll : Command
    {
        /// <summary>
        /// This is constructor class
        /// </summary>
        /// <param name="autoShow"></param>
        public CountAll(AutoShow autoShow) : base(autoShow) { }

        /// <summary>
        /// This is method prints the result of the method count all
        /// </summary>
        public override void Excecute()
        {
           PrintResult(AutoShow.CountAll());
        }

        /// <summary>
        /// This method cancels of the method count all
        /// </summary>
        public override void Undo()
        {
            AutoShow.CountAll();
        }
    }
}
