using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Chess chess = new Chess();
            Cell firstCell=null, secondCell=null;
            try
            {
                firstCell = new Cell(3, 'a');
                secondCell = new Cell(2, 'a');
            }
            catch(CellRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine(chess.CellCollorSearch(firstCell));
            Console.WriteLine(chess.CellCollorSearch(secondCell));
            chess.CellLocation(firstCell, secondCell);
        }
    }
}
