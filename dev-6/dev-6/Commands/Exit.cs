
namespace dev_6
{
    /// <summary>
    /// This class creates a new command such as exit from programm
    /// </summary>
    class Exit:Command
    {
        /// <summary>
        /// Thsi is constructor class
        /// </summary>
        /// <param name="autoShow"></param>
        public Exit(AutoShow autoShow) : base(autoShow) { }

        /// <summary>
        /// This method excecutes of the method exit
        /// </summary>
        public override void Excecute()
        {
            AutoShow.Exit();
        }

        public override void Undo()
        {
        }
    }
}
