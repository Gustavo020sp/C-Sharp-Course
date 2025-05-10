using RestSharp;
using static System.Net.WebRequestMethods;
using System.Text.Json;
using Pokemon_API.Entities;
using Microsoft.VisualBasic;
using Pokemon_API.Controller;
using Microsoft.Extensions.DependencyInjection;

namespace Pokemon_API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configura o contêiner DI
            var serviceProvider = ConfigureServices();

            // Resolve o controlador a partir do contêiner DI
            var controller = serviceProvider.GetRequiredService<TamagotchiController>();

            // Executa a lógica
            controller.GenerateInteraction();
        }
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Registra os serviços e controladores
            services.AddTransient<TamagotchiController>();
            //services.AddTransient<UserInteraction>();

            return services.BuildServiceProvider();
        }
    }
}
