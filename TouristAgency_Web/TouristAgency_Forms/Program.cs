using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TouristAgency.DataAccess.Data;
using TouristAgency.DataAccess.Repository;
using TouristAgency.DataAccess.Repository.IRepository;
using TouristAgency.DataAccess.UOW;

namespace TouristAgency_Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var mainForm = serviceProvider.GetRequiredService<HomeForm>();

            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<TouristAgencyDbContext>();

            services.AddScoped<IClientsRepository, ClientsRepositoryImpl>(); 
            services.AddScoped<IOrdersRepository, OrdersRepositoryImpl>();
            services.AddScoped<IExcursionsRepository, ExcursionsRepositoryImpl>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Register forms
            services.AddScoped<HomeForm>();
            services.AddScoped<ClientsForm>();
            services.AddScoped<OrdersForm>();
            services.AddScoped<ExcursionsForm>();
            services.AddScoped<LookupClients>();
            services.AddScoped<LookupDestinationsForm>();
            services.AddScoped<ChartForm>();
        }
    }
}