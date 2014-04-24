using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace Example4.Web
{
    [Route("/players", "GET")]
    public class GetPlayers : IReturn<List<Player>>
    {
    }
}