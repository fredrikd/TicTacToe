using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicForm : Form
    {
        private TicGame ticGame;

        public TicForm()
        {
            InitializeComponent();
            ticGame = new TicGame(ticPanel, messageLabel);
        }

        public void Start()
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;
            player1Box.Enabled = false;
            player2Box.Enabled = false;
        }

        public void Stop()
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            player1Box.Enabled = true;
            player2Box.Enabled = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}
