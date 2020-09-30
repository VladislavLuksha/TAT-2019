using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class CellRangeException:Exception
    {
        public CellRangeException(string message) : base(message) {}
    }
}
