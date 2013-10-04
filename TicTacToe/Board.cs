using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    // En struct som representerar vilken Piece (eller null vid oavgjort)
    // som vunnit på ifrågavarande spelbräde och numret för vilken
    // rad, kolumn eller diagonal som vinsten finns på. Vid ingen
    // vinst är ifrågavarande variabel (nullable int) satt till null.
    public struct WinStruct
    {
        public Piece Winner;
        public int? Row, Column, Diagonal;

        public WinStruct(Piece winner, int? row, int? column, int? diagonal)
        {
            Winner = winner;
            Row = row;
            Column = column;
            Diagonal = diagonal;
        }
    }

    public class Board
    {
        private const int sizeX = 3;
        private const int sizeY = 3;

        public Piece[,] pieces;

        public Board()
        {
            pieces = new Piece[sizeX, sizeY];
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    pieces[x, y] = null;
                }
            }
        }

        // Skapar ett nytt Board som är en klon av ett existerande Board.
        public Board(Board board)
        {
            pieces = new Piece[sizeX, sizeY];
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    pieces[x, y] = board.pieces[x, y]; //board.pieces 
                }
            }
        }

        public void MakeMove(Move m)
        {
            pieces[m.X, m.Y] = m.P;
        }

        public bool BoardFull()
        {
            bool full = true;
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    if (pieces[x, y] == null)
                    {
                        full = false;
                        // Vill break:a ut från en nästad loop.
                        // C# verkar (i motsats till Java) inte tillåta break med labelangivelse,
                        // så jag får göra Dijkstra ledsen i sin grav och använda lite goto...
                        goto avsluta_loop;
                    }
                }
            }
            avsluta_loop:
            return full;
        }

        public WinStruct FindWinner()
        {
            Piece first;

            // Kolla rader.
            for (int y = 0; y < sizeY; y++)
            {
                if((first = pieces[0, y]) != null) for (int x = 1; x < sizeX; x++)
                {
                    if (pieces[x, y] != first) break;
                    else if(x == sizeX - 1) // Sista i raden.
                    {
                        return new WinStruct(first, y, null, null);
                    }
                }
            }

            // Kolla kolumner.
            for (int x = 0; x < sizeX; x++)
            {
                if ((first = pieces[x, 0]) != null) for (int y = 1; y < sizeY; y++)
                {
                    if (pieces[x, y] != first) break;
                    else if(y == sizeY - 1) // Sista i kolumnen.
                    {
                        return new WinStruct(first, null, x, null);
                    }
                }
            }

            // Om spelbrädet är kvadratiskt kollas även diagonalerna.
            if (sizeX == sizeY)
            {
                if((first = pieces[0, 0]) != null) for (int i = 1; i < sizeX; i++)
                {
                    if(pieces[i, i] != first) break;
                    else if (i == sizeX - 1) // Sista i diagonalen.
                    {
                        return new WinStruct(first, null, null, 0);
                    }
                }

                if((first = pieces[sizeX - 1, 0]) != null) for (int i = 1; i < sizeX; i++)
                {
                    if (pieces[(sizeX - 1) - i, i] != first) break;
                    else if (i == sizeX - 1) // Sista i diagonalen.
                    {
                        return new WinStruct(first, null, null, 1);
                    }
                }
            }

            // Ingen vinnare hittades.
            return new WinStruct(null, null, null, null);
        }

        //Kollar ifall Move, "m" innehåller ett värde eller ej.
        //Method som returnerar en bool
        public bool AbleMove(Move m)
        {
            if (m == null)
            {
                return false;
            }
            else if (m.X < 0 || m.Y < 0 || m.X >= sizeX || m.Y >= sizeY)
            {
                return false;
            }
            else if (pieces[m.X, m.Y] != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
