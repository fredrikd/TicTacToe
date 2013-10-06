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
        private FredrikAI fredrikAI1, fredrikAI2; // Två instanser pga. att samma AI ska kunna spela mot sig själv.
        private MicheleAI micheleAI;
        private TselleckAI tselleckAI;
        private const string InitialBoxText = "Enter player or choose AI";

        public TicForm()
        {
            InitializeComponent();
            ticGame = new TicGame(this, ticPanel, messageLabel);
            computerPlayerDict = new Dictionary<string, Player>();
            player1Box.Text = player2Box.Text = InitialBoxText;

            // Initialt anges att datorspelarna ska spela med kryss,
            // men det justeras när spelet startas.
            fredrikAI1 = new FredrikAI("Fredrik AI (1)", TicResources.Cross, ticGame);
            computerPlayerDict["Fredrik AI (1)"] = fredrikAI1;
            player1Box.Items.Add("Fredrik AI (1)");
            fredrikAI2 = new FredrikAI("Fredrik AI (2)", TicResources.Cross, ticGame);
            computerPlayerDict["Fredrik AI (2)"] = fredrikAI2;
            player2Box.Items.Add("Fredrik AI (2)");
            micheleAI = new MicheleAI("Michele AI", TicResources.Cross, ticGame);
            computerPlayerDict["Michele AI"] = micheleAI;
            player1Box.Items.Add("Michele AI");
            player2Box.Items.Add("Michele AI");
            tselleckAI = new TselleckAI("Tselleck AI", TicResources.Cross, ticGame);
            computerPlayerDict["Tselleck AI"] = tselleckAI;
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

        public void ChangeComponentsToStartedMode(bool started)
        {
            startButton.Enabled = !started;
            abortButton.Enabled = started;
            player1Box.Enabled = !started;
            player2Box.Enabled = !started;
            rovareBox1.Enabled = !started;
            rovareBox2.Enabled = !started;
        }

        public void Start()
        {
            if (player1Box.Text == InitialBoxText || player1Box.Text == "") player1Box.Text = "Player 1";
            if (player2Box.Text == InitialBoxText || player2Box.Text == "") player2Box.Text = "Player 2";
            ChangeComponentsToStartedMode(true);
            Player player1 = WhoIsPlayer1();
            Player player2 = WhoIsPlayer2();
            Board board = new Board();
            ticPanel.CurrentBoard = board;
            ticGame.StartGame(board, player1, player2);
        }

        public void Stop()
        {
            ChangeComponentsToStartedMode(false);
            ticGame.AbortGame();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void player1Box_MouseClick(object sender, MouseEventArgs e)
        {
            if (player1Box.Text == InitialBoxText) player1Box.Text = "";
        }

        private void player2Box_MouseClick(object sender, MouseEventArgs e)
        {
            if (player2Box.Text == InitialBoxText) player2Box.Text = "";
        }

        private void rovareBox1_Click(object sender, EventArgs e)
        {
            player1Box.Text = player1Box.Text.rova();
        }

        private void rovareBox2_Click(object sender, EventArgs e)
        {
            player2Box.Text = player2Box.Text.rova();
        }
    }
}
