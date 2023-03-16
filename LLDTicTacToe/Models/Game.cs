using LLDTicTacToe.Exceptions;
using LLDTicTacToe.Strategies.GameWinningStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDTicTacToe.Models
{
    public class Game
    {
        public Board Board { get; set; }
        public List<Player> Players { get; set; }
        public List<Move> Moves { get; set; }
        public GameStatus GameStatus { get; set; }
        public int NextPlayerIndex { get; set; }
        public Player Winner { get; set; }
        public IGameWinningStrategy GameWinningStrategy { get; set; }

        private Game()
        { }

        public void Undo()
        {

        }

        public void MakeNextMove()
        {

        }

        public void DisplayBoard()
        {
            Board.Display();
        }

        public void executeNextMove()
        {
            Player toMovePlayer = Players[NextPlayerIndex];
            Console.WriteLine("Player " + toMovePlayer.Name + " to move");

            Move move = toMovePlayer.MakeMove(Board);

            int row = move.Cell.Row;
            int col = move.Cell.Col;

            Board.TTTBoard[row][col].CellState = CellState.FILLED;
            Board.TTTBoard[row][col].Player = Players[NextPlayerIndex];

            Moves.Add(move);

            if (GameWinningStrategy.CheckWinner(Board, Players[NextPlayerIndex], move.Cell))
            {
                GameStatus = GameStatus.ENDED;
                Winner = Players[NextPlayerIndex];
            }

            NextPlayerIndex = (NextPlayerIndex + 1) % Players.Count;
        }
    }
}