using System;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    class TicPanel : Panel
    {
        private const int gridXInterval = 100;
        private const int gridYInterval = 100;
        private const int gridXNumber = 3;
        private const int gridYNumber = 3;

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
        }
    }
}
