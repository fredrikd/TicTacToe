using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    enum GameState { Stopped, Player1, Player2 }

    class TicGame
    {
        private GameState state;
        private TicPanel ticPanel;
        private Label messageLabel;
        private Player player1;
        private Player player2;

        public TicGame(TicPanel ticPanel, Label messageLabel)
        {
            this.state = GameState.Stopped;
            this.ticPanel = ticPanel;
            this.messageLabel = messageLabel;
            this.player1 = null;
            this.player2 = null;
        }

        public void StartGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void StopGame()
        {
            player1 = null;
            player2 = null;

        }
    }
}
