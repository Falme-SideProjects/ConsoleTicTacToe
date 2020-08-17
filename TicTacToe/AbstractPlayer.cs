using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public abstract class AbstractPlayer : IPlayer
    {
        private int choice;
        public int Choice { get => choice; set { choice = value; } }

        private IPiece piece;
        public IPiece Piece => piece;

        public AbstractPlayer(IPiece piece)
        {
            this.piece = piece;
        }

        public int GetChoice()
        {
            return this.Choice;
        }

        public abstract int MakeChoice();
    }
}
