using LLDTicTacToe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDTicTacToe.Strategies.GameWinningStrategy
{
    public class OrderOneGameWiningStrategy : IGameWinningStrategy
    {
        private List<Dictionary<char, int>> rowSymbolCounts = new List<Dictionary<char, int>>();
        private List<Dictionary<char, int>> colSymbolCounts = new List<Dictionary<char, int>>();
        private Dictionary<char, int> leftDiagSymbolCounts = new Dictionary<char, int>();
        private Dictionary<char, int> rightDiagSymbolCounts = new Dictionary<char, int>();

        public OrderOneGameWiningStrategy(int boardSize)
        {
            for (int i = 0; i < boardSize; i++)
            {
                rowSymbolCounts.Add(new Dictionary<char, int>());
                colSymbolCounts.Add(new Dictionary<char, int>());
            }
        }

        public bool IsCellOnTopLeftDiag(int row, int col) => row == col;

        public bool IsCellOnTopRightDiag(int row, int col, int dimension) => row + col == dimension - 1;

        public bool CheckWinner(Board board, Player lastMovePlayer, Cell moveCell)
        {
            char symbol = moveCell.Player.Symbol;
            int row = moveCell.Row;
            int col = moveCell.Col;
            int dimension = board.Dimension;

            if (!rowSymbolCounts[row].ContainsKey(symbol))
            {
                rowSymbolCounts[row].Add(symbol, 0);
            }

            rowSymbolCounts[row][symbol]++;

            if (!colSymbolCounts[col].ContainsKey(symbol))
            {
                colSymbolCounts[col].Add(symbol, 0);
            }

            colSymbolCounts[col][symbol]++;

            if (IsCellOnTopLeftDiag(row, col))
            {
                if (!leftDiagSymbolCounts.ContainsKey(symbol))
                {
                    leftDiagSymbolCounts.Add(symbol, 0);
                }

                leftDiagSymbolCounts[symbol]++;
            }

            if (IsCellOnTopRightDiag(row, col, board.Dimension))
            {
                if (!rightDiagSymbolCounts.ContainsKey(symbol))
                {
                    rightDiagSymbolCounts.Add(symbol, 0);
                }

                rightDiagSymbolCounts[symbol]++;
            }

            if (rowSymbolCounts[row][symbol] == dimension || colSymbolCounts[col][symbol] == dimension)
            {
                return true;
            }

            if (IsCellOnTopRightDiag(row, col, dimension) && rightDiagSymbolCounts[symbol] == dimension)
            {
                return true;
            }

            if (IsCellOnTopLeftDiag(row, col) && leftDiagSymbolCounts[symbol] == dimension)
            {
                return true;
            }

            return false;
        }
    }
}
