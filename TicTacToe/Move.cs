using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TicTacToe
{
    public class Move
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Piece P { get; set; }

        public Move(int x, int y, Piece piece)
        {
            X = x;
            Y = y;
            P = piece;
        }

        public Move(Point point, Piece piece)
        {
            X = point.X;
            Y = point.Y;
            P = piece;
        }
    }
}
