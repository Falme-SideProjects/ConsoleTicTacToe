using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameTable : IGameTable
    {
        private IPiece[,] table; 
        public IPiece[,] Table { get => this.table; set { this.table = value; } }

        private GameRule gameRule;

        public GameTable()
        {
            Table = new IPiece[3, 3];
            gameRule = new GameRule(Table);
        }

        public void DrawTable()
        {
            Console.Clear();

            string lineFormat = " {0}|{1}|{2}";

            Console.WriteLine(string.Format(lineFormat, GetTableForCell(0, 0), GetTableForCell(0, 1), GetTableForCell(0, 2)));
            Console.WriteLine(" -----");
            Console.WriteLine(string.Format(lineFormat, GetTableForCell(1, 0), GetTableForCell(1, 1), GetTableForCell(1, 2)));
            Console.WriteLine(" -----");
            Console.WriteLine(string.Format(lineFormat, GetTableForCell(2, 0), GetTableForCell(2, 1), GetTableForCell(2, 2)));
        }

        public bool PlaceAvailable(int position)
        {
            IPiece result = Table[GetConvertedY(position), GetConvertedX(position)];

            bool res = result == null;

            return res;
        }

        public void SetChoiceInTable(int position, IPiece _piece)
        {
            Table[GetConvertedY(position), GetConvertedX(position)] = _piece;
        }

        private int GetConvertedY(int position)
        {
            return ((int)(position - 1) / 3);
        }

        internal void ShowWinner(IPlayer playerOne, IPlayer playerTwo)
        {
            IPlayer _player = gameRule.GetWinner(playerOne, playerTwo);
            if(_player != null)
                Console.WriteLine("Winner is : " + _player.Piece.Value);
            else
                Console.WriteLine("No Winners, Thats a Draw");
        }

        private int GetConvertedX(int position)
        {
            return ((int)(position - 1) % 3);
        }

        private string GetTableForCell(int y, int x)
        {
            if (Table[y, x] == null) return " ";
            return Table[y, x].Value;
        }

        public bool GameIsOver(IPlayer playerOne, IPlayer playerTwo)
        {
            return gameRule.GetWinner(playerOne, playerTwo) != null || gameRule.IsDraw();
        }
    }
}
