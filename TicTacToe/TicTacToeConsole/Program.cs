namespace TicTacToeConsole
{
    using System;
    using TicTacToe;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format(_grid, "0", "1", "2", "3", "4", "5","6","7","8"));

            var grid = new Board();
            var scoreKeeper = new Score();

            Console.WriteLine("X always goes first, Where you \"X\" be placed");
            while (!scoreKeeper.CheckForWin(grid))
            {
                Console.WriteLine("X's turn");
                var place = Console.ReadLine();
                scoreKeeper.MakeMove(Convert.ToInt32(place), Player.Piece.X, grid);

                Console.WriteLine("O's turn");
                place = Console.ReadLine();
                scoreKeeper.MakeMove(Convert.ToInt32(place), Player.Piece.O, grid);
            }
        }

        private static string _grid = "_{0}_|_{1}_|_{2}_\n" + 
                               "_{3}_|_{4}_|_{5}_\n" +
                               " {6} | {7} | {8}";
    }
}
