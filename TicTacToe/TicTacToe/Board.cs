namespace TicTacToe
{
    public class Board
    {
        private Player.Piece[] _playingGrid;

        public Board()
        {
            _playingGrid = new Player.Piece[9];
        }

        public bool IsValidSpace(int space)
        {
            if (space >= 0 && space < 9)
            {
                return true;
            }
            return false;
        }

        public bool IsSpaceFree(int space)
        {
            if(IsValidSpace(space))
            {
                if(_playingGrid[space] == Player.Piece.Free)
                {
                    return true;
                }
            }
            return false;
        }

        public void PlacePiece(int space, Player.Piece piece)
        {
            if(IsSpaceFree(space))
            {
                _playingGrid[space] = piece;
            }
        }

        public Player.Piece[] GetBoardState()
        {
            return _playingGrid;
        }
    }
}


/*
 * 
 * 
   _0_|_1_|_2_
   _3_|_4_|_5_
    6 | 7 | 8
 * 
 * 
 */
