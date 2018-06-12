namespace TicTacToe
{
    public class Score
    {
        private int _moveCounter;

        public void MakeMove(int space, Player.Piece piece, Board board)
        {
            board.PlacePiece(space, piece);
            _moveCounter++;
        }

        public bool CheckForWin(Board board)
        {
            if (_moveCounter > 4)
            {
                return IsWin(board.GetBoardState());
            }
            return false;
        }

        private bool IsWin(Player.Piece[] boardState)
        {
            var hasXWon = HasPieceWon(boardState, Player.Piece.X);

            if (hasXWon)
            {
                return true;
            }

            var hasOWon = HasPieceWon(boardState, Player.Piece.O);

            if (hasOWon)
            {
                return true;
            }

            return false;
        }

        private static bool HasPieceWon(Player.Piece[] boardState, Player.Piece piecetoCheck)
        {
            if (boardState[0] == piecetoCheck && boardState[1] == piecetoCheck && boardState[2] == piecetoCheck)
            {
                return true;
            }
            if (boardState[3] == piecetoCheck && boardState[4] == piecetoCheck && boardState[5] == piecetoCheck)
            {
                return true;         
            }                         
            if (boardState[6] == piecetoCheck && boardState[7] == piecetoCheck && boardState[8] == piecetoCheck)
            {
                return true;         
            }                         
            if (boardState[0] == piecetoCheck && boardState[3] == piecetoCheck && boardState[6] == piecetoCheck)
            {
                return true;         
            }                         
            if (boardState[0] == piecetoCheck && boardState[3] == piecetoCheck && boardState[6] == piecetoCheck)
            {
                return true;         
            }                         
            if (boardState[1] == piecetoCheck && boardState[4] == piecetoCheck && boardState[7] == piecetoCheck)
            {
                return true;         
            }                         
            if (boardState[2] == piecetoCheck && boardState[5] == piecetoCheck && boardState[8] == piecetoCheck)
            {
                return true;         
            }                         
            if (boardState[2] == piecetoCheck && boardState[4] == piecetoCheck && boardState[6] == piecetoCheck)
            {
                return true;
            }
            return false;
        }
    }
}
