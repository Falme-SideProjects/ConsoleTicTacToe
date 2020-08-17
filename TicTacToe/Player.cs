using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player : AbstractPlayer
    {
        public Player(IPiece piece) : base(piece)
        {
        }

        public override int MakeChoice()
        {
            this.Choice = int.Parse(Console.ReadLine());
            return GetChoice();
        }
    }
}
