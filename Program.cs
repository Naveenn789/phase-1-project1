using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProject
{
    internal class Program : OneDayTeam
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            string option;
            do
            {
                Console.WriteLine("Coose one operation to perform \n1:To Add Player \n2:To Remove Player by Id \n3.Get Player By Id \n4.Get Player by Name \n5.Get All Players");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        team.Add(oneDayTeam);
                        break;
                    case 2:
                        Console.WriteLine("Enter Player ID of the Player you Want to Remove");
                        int y = int.Parse(Console.ReadLine());
                        team.Remove(oneDayTeam,y);
                        break;
                    case 3:
                        Console.WriteLine("Enter Player ID of the Player you Want the Data");
                        int x = int.Parse(Console.ReadLine());
                        team.GetPlayerById(oneDayTeam,x);
                        break;
                    case 4:
                        Console.WriteLine("Enter Player Name you Want the Data");
                        string name = Console.ReadLine();
                        team.GetPlayerByName(oneDayTeam,name);
                        break;
                    case 5:
                        team.GetAllPlayer(oneDayTeam);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Do you Want to add Continue ? yes/no");
                option = Console.ReadLine();
            } while (option == "yes");
            Console.ReadKey();
        }
    }
}
