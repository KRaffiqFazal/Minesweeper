namespace Minesweeper
{
	partial class Program
	{
		public static void MakeBoard()
		{
			Random rnd = new Random();
			for (int i = 0; i < ROWS; i++)
			{
				for (int j = 0; j < COLUMNS; j++)
				{
					board[i, j] = new Cell();
					if (rnd.Next(6) == 0)
					{
						board[i, j].Mine = true;
					}
				}
			}
		}
		public static void Display()
		{
			String lineBreak = " ";
			for (int i = 0; i < ROWS; i++)
			{
				lineBreak += "--";
			}
			lineBreak += "-";
			Console.Write(lineBreak + "\n");
			for (int i = 0; i < ROWS; i++)
			{
				Console.Write(ROWS - i);
				Console.Write("|");
				for (int j = 0; j < COLUMNS; j++)
				{
					Console.Write(board[i, j].Display + "|");
				}
				Console.Write("\n" + lineBreak + "\n");
			}
			Console.Write("  ");
			for (int i = 65; i < 65 + COLUMNS; i++)
			{
				Console.Write(Convert.ToChar(i) + " ");
			}
		}
	}
}