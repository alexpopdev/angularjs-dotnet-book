using ServiceStack.ServiceHost;

namespace Example4.Web
{
    [Route("/players", "POST")]
    public class Player : IReturn<Player>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}