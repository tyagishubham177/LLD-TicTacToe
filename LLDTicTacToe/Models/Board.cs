using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDTicTacToe.Models
{
    public class Board
    {
        private readonly int _dimension;

        public List<List<Cell>> TTTBoard { get; set; }
        public int Dimension => _dimension;
        public Board(int dimension)
        {
            _dimension = dimension;
            TTTBoard = new List<List<Cell>>();

            for (int i = 0; i < dimension; ++i)
            {
                TTTBoard.Add(new List<Cell>());
                for (int j = 0; j < dimension; ++j)
                {
                    TTTBoard[i].Add(new Cell(i, j));
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < _dimension; ++i)
            {
                for (int j = 0; j < _dimension; ++j)
                {
                    if (TTTBoard[i][j].CellState == CellState.EMPTY)
                    {
                        Console.Write("|   |");
                    }
                    else
                    {
                        Console.Write("| " + TTTBoard[i][j].Player.Symbol + " |");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
