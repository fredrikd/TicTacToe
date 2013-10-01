using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TicTacToe
{
    public partial class TicForm : Form
    {
        private TicGame ticGame;
        private Dictionary<string, Player> computerPlayerDict;
        private FredrikAI fredrikAI;

        public TicForm()
        {
            InitializeComponent();
            ticGame = new TicGame(ticPanel, messageLabel);
            computerPlayerDict = new Dictionary<string, Player>();

            // Initialt anges att datorspelarna ska spela med kryss,
            // men det justeras när spelet startas.
            fredrikAI = new FredrikAI("Fredrik AI", TicResources.Cross, ticGame);
            computerPlayerDict["Fredrik AI"] = fredrikAI;
            player1Box.Items.Add("Fredrik AI");
            player2Box.Items.Add("Fredrik AI");

        }

        public Player WhoIsPlayer1()
        {
            Player player;
            if (computerPlayerDict.ContainsKey(player1Box.Text))
                player = computerPlayerDict[player1Box.Text];
            else
                player = new HumanPlayer(player1Box.Text, TicResources.Cross, ticGame);
            return player;
        }

        public Player WhoIsPlayer2()
        {
            Player player;
            if (computerPlayerDict.ContainsKey(player2Box.Text))
                player = computerPlayerDict[player2Box.Text];
            else
                player = new HumanPlayer(player2Box.Text, TicResources.Cross, ticGame);
            return player;
        }

        public void Start()
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;
            player1Box.Enabled = false;
            player2Box.Enabled = false;
            Player player1 = WhoIsPlayer1();
            Player player2 = WhoIsPlayer2();
            Board board = new Board();
            ticPanel.CurrentBoard = board;
            ticGame.StartGame(board, player1, player2);
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

        private void ticPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickPoint = new Point(e.X, e.Y);
            Console.WriteLine(ticPanel.WhichCell(clickPoint));
        }
    }
}
