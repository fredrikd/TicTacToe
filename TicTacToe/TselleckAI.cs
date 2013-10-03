﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TselleckAI: ComputerPlayer
    {
        private TicGame ticGame;
        public TselleckAI(string name, Piece piece, TicGame ticGame)
            : base(name, piece, ticGame)
        {
        }

        public override void NotifyGameStarts()
        {
        }

        public override void NotifyTurn()
        {
            MyGame.MakeMove(new Move(1, 1, PlayerPiece));
            //board.pieces[0, 0] = PlayerPiece;
        }

        public override void NotifyGameStops()
        {
        }
    }
}