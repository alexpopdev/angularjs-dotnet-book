using System;
using ServiceStack.WebHost.Endpoints;

namespace Example2.Web
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("Chapter3 Example2", typeof (AppHost).Assembly)
        {
        }

        public override void Configure(Funq.Container container)
        {
            RequestFilters.Add((request, response, requestData) =>
            {
                if(!request.IsSecureConnection)
                {
                    throw new Exception("The application needs to be secured. Use https instead of http for hosting!");
                }
            });
        }
    }
}