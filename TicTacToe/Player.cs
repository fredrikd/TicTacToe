﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public abstract class Player
    {
        public string Name { get; set; }
        public Piece PlayerPiece { get; set; }
        public TicGame MyGame { get; set; }

        public Player(string name, Piece piece, TicGame ticGame)
        {
            Name = name;
            PlayerPiece = piece;
            MyGame = ticGame;
        }

        // Anropas när ett nytt spel startas.
        public abstract void NotifyGameStarts();

        // Anropas när det blir spelarens tur.
        // Nuvarande spelbräde skickas som parameter.
        // 
        public abstract void NotifyTurn();

        // Anropas när spelet slutar, dvs. när det
        // avbryts eller när någon vinner.
        public abstract void NotifyGameStops();
    }
}
