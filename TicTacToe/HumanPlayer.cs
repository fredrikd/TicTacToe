using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, Piece piece, TicGame ticGame)
            : base(name, piece, ticGame)
        {
        }

        public override void NotifyGameStarts()
        {
        }

        public override void NotifyTurn()
        {
            SubscribeToPanelClicks(true);
        }

        public override void NotifyGameStops()
        {
            SubscribeToPanelClicks(false);
        }

        private void SubscribeToPanelClicks(bool wantsToSubscribe)
        {
            if (wantsToSubscribe) MyGame.ticPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(PlayerClicksPanel);
            else MyGame.ticPanel.MouseClick -= new System.Windows.Forms.MouseEventHandler(PlayerClicksPanel);
        }

        private void PlayerClicksPanel(object sender, MouseEventArgs e)
        {
            Point clickPoint = new Point(e.X, e.Y);
            Point clickCell = MyGame.ticPanel.WhichCell(clickPoint);
            SubscribeToPanelClicks(false);
            MyGame.MakeMove(new Move(clickCell, PlayerPiece));
        }
    }
}
