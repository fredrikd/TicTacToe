using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        private const int sizeX = 3;
        private const int sizeY = 3;

        public Piece[,] pieces;

        public Board()
        {
            pieces = new Piece[sizeX, sizeY];
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    pieces[x, y] = null;
                }
            }
        }

        // Skapar ett nytt Board som är en klon av ett existerande Board.
        public Board(Board board)
        {
            pieces = new Piece[sizeX, sizeY];
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    pieces[x, y] = board.pieces[x, y]; //board.pieces 
                }
            }
        }

        public void MakeMove(Move m)
        {
            pieces[m.X, m.Y] = m.P;
        }

        public bool BoardFull()
        {
            bool full = true;
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    if (pieces[x, y] == null)
                    {
                        full = false;
                        // Vill break:a ut från en nästad loop.
                        // C# verkar (i motsats till Java) inte tillåta break med labelangivelse,
                        // så jag får göra Dijkstra ledsen i sin grav och använda lite goto...
                        goto avsluta_loop;
                    }
                }
            }
            avsluta_loop:
            return full;
        }

        //Kollar ifall Move, "m" innehåller ett värde eller ej.
        //Method som returnerar en bool
        public bool AbleMove(Move m)
        {
            if (m == null)
            {
                return false;
            }
            else if (pieces[m.X, m.Y] != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
