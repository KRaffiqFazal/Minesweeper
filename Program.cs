using System.Data;

namespace Minesweeper
{
    partial class Program
    {
        public static int ROWS = 5, COLUMNS = 5;
        public static Cell[,] board = new Cell[ROWS, COLUMNS];
        public static void Main(string[] args)
        {
            MakeBoard();
            Display();
        }
        
    }
}