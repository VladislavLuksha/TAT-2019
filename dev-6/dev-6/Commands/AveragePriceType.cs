using System;

namespace dev_6
{
    class AveragePriceType : Command
    {
        public AveragePriceType(Car car) : base(car) { }

        public override int Excecute()
        {
            return Car.AveragePriceType();
        }

        public override void Undo()
        {
            Car.AveragePriceType();
        }
    }
}
