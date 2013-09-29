using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Move
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Piece P { get; set; }

        public Move(int x, int y, Piece p)
        {
            X = x;
            Y = y;
            P = p;
        }
    }
}
