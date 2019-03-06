using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld.Cli
{
    internal class Runner
    {
        /// <summary>
        /// Execute core logic.
        /// </summary>
        /// <param name="services">Services collection.</param>
        internal static async Task ExecuteAsync(IServiceProvider services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            var factory = services.GetService<HelloWorld.Core.HelloWorldFactory>();
            var helloworld = factory.Create();
            
            await Task.Yield();

            Console.WriteLine(helloworld.Message);
        }
    }
}