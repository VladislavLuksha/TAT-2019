using System;
using System.Collections.Generic;

namespace dev_6
{
    class AveragePrice:Command
    {
        public AveragePrice(Car car) : base(car) { }

        public override int Excecute()
        {
            return Car.AveragePrice();
        }

        public override void Undo()
        {
            Car.AveragePrice();
        }
    }
}
