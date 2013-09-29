using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
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
                    pieces[x, y] = board.pieces[x, y];
                }
            }
        }

        public void MakeMove(Move m)
        {
            pieces[m.X, m.Y] = m.P;
        }

    }
}
