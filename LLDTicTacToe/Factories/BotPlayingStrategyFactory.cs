using LLDTicTacToe.Models;
using LLDTicTacToe.Strategies.BotPlayingStrategy;

namespace LLDTicTacToe.Factories
{
    public class BotPlayingStrategyFactory
    {
        public static IBotPlayingStrategy GetBotPlayingStrategyByDifficultyLevel(BotDifficultyLevel botDifficultyLevel)
        {
            switch(botDifficultyLevel)
            {
                case BotDifficultyLevel.EASY:
                case BotDifficultyLevel.MEDIUM:
                case BotDifficultyLevel.HARD:
                    return new FindFirstPlayingStrategy();
                default:
                    return new FindFirstPlayingStrategy();
            }
            
        }
    }
}
