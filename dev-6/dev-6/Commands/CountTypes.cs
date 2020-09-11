
namespace dev_6
{
    /// <summary>
    /// This class creates a new command such as count types
    /// </summary>
    class CountTypes : Command
    {
        /// <summary>
        /// This is constructor class
        /// </summary>
        /// <param name="autoShow"></param>
        public CountTypes(AutoShow autoShow) : base(autoShow) { }
      
     
        public  override void  Excecute()
        {
            PrintResult(AutoShow.CountTypes());
        }

        public override void Undo()
        {
            AutoShow.CountTypes();
        }
    }
}
