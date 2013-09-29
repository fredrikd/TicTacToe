using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    abstract class ComputerPlayer : Player
    {
        public ComputerPlayer(Piece piece)
            : base(piece)
        {
        }
    }
}
