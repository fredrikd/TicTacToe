using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    enum GameState { Stopped, Player1, Player2 }

    public class TicGame
    {
        private GameState state;
        private TicPanel ticPanel;
        private Label messageLabel;
        private Board board;
        private Player player1;
        private Player player2;

        public TicGame(TicPanel ticPanel, Label messageLabel)
        {
            this.board = new Board();
            this.state = GameState.Stopped;
            this.ticPanel = ticPanel;
            this.messageLabel = messageLabel;
            this.player1 = null;
            this.player2 = null;
        }

        public void StartGame(Board board, Player player1, Player player2)
        {
            this.board = board;
            this.player1 = player1;
            this.player2 = player2;
            player1sTurn();
        }

        public void StopGame()
        {
            player1 = null;
            player2 = null;
        }

        public void MakeMove(Move move)
        {
            board.MakeMove(move);
            ticPanel.Invalidate();
        }

        private void player1sTurn()
        {
            state = GameState.Player1;
            messageLabel.Text = "Player 1's turn.";
            player1.NotifyTurn();
        }

        private void player2sTurn()
        {
            state = GameState.Player2;
            messageLabel.Text = "Player 2's turn.";
            player2.NotifyTurn();
        }
    }
}
