using System.Collections.Generic;
using Example2.Web;
using ServiceStack.ServiceClient.Web;

namespace Example2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new JsonServiceClient("http://localhost:54114/");
            List<Player> players = client.Get(new GetPlayersRequest()); 
            players.ForEach(player => System.Console.WriteLine("Player {0} details: first name - {1}, last name - {2}",  player.Id, player.FirstName, player.LastName));
            System.Console.WriteLine("Press any key to continue ...");
            System.Console.ReadLine();
        }
    }
}
