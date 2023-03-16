using LLDTicTacToe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDTicTacToe.Strategies.GameWinningStrategy
{
    public interface IGameWinningStrategy
    {
        bool CheckWinner(Board board, Player lastMovePlayer, Cell moveCell);
    }
}
