using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class MicheleAI : ComputerPlayer
    {
            private TicGame ticGame;
        public MicheleAI(string name, Piece piece, TicGame ticGame)
            : base(name, piece, ticGame)
        {
        }

        // Jag (Fredrik) lade till en tom implementation i Micheles klass
        // för att programmet ska fungera efter att jag lagt till en motsvarande
        // abstrakt metod i basklassen.
        public override void NotifyGameStarts()
        {
        }

        public override void NotifyTurn()
        {
            MyGame.MakeMove(new Move(2, 1, PlayerPiece));
            //board.pieces[0, 0] = PlayerPiece;
        }

        // Jag (Fredrik) lade till en tom implementation i Micheles klass
        // för att programmet ska fungera efter att jag lagt till en motsvarande
        // abstrakt metod i basklassen.
        public override void NotifyGameStops()
        {
        }
    }
}
    


