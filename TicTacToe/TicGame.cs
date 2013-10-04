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
        public TicPanel ticPanel;

        private GameState state;
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
            player1.NotifyGameStarts();
            player2.NotifyGameStarts();
            ticPanel.Invalidate();
            player1sTurn();
        }

        public void AbortGame()
        {
            player1.NotifyGameStops();
            player1 = null;

            player2.NotifyGameStops();
            player2 = null;

            messageLabel.Text = "Game aborted.";
        }

        public void MakeMove(Move move)
        {
            
            

            if (state == GameState.Player1)
                if (board.AbleMove(move)) // true skall ersätta med Dennis metoden
                {
                    board.MakeMove(move);
                    ticPanel.Invalidate();
                    if (board.BoardFull())
                    {
                        // kolla gameover metoden
                        return;
                    }
                    else
                    {
                        player2sTurn();
                    }
                }
                else
                {
                    player1sTurn();
                    return;
                }
            else if (state == GameState.Player2)
                if (board.AbleMove(move)) // true skall ersätta med Dennis metoden
                {
                    board.MakeMove(move);
                    ticPanel.Invalidate();
                    if (board.BoardFull())
                    {
                        // kolla gameover metoden
                        return;
                    }
                    else
                    {
                        player1sTurn();
                    }
                }
                else
                {
                    player2sTurn();
                    return;
                }
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
