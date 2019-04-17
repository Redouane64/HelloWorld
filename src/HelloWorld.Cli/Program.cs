using System;
using System.Threading.Tasks;
using HelloWorld.Core;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld.Cli
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<HelloWorldFactory>();

            // Build services provider and execute core program.
            using var serviceProvider = services.BuildServiceProvider();
            
            await Runner.ExecuteAsync(serviceProvider);
            
        }
    }
}
