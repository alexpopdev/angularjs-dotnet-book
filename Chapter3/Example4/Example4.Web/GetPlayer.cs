using ServiceStack.ServiceHost;

namespace Example4.Web
{
    [Route("/players/{Id}", "GET")]
    public class GetPlayer : IReturn<Player>
    {
        public int Id { get; set; }
    }
}