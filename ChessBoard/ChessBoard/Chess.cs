using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Chess
    {
        Cell[,] chess = new Cell[8,8];
       
        public Chess()
        {
            for(int i = 0;i < 8;i++)
            {
                char symbol = 'a';
                for (int j = 0;j < 8;j++)
                {
                    Cell cell = new Cell();
                    cell.Row = symbol;
                    cell.Columb = i+1;
                    if((i+j) % 2 == 0)
                    {
                        cell.Collor = "black";
                    }
                    else
                    {
                        cell.Collor = "white";
                    }
                    chess[i, j] = cell;
                    symbol++;
                }
            }
        }
        
        public string CellCollorSearch(Cell cell)
        {
            string collor = "";
            foreach (Cell element in chess)
            {
                if (element.Columb == cell.Columb && element.Row == cell.Row)
                {
                    collor = element.Collor;
                    break;
                }
            }
            return collor;
        }

        public void CellLocation(Cell firstCell,Cell secondCell)
        {
            if(firstCell.Columb == secondCell.Columb)
            {
                Console.WriteLine("Cell are gorizontally!");
            }
            if(firstCell.Row == secondCell.Row)
            {
                Console.WriteLine("Cell are vertically");
            }
            if((firstCell.Row + firstCell.Columb) % 2 == 0 && (secondCell.Columb+secondCell.Row) % 2 == 0)
            {
                Console.WriteLine("Cell are diagonally!!");
            }
        }
    }
}
