using System;

namespace dev_6
{
    class CountTypes : Command
    {
        public CountTypes(Car car) : base(car) { }
      
        public override int  Excecute()
        {
            return Car.CountTypes();
        }

        public override void Undo()
        {
            Car.CountTypes();
        }
    }
}
