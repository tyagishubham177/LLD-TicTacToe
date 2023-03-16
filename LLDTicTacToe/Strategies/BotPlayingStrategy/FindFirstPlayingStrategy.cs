using LLDTicTacToe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDTicTacToe.Strategies.BotPlayingStrategy
{
    public class FindFirstPlayingStrategy : IBotPlayingStrategy
    {
        public Move DecideMove(Player player, Board board)
        {
            for (int i = 0; i < board.Dimension; i++)
            {
                for (int j = 0; j < board.Dimension; j++)
                {
                    if (board.TTTBoard[i][j].CellState == CellState.EMPTY)
                    {
                        return new Move(player, new Cell(i, j));
                    }
                }
            }

            return null;
        }
    }
}
