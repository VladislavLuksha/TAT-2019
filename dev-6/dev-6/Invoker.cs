using System;

namespace dev_6
{
    /// <summary>
    /// This class calls to execute some request.
    /// </summary>
    class Invoker
    {
        public  Command Command { get; set; }

        public int  RunCommands()
        {
            return (Command.Excecute());
        }

        public void UndoCommands()
        {
            Command.Undo();
        }
    }
}
