using ServiceStack.ServiceHost;

namespace Example4.Web
{
    [Route("/players/{Id}", "GET")]
    public class GetPlayerRequest : IReturn<Player>
    {
        public int Id { get; set; }
    }
}