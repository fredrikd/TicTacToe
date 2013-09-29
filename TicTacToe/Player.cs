using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    abstract class Player
    {
        public Piece PlayerPiece { get; set; }

        public Player(Piece piece)
        {
            PlayerPiece = piece;
        }
    }
}
