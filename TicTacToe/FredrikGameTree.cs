using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class FredrikExtensionMethods
    {
        // Letar igenom en lista efter de element som uppfyller ett predikat och
        // returnerar slumpmässigt ett av detta. Om inget sådant element existerar
        // returneras defaultvärdet för typen i listan. Påminner om Find, men
        // Find bryr sig inte om att randomisera ordentligt bland kandidaterna.
        public static T FindAndRandomise<T>(this List<T> list, Predicate<T> match)
        {
            List<T> valid = list.FindAll(match);
            if (valid.Count == 0) return default(T);
            else return valid[TicResources.Rand.Next(0, valid.Count)];
        }
    }

    // Respresenterar ett spelträd som används av Fredrik AI.
    public class FredrikGameTree
    {
        public Board TheBoard { get; set; }
        public Move TheMove { get; set; }
        public Piece MyPiece { get; set; }
        public Piece OpponentPiece { get; set; }
        public List<FredrikGameTree> Children { get; set; }

        private const int sizeX = 3;
        private const int sizeY = 3;

        public FredrikGameTree(Board board, Move move = null, Piece myPiece = null, Piece opponentPiece = null)
        {
            TheBoard = board;
            TheMove = move;
            MyPiece = myPiece;
            OpponentPiece = opponentPiece;
            Children = new List<FredrikGameTree>();
        }

        // Hjälpfunktion som anropas av FindWinningMove()
        // och rekursivt av sig själv.
        private FredrikGameTree findWinningChild()
        {
            return Children.FindAndRandomise(f => (f.Children.Count != 0 && f.Children.TrueForAll(g => g.findWinningChild() != null))  // För motspelarens alla drag finns det därefter ett eget drag som har vinnande drag (rekursion).
                                               || (f.Children.Count != 0 && f.Children.TrueForAll(h => h.TheBoard.FindWinner().Winner == MyPiece)) // För motspelarens alla drag kommer man till ett bräde där man själv har vunnit (utan ytterligare drag).
                                               || (f.TheBoard.FindWinner().Winner == MyPiece)); // Draget man gör leder direkt till en vinst (utan att motspelaren ens hinner göra sitt drag).
        }

        // Letar fram ett drag som garanterar vinst oberoende av
        // vilka drag motståndaren gör i framtiden, förutsatt att
        // man själv även gör optimala drag i framtiden. Om ett
        // sådant drag inte existerar returneras null.
        public Move FindWinningMove()
        {
            FredrikGameTree winningChild = findWinningChild();
            return (winningChild == null ? null : winningChild.TheMove);
        }

        // Hjälpfunktion som anropas av FindNonLosingMove()
        // och rekursivt av sig själv.
        public FredrikGameTree findNonLosingChild()
        {
            FredrikGameTree result;
            return Children.FindAndRandomise(f => (f.Children.Count != 0 && f.Children.TrueForAll(g => g.findNonLosingChild() != null)) // För motspelarens alla drag finns det därefter ett eget drag som möjliggör framtida icke-förlust (rekursion).
                                               || (f.Children.Count != 0 && f.Children.TrueForAll(h => h.TheBoard.BoardFinished() && h.TheBoard.FindWinner().Winner != OpponentPiece)) // // För motspelarens alla drag kommer man till ett bräde där spelet är slut och man inte har förlorat.
                                               || (f.TheBoard.BoardFinished() && f.TheBoard.FindWinner().Winner != OpponentPiece)); // Draget man gör leder direkt till ett bräde där spelet är slut och man inte har förlorat.
        }

        // Letar fram ett drag som garanterar att man inte förlorar
        // oberoende av vilka drag motståndaren gör i framtiden,
        // förutsatt att man själv även gör optimala drag i framtiden.
        // Om ett sådant drag inte existerar returneras null.
        // Eftersom denna metod inte garanterar vinst bör man först
        // kolla med hjälp av FindWinningMove() om det är möjligt att
        // göra ett drag som garanterar vinst i framtiden.
        public Move FindNonLosingMove()
        {
            FredrikGameTree nonLosingChild = findNonLosingChild();
            return (nonLosingChild == null ? null : nonLosingChild.TheMove);
        }

        public Move FindRandomValidMove()
        {
            return FindValidMoves().FindAndRandomise(m => true);
        }

        public List<Move> FindValidMoves()
        {
            List<Move> allMoves = new List<Move>();

            for(int y = 0; y < sizeY; y++) {
                for(int x = 0; x < sizeX; x++) {
                    allMoves.Add(new Move(x, y, MyPiece));
                }
            }

            return allMoves.FindAll(m => TheBoard.AbleMove(m));
        }

        public List<FredrikGameTree> FindChildren()
        {
            List<FredrikGameTree> children = new List<FredrikGameTree>();
            Board newBoard;

            if (TheBoard.FindWinner().Winner != null) return children;

            foreach (Move m in FindValidMoves())
            {
                newBoard = new Board(TheBoard);
                newBoard.MakeMove(m);
                // Observera att MyPiece och OpponentPiece kastas om
                // pga. att barnen representerar motspelarens tur.
                children.Add(new FredrikGameTree(newBoard, m, OpponentPiece, MyPiece));
            }

            return children;
        }

        // Bygger rekursive upp spelträdet så att det innehåller
        // alla tänkbara framtida kombinationer av båda spelarna.
        // (Observera att klassens konstruktor bara skapar notnoden.)
        // Lövnoderna representerar situationer där endera spelaren
        // har vunnit eller där spelplanen är full utan att någon
        // nödvändigtvis har vunnit.
        public void BuildTree()
        {
            Children = FindChildren();
            foreach (FredrikGameTree f in Children)
            {
                f.BuildTree();
            }
        }
    }
}
