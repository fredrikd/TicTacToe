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
        private MicheleAI micheleAI;
        private TselleckAI tselleckAI;
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
            micheleAI = new MicheleAI("Michele AI", TicResources.Cross, ticGame);
            computerPlayerDict["Michele AI"] = micheleAI;
            player1Box.Items.Add("Michele AI");
            player2Box.Items.Add("Michele AI");
            tselleckAI = new TselleckAI("Tselleck AI", TicResources.Cross, ticGame);
            computerPlayerDict["Tselleck AI"] = micheleAI;
            player1Box.Items.Add("Tselleck AI");
            player2Box.Items.Add("Tselleck AI");

        }

        public Player WhoIsPlayer1()
        {
            Player player;
            if (computerPlayerDict.ContainsKey(player1Box.Text))
            {
                player = computerPlayerDict[player1Box.Text];
                player.PlayerPiece = TicResources.Cross;
            }
            else
                player = new HumanPlayer(player1Box.Text, TicResources.Cross, ticGame);
            return player;
        }

        public Player WhoIsPlayer2()
        {
            Player player;
            if (computerPlayerDict.ContainsKey(player2Box.Text))
            {
                player = computerPlayerDict[player2Box.Text];
                player.PlayerPiece = TicResources.Knot;
            }
            else
                player = new HumanPlayer(player2Box.Text, TicResources.Knot, ticGame);
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
            ticGame.StopGame();
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
