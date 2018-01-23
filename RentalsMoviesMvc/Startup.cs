using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalsMoviesMvc.Startup))]
namespace RentalsMoviesMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
