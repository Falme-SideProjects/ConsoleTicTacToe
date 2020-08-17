using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Tictactoe
    {
        GameTable gameTable;

        private IPlayer playerOne, playerTwo, currentPlayer;

        public Tictactoe()
        {
            gameTable = new GameTable();

            playerOne = new Player(new X());
            playerTwo = new CPU(new O());
        }

        public void StartGame()
        {
            //Print Initializer
            Console.WriteLine(" === TIC TAC TOE === \n");
            Console.WriteLine(" Please Select From 1 to 9 the position of your choice! \n \n");
            Console.ReadKey();

            currentPlayer = playerOne;

            //Print TableGame 
            gameTable.DrawTable();

            while(!gameTable.GameIsOver(playerOne, playerTwo))
            {

                currentPlayer.MakeChoice();

                if (!gameTable.PlaceAvailable(currentPlayer.GetChoice()))
                {
                    if (currentPlayer is Player) Console.WriteLine("Invalid Position, Try again:");
                    continue;
                }

                gameTable.SetChoiceInTable(currentPlayer.GetChoice(), currentPlayer.Piece);

                gameTable.DrawTable();

                if (currentPlayer.Equals(playerOne)) currentPlayer = playerTwo;
                else currentPlayer = playerOne;
            }

            gameTable.ShowWinner(playerOne, playerTwo);
            Console.WriteLine("End Game");
        }
    }
}
