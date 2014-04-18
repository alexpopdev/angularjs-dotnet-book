using ServiceStack.WebHost.Endpoints;

namespace Example2
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("Chapter3 Example2", typeof (AppHost).Assembly)
        {
        }

        public override void Configure(Funq.Container container)
        {
        }
    }
}