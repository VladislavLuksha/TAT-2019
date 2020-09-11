using System;

namespace dev_6
{
    /// <summary>
    /// This is Command abstract class 
    /// </summary>
    abstract class Command
    {
        /// <summary>
        /// This is an object of an class of autoShow 
        /// </summary>
        public AutoShow AutoShow { get; set; }

        /// <summary>
        /// This method excecutes specific commands
        /// </summary>
        /// <returns></returns>
        public abstract void Excecute();

        /// <summary>
        /// This method cancels specific commands
        /// </summary>
        public abstract void Undo();
        /// <summary>
        /// This is constructor class
        /// </summary>
        /// <param name="autoShow"></param>
        public Command(AutoShow autoShow)
        {
            AutoShow = autoShow;
        }
        /// <summary>
        /// This method prints the result our methods
        /// </summary>
        /// <param name="result"></param>
        public void PrintResult(double result)
        {
            Console.WriteLine($"Result = {result}");
        }
    }
}
