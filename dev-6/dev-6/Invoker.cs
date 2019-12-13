
namespace dev_6
{
    /// <summary>
    /// This class calls to execute some request.
    /// </summary>
    class Invoker
    {
        /// <summary>
        /// This is an object of an abstract class of command 
        /// </summary>
        public  Command Command { get; set; }

        /// <summary>
        /// This method calls a command to execute a request 
        /// </summary>
        public void  RunCommands()
        {
            Command.Excecute();
        }

        /// <summary>
        /// This method calls a command to execute a request
        /// </summary>
        public void UndoCommands()
        {
            Command.Undo();
        }
    }
}
