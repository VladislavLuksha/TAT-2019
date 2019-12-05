using System;

namespace dev_6
{
    class Exit:Command
    {
        public Exit(Car car) : base(car) { }

        public override int Excecute()
        {
            return 0;
        }

        public override void Undo()
        {
            Car.Exit();
        }
    }
}
