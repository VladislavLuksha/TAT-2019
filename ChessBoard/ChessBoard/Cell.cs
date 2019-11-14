using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    public class Cell
    {
        public int Columb { get; set; }
        public char Row { get; set; }
        public string Collor { get; set; }
        public Cell() { }

        public Cell(int columb, char row)
        {
            this.Columb = columb;
            this.Row = row;
            if ((columb > 9 || columb < 0) && (row < 'a' || row > 'g'))
            {
                throw new CellRangeException("Exit abroad cell!!!");
            } 
        }

    }
}
