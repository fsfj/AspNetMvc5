using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AspNetMvc5.Startup))]

namespace AspNetMvc5
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // ConfigureAuth(app);
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }

    }
}
