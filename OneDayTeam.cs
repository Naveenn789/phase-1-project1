using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProject
{
    internal class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
       public void Add(List<Player> players)
        {
            string option;
            do
            {
                Console.WriteLine("Enter Player Id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Player Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Player Age");
                int age = int.Parse(Console.ReadLine());
                var player = new Player { PlayerId = id, PlayerName = name, PlayerAge = age };
                players.Add(player);
                Console.WriteLine("Player Added Successfully");
                Console.WriteLine("Do you Want to add One More Player? yes/no");
                option = Console.ReadLine();

            } while (option=="yes");
        }
        public void Remove(List<Player> players,int playerId)
        {
            foreach (var player in players)
            {
                if (player.PlayerId==playerId)
                {
                    players.Remove(player);
                }
            }
        }
        public Player GetPlayerById(List<Player> players, int playerId)
        {
            foreach (var player in players)
            {
                if (player.PlayerId==playerId)
                {
                    Console.WriteLine("Player Id is    :" + player.PlayerId);
                    Console.WriteLine("Player Name is  :" + player.PlayerName);
                    Console.WriteLine("Player Ange is  :" + player.PlayerAge);
                }
            }
            return null;
        }
        public Player GetPlayerByName(List<Player> players,string playerName)
        {
            foreach (var player in players)
            {
                if (player.PlayerName == playerName)
                {
                    Console.WriteLine("Player Id is    :" + player.PlayerId);
                    Console.WriteLine("Player Name is  :" + player.PlayerName);
                    Console.WriteLine("Player Ange is  :" + player.PlayerAge);
                }
            }

            return null;
        }
        public List<Player> GetAllPlayer(List<Player> players)
        {
            Console.WriteLine("**** Total Players in the Team ****");
            foreach (var player in players)
            {
                Console.WriteLine("Player Id is    :"+player.PlayerId);
                Console.WriteLine("Player Name is  :"+player.PlayerName);
                Console.WriteLine("Player Ange is  :"+player.PlayerAge);
            }
            return oneDayTeam;
        }

    }
}
