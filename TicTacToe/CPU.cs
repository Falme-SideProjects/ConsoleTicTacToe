using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class CPU : AbstractPlayer
    {
        public CPU(IPiece piece) : base(piece)
        {
        }

        public override int MakeChoice()
        {
            Random random = new Random();
            this.Choice = random.Next(1,10);
            return GetChoice();
        }
    }
}
