using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TicTacToe
{
    class Piece
    {
        public Bitmap Icon { get; set; }

        public Piece(Bitmap icon)
        {
            Icon = icon;
        }
    }
}
