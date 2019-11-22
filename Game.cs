using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperV2
{
    public class Game
    {
        Player player1;
        Player player2;

        public string GetNumberPlayers()
        {
            Console.WriteLine("How many players?");
            string numberPlayers = Console.ReadLine();
            return numberPlayers;
        }
        public void CreatePlayers(string numberPlayers)
        {
            if(numberPlayers =="1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if(numberPlayers =="2")
            {
                player1 = new Human();
                player2 = new Human();
            }
        }








    }

    



}
