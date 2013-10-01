using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, Piece piece, TicGame ticGame)
            : base(name, piece, ticGame)
        {
        }

        public override void NotifyTurn()
        {
            Console.WriteLine(Name + " notified.");
        }
    }
}
