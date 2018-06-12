namespace TicTacToeConsole
{
    using System;
    using TicTacToe;

    public class Program
    {
        static void Main(string[] args)
        {
            InitPiecesArray();

            DisplayCurrentPlayState();

            var grid = new Board();
            var scoreKeeper = new Score();

            Console.WriteLine("X always goes first, Where you \"X\" be placed");
            while (!scoreKeeper.CheckForWin(grid))
            {
                Console.WriteLine("X's turn");
                var place = Console.ReadLine();
                scoreKeeper.MakeMove(Convert.ToInt32(place), Player.Piece.X, grid);
                PopulateGraphic('X', Convert.ToInt32(place));
                if (scoreKeeper.CheckForWin(grid))
                {
                    TriggerWin("X");
                    return;
                }

                Console.WriteLine("O's turn");
                place = Console.ReadLine();
                scoreKeeper.MakeMove(Convert.ToInt32(place), Player.Piece.O, grid);
                PopulateGraphic('O', Convert.ToInt32(place));
                if (scoreKeeper.CheckForWin(grid))
                {
                    TriggerWin("O");
                    return;
                }
            }
        }

        private static void TriggerWin(string piece)
        {
            Console.WriteLine(piece + " Wins");
            Console.WriteLine("Press any key continue");
            Console.ReadKey();
        }

        private static char[] _pieces;

        private static void InitPiecesArray()
        {
            if (_pieces == null)
            {
                _pieces = new char[9] {'0', '1', '2', '3', '4', '5', '6', '7', '8' };
            }

        }

        private static void PopulateGraphic(char piece, int position)
        {
            switch (position)
            {
                case 0:
                    _pieces[0] = piece;
                    break;
                case 1:
                    _pieces[1] = piece;
                    break;
                case 2:
                    _pieces[2] = piece;
                    break;
                case 3:
                    _pieces[3] = piece;
                    break;
                case 4:
                    _pieces[4] = piece;
                    break;
                case 5:
                    _pieces[5] = piece;
                    break;
                case 6:
                    _pieces[6] = piece;
                    break;
                case 7:
                    _pieces[7] = piece;
                    break;
                case 8:
                    _pieces[8] = piece;
                    break;
            }
            DisplayCurrentPlayState();
        }

        private static void DisplayCurrentPlayState()
        {
            Console.WriteLine(string.Format(_grid,
                _pieces[0],
                _pieces[1],
                _pieces[2],
                _pieces[3],
                _pieces[4],
                _pieces[5],
                _pieces[6],
                _pieces[7],
                _pieces[8]));
        }

        private static string _grid = "_{0}_|_{1}_|_{2}_\n" + 
                               "_{3}_|_{4}_|_{5}_\n" +
                               " {6} | {7} | {8}";
    }
}
