namespace LLDTicTacToe.Models
{
    public class Move
    {
        public Player Player { get; set; }
        public Cell Cell { get; set; }

        public Move(Player player, Cell cell)
        {
            Player = player;
            Cell = cell;
        }


    }
}