using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LillyL_CIT265_A4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Supports both a user generated list and also an automated list
            List<Player> playerList = InstantiatePlayers();
            List<Player> autoPlayerList = AutoInstantiatePlayers(100);

            PlayGames(playerList);
            PlayGames(autoPlayerList);


            var leaderboard = from player in playerList
                              orderby player.Wins descending
                              select player;

            var leaderboardWinLoss = from player in playerList
                                         where player.Wins == player.Losses
                                         select player;

            foreach (var player in leaderboard)
            {
                Console.WriteLine("{0}: Wins: {1} Losses: {2}", player.Name, player.Wins, player.Losses);
            }

            Console.WriteLine();

            foreach (var player in leaderboardWinLoss)
            {
                Console.WriteLine("{0} has a 50% win rate.", player.Name);
            }

            Console.WriteLine();

            var autoLeaderboard = from player in autoPlayerList
                                  orderby player.Wins descending
                                  select player;
            
            var autoLeaderboardWinLoss = from player in autoPlayerList
                                         where player.Wins == player.Losses
                                         select player;
            
            foreach (var player in autoLeaderboard)
            {
                Console.WriteLine("{0}: Wins: {1} Losses: {2}", player.Name, player.Wins, player.Losses);
            }
            
            Console.WriteLine();
            
            foreach (var player in autoLeaderboardWinLoss)
            {
                Console.WriteLine("{0} has a 50% win rate.", player.Name);
            }
            
            Console.WriteLine();
        }


    private static void PlayGames(List<Player> playerList)
        {
            Random random1 = new Random();
            for (int i = 0; i < playerList.Count(); i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int num;
                    while (true)
                    {
                        num = random1.Next(playerList.Count());
                        if (num != i)
                        {
                            break;
                        }
                    }
                    playerList[i].PlayGame(playerList[num]);
                }
                Console.WriteLine();
            }
        }

        private static List<Player> InstantiatePlayers()
        {
            int id = 1;
            string name = "Default";
            List<Player> playerList= new List<Player>();
            while (true)
            {
                Console.Write("Enter player {0}'s name! (Enter 'Next' to stop adding new players): ", id);
                name = Console.ReadLine();
                if (id < 3)
                {
                    if (name == "Next" || name == "next")
                    {
                        Console.WriteLine("Sorry, there has to be at least two players!");
                    }
                    else
                    {
                        playerList.Add(new Player(id, name));
                        id++;
                    }
                }
                else
                {
                    if (name == "Next" || name == "next")
                    {
                        break;
                    }
                    else
                    {
                        playerList.Add(new Player(id, name));
                        id++;
                    }
                }

            }
            Console.WriteLine();
            return playerList;
        }

        private static List<Player> AutoInstantiatePlayers(int players)
        {
            if (players < 2)
            {
                players = 2;
            }
            int id = 1;
            string name = "Player ";
            List<Player> playerList = new List<Player>();
            for (int i = 0; i < players; i++)
            {
                        playerList.Add(new Player(id, name+id));
                        id++;
            }
            return playerList;
        }
    }
}
