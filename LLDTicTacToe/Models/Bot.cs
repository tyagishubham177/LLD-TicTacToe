using LLDTicTacToe.Strategies.BotPlayingStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDTicTacToe.Models
{
    public class Bot : Player
    {
        public BotDifficultyLevel BotDifficultyLevel { get; set; }
        public IBotPlayingStrategy BotPlayingStrategy { get; set; }

        public Bot(string name, char symbol, BotDifficultyLevel botDifficultyLevel, IBotPlayingStrategy botPlayingStrategy) : base(symbol, name, PlayerType.BOT)
        {
            BotDifficultyLevel = botDifficultyLevel;
            BotPlayingStrategy = botPlayingStrategy;
        }

        public override Move MakeMove(Board board)
        {
            return BotPlayingStrategy.DecideMove(this, board);
        }
    }
}
