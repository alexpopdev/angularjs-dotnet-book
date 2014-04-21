using ServiceStack.ServiceInterface.Validation;
using ServiceStack.WebHost.Endpoints;

namespace Example4.Web
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("Chapter3 Example4", typeof (AppHost).Assembly)
        {
        }

        public override void Configure(Funq.Container container)
        {
            container.RegisterAutoWired<PlayersRepository>();

            Plugins.Add(new ValidationFeature());

            container.RegisterValidators(typeof(AppHost).Assembly);
        }
    }
}