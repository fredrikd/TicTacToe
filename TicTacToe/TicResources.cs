using System;
using System.Drawing;

namespace TicTacToe
{
    public class TicResources
    {
        public static Bitmap CrossBitmap;
        public static Bitmap KnotBitmap;

        public static Piece Cross;
        public static Piece Knot;

        public static Random Rand;

        static TicResources()
        {
            CrossBitmap = new Bitmap(@"..\..\tic_cross.png");
            CrossBitmap = new Bitmap(CrossBitmap, 99, 99);
            KnotBitmap = new Bitmap(@"..\..\tic_knot.png");
            KnotBitmap = new Bitmap(KnotBitmap, 99, 99);

            Cross = new Piece(CrossBitmap);
            Knot = new Piece(KnotBitmap);

            Rand = new Random();
        }
    }
}
