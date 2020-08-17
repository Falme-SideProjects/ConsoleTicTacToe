using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public interface IRules
    {
        bool IsDraw();
        bool HaveWinner();
        IPlayer GetWinner(IPlayer playerOne, IPlayer playerTwo);
    }
}
