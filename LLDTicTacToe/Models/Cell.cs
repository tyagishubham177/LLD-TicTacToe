namespace LLDTicTacToe.Models
{
    public class Cell
    {
        public Player Player { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public CellState CellState { get; set; }

        public Cell(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
}