using System;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    public class TicPanel : Panel
    {
        private const int gridXInterval = 100;
        private const int gridYInterval = 100;
        private const int gridXNumber = 3;
        private const int gridYNumber = 3;

        public Board CurrentBoard { get; set; }

        private void DrawGrid(Graphics g, Pen p)
        {
            for (int y = 0; y <= gridYInterval * gridYNumber; y += gridYInterval)
            {
                g.DrawLine(p, 0, y, gridXNumber * gridXInterval, y);
            }
            for (int x = 0; x <= gridXInterval * gridXNumber; x += gridXInterval)
            {
                g.DrawLine(p, x, 0, x, gridYInterval * gridYNumber);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);
            DrawGrid(g, p);
            if (CurrentBoard != null)
            {
                for (int y = 0; y < gridYNumber; y++)
                {
                    for (int x = 0; x < gridXNumber; x++)
                    {
                        if (CurrentBoard.pieces[x, y] != null)
                            g.DrawImage(CurrentBoard.pieces[x, y].Icon, x * gridXInterval, y * gridYInterval);
                    }
                }
            }
        }

        public Point WhichCell(Point pixel)
        {
            Point result = new Point();
            result.X = pixel.X / gridXInterval;
            result.Y = pixel.Y / gridYInterval;
            if(pixel.X % gridXInterval == 0 || pixel.Y % gridYInterval == 0)
            {
                // Om man klickar på "kanten" till cellerna.
                result.X = -1;
                result.Y = -1;
            }
            return result;
        }

    }
}
