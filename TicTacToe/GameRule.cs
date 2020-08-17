using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameRule : IRules
    {
        private IPiece[,] cachedPieces;

        public GameRule(IPiece[,] _cachedPieces)
        {
            cachedPieces = _cachedPieces;
        }

        public IPlayer GetWinner(IPlayer playerOne, IPlayer playerTwo)
        {
            for(int a=0; a<3; a++)
            {
                if (cachedPieces[a, 0] == cachedPieces[a, 1] && cachedPieces[a, 1] == cachedPieces[a, 2] && cachedPieces[a, 0] != null)
                    if (cachedPieces[a, 0].Equals(playerOne.Piece)) return playerOne;
                    else return playerTwo;

                if (cachedPieces[0, a] == cachedPieces[1, a] && cachedPieces[1, a] == cachedPieces[2, a] && cachedPieces[0, a] != null)
                    if (cachedPieces[0, a].Equals(playerOne.Piece)) return playerOne;
                    else return playerTwo;
            }

            if(cachedPieces[1, 1] != null)
                if ((cachedPieces[0, 0] == cachedPieces[1, 1] && cachedPieces[1, 1] == cachedPieces[2, 2]) ||
                    (cachedPieces[2, 0] == cachedPieces[1, 1] && cachedPieces[1, 1] == cachedPieces[0, 2]))
                    if (cachedPieces[1, 1].Equals(playerOne.Piece)) return playerOne;
                    else return playerTwo;

            return null;
        }

        public bool HaveWinner()
        {
            throw new NotImplementedException();
        }

        public bool IsDraw()
        {
            for (int a = 0; a < cachedPieces.GetLength(0); a++)
                for (int b = 0; b < cachedPieces.GetLength(1); b++)
                    if (cachedPieces[a, b] == null) return false;
            return true;
        }
    }
}
