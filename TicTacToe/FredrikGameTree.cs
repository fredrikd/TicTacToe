using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum Evaluation {Losable, Drawable, Winnable};

    // Respresenterar en nod i spelträdet som används av Fredrik AI.
    public class FredrikGameTree
    {
        public Board TheBoard { get; set; }
        public Evaluation? TheEvaluation { get; set; }
        public bool Evaluated { get; set; }
        public List<FredrikGameTree> Children { get; set; }

        public FredrikGameTree()
        {
            TheBoard = null;
            TheEvaluation = null;
            Evaluated = false;
            Children = new List<FredrikGameTree>();
        }

        public FredrikGameTree(Board board)
        {
            TheBoard = board;
            TheEvaluation = null;
            Evaluated = false;
            Children = new List<FredrikGameTree>();
        }

        public Evaluation? Evaluate()
        {
            if (Evaluated) return TheEvaluation;
            return null;
        }
    }
}
