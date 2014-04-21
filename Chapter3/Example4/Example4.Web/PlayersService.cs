using System.Collections.Generic;
using System.Linq;
using ServiceStack.ServiceHost;

namespace Example4.Web
{
    public class PlayersService : IService
    {
        public PlayersRepository Repository { get; set; }

        public List<Player> Get(GetPlayersRequest request)
        {
            return Repository.GetPlayers();
        }

        public Player Get(GetPlayerRequest request)
        {
            return Repository.GetPlayers().Single(p => p.Id == request.Id);
        }

        public Player Post(Player player)
        {
            Repository.AddPlayer(player);
            return player;
        }
    }
}