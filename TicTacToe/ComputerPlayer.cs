using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public abstract class ComputerPlayer : Player
    {
        public ComputerPlayer(string name, Piece piece, TicGame ticGame)
            : base(name, piece, ticGame)
        {
        }
    }
}
