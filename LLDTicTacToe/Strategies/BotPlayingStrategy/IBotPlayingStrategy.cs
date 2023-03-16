using LLDTicTacToe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDTicTacToe.Strategies.BotPlayingStrategy
{
    public interface IBotPlayingStrategy
    {
        Move DecideMove(Player player, Board board);
    }
}
