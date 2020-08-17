using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public interface IGameTable
    {
        IPiece[,] Table { get; set; }
        void DrawTable();
        void SetChoiceInTable(int position, IPiece piece);
        bool PlaceAvailable(int position);
        bool GameIsOver(IPlayer playerOne, IPlayer playerTwo);
    }
}
