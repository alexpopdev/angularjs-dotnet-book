using ServiceStack.WebHost.Endpoints;

namespace Example1
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("Chapter3 Example1", typeof (AppHost).Assembly)
        {
        }

        public override void Configure(Funq.Container container)
        {
        }
    }
}