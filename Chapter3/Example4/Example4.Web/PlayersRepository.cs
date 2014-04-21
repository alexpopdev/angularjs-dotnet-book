using System.Collections.Generic;

namespace Example4.Web
{
    public class PlayersRepository
    {
        private List<Player> _players = new List<Player>
        {
            new Player{ Id= 1, FirstName="Angela", LastName = "Evans"},
            new Player{ Id= 2, FirstName="Jack", LastName = "Marshall"},
        };

        public List<Player> GetPlayers()
        {
            return _players;
        }

        public void AddPlayer(Player player)
        {
            player.Id = _players.Count + 1;
            _players.Add(player);
        }
    }
}