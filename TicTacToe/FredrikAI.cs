using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    // Fredriks AI-spelare.
    //
    // Bygger rekursivt upp och analyserar ett spelträd över alla giltiga
    // framtida drag, dvs. brute forcear hela skräpet.
    //
    // AI:n väljer i första hand slumpmässigt något av de drag som kommer
    // att garantera en framtida vinst. Om ett sådant drag inte existerar
    // väljer den slumpmässigt ett drag som garanterar att den aldrig kommer
    // att förlora. I sista hand väljer den slumpmässigt vilket (giltigt)
    // drag som helst, men eftersom man i Tic-tac-toe alltid torde kunna
    // vinna eller spela så att det blir ogjort (förutsatt att man spelar
    // optimalt), så torde det sistnämnda fallet aldrig inträffa.
    //
    // OBS! Detta beteende medför att ifall AI:n har hittat en vinnande
    // strategi så väljer den inte nödvändigtvis genast ett drag som ger
    // omedelbar vinst trots att den kanske direkt skulle kunna få tre i
    // rad. Istället kan den "retas" med motspelaren och slumpmässigt
    // välja ett annat subträd i spelträdet, dock ett sådant subträd som
    // garanterar att den i vilket fall som helst kommer att vinna förr
    // eller senare oberoende av motspelarens framtida drag.
    //
    // OBS2! Fredrik AI (1) och Fredrik AI (2) som man kan välja i spelet
    // är bara olika instanser av denna klass. Det finns två instanser för
    // att Fredrik AI ska kunna spela mot sig själv.
    //
    public class FredrikAI: ComputerPlayer
    {
        public FredrikAI(string name, Piece piece, TicGame ticGame)
            : base(name, piece, ticGame)
        {
        }

        // Overridear den abstrakta metoden med en tom implementation
        // eftersom Fredrik AI inte behöver göras några särskilda
        // förberedelser när spelet startas.
        public override void NotifyGameStarts()
        {
        }

        public override void NotifyTurn()
        {
            Piece opponentPiece = (PlayerPiece == TicResources.Cross ? TicResources.Knot : TicResources.Cross);
            FredrikGameTree tree = new FredrikGameTree(MyGame.board, null, PlayerPiece, opponentPiece);
            tree.BuildTree();

            Move winningMove = tree.FindWinningMove();
            
            if (winningMove != null)
            {
                Console.WriteLine("Fredrik AI har en vinnande strategi!");
                MyGame.MakeMove(winningMove);
                return;
            }

            Move nonLosingMove = tree.FindNonLosingMove();

            if (nonLosingMove != null)
            {
                Console.WriteLine("Fredrik AI gör ett drag som garanterar icke-förlust.");
                MyGame.MakeMove(nonLosingMove);
                return;
            }

            // Man torde aldrig komma hit.
            Console.WriteLine("Fredrik AI är helt borttappad och gör något konstigt drag...");
            MyGame.MakeMove(tree.FindRandomValidMove());
        }

        // Overridear den abstrakta metoden med en tom implementation
        // eftersom Fredrik AI inte behöver göras något särskilt
        // när spelet slutar.
        public override void NotifyGameStops()
        {
        }
    }
}
