using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppProject
{
    internal interface ITeam
    {
        void Add(List<Player> oneDayTeam);
        void Remove(List<Player> players, int playerId);
        Player GetPlayerById(List<Player> players, int playerId);
        Player GetPlayerByName(List<Player> players, string playerName);
        List<Player> GetAllPlayer(List<Player> player);

    }
}
