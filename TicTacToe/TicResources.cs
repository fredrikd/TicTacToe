using System.Drawing;

namespace TicTacToe
{
    class TicResources
    {
        public static Bitmap CrossBitmap;
        public static Bitmap KnotBitmap;

        public static Piece Cross;
        public static Piece Knot;

        static TicResources()
        {
            CrossBitmap = new Bitmap("..\\..\\tic_cross.png");
            CrossBitmap = new Bitmap(CrossBitmap, 99, 99);
            KnotBitmap = new Bitmap("..\\..\\tic_knot.png");
            KnotBitmap = new Bitmap(KnotBitmap, 99, 99);

            Cross = new Piece(CrossBitmap);
            Knot = new Piece(KnotBitmap);
        }
    }
}
