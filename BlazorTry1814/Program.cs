using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTry1814
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            IServiceCollection services = builder.Services;
            ConfigureServices(builder, services);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(WebAssemblyHostBuilder builder, IServiceCollection services)
        {
            var appConfiguration = new AppConfiguration();
            services.AddSingleton(appConfiguration);
            Uri mainApiAddress = new Uri(string.IsNullOrEmpty(appConfiguration.ServerAddress) ? builder.HostEnvironment.BaseAddress : appConfiguration.ServerAddress); 
            services.AddScoped(sp => new HttpClient { BaseAddress = mainApiAddress });
            
        }
    }
}
