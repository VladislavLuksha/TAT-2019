using System;
using System.Collections.Generic;

namespace dev_6
{
    class AveragePrice:Command
    {
        /// <summary>
        /// This is constructor class
        /// </summary>
        /// <param name="autoShow"></param>
        public AveragePrice(AutoShow autoShow) : base(autoShow) { }

        /// <summary>
        /// This method prints the result of the method average price
        /// </summary>
        public override void Excecute()
        {
           PrintResult(AutoShow.AveragePrice());
        }

        /// <summary>
        /// This methods cancels of the method average price
        /// </summary>
        public override void Undo()
        {
            AutoShow.AveragePrice();
        }
    }
}
