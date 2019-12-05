using System;

namespace dev_6
{
    class CountAll : Command
    {
        public CountAll(Car car) : base(car) { }

        public override int Excecute()
        {
            return Car.CountAll();
        }

        public override void Undo()
        {
            Car.CountAll();
        }
    }
}
