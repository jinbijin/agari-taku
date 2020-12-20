using AgariTaku.Client.Injector;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AgariTaku.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            Container container = new();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<IComponentActivator>(new SimpleInjectorComponentActivator(container));

            foreach (Type type in container.GetTypesToRegister<IComponent>(typeof(App).Assembly, typeof(NavLink).Assembly))
            {
                container.Register(type, type, Lifestyle.Scoped);
            }

            foreach (Type type in container.GetTypesToRegister<IComponent>(typeof(RouteView).Assembly))
            {
                container.Register(type, type, Lifestyle.Singleton);
            }

            await builder.Build().RunAsync();
        }
    }
}
