using Funq;
using ServiceStack;

namespace MorrisPhotos.Web
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("MorrisPhotos.com API", typeof(AppHost).Assembly)
        {
        }

        public override void Configure(Container container)
        {
        }
    }
}