using System;
using System.Net.Http;
using System.Threading.Tasks;
using BackOffice.Helper;
using BackOffice.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace BackOffice
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddHttpClient("ServerAPI",
                    client => client.BaseAddress = new Uri(builder.Configuration["ApiUrl"]))
                .AddHttpMessageHandler<BearerTokenHandler>();

            builder.Services.AddTransient(sp => sp.GetRequiredService<IHttpClientFactory>()
                .CreateClient("ServerAPI"));
            builder.Services.AddOidcAuthentication(options =>
            {
                builder.Configuration.Bind("Local", options.ProviderOptions);
            });
            builder.Services.AddApiAuthorization();
            builder.Services.AddScoped<IMatchingService, MatchingService>();
            builder.Services.AddTransient<BearerTokenHandler>();
            builder.Services.AddMudServices();
            await builder.Build().RunAsync();
        }
    }
}
