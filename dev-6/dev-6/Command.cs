using System;
using System.Collections.Generic;

namespace dev_6
{
    abstract class Command
    {
        protected Car Car { get; set; }

        public abstract int Excecute();
        public abstract void Undo();
        public Command(Car car)
        {
            Car = car;
        }
    }
}
