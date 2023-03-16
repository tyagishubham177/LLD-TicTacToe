namespace LLDTicTacToe.Models
{
    public class Player
    {
        public char Symbol { get; set; }
        public string Name { get; set; }
        public PlayerType Type { get; set; }

        public Player(char symbol, string name, PlayerType type)
        {
            Symbol = symbol;
            Name = name;
            Type = type;
        }

        public virtual Move MakeMove(Board board)
        {
            Console.WriteLine("Which row you want to make your move. Select from 0 - " + (board.Dimension - 1));
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which col you want to make your move. Select from 0 - " + (board.Dimension - 1));
            int col = Convert.ToInt32(Console.ReadLine());

            return new Move(this, new Cell(row, col));
        }
    }
}