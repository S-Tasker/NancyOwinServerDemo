using Microsoft.AspNetCore.Builder;
using Nancy;
using Nancy.Owin;

namespace NancyOwinServerDemo
{
    public class ServerModule : NancyModule
    {
        public ServerModule()
        {

            Get("/", args => "Hello world!");

        }
    }

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
    }
}
