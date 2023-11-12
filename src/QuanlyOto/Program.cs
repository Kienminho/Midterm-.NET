using DAL;
using DTO.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace QuanlyOto
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // connectString
            string connectString = ConfigurationManager.ConnectionStrings[0].ConnectionString;

            var serviceProvider = new ServiceCollection()
                .AddDbContext<EntityContext>(options => options.UseSqlServer(connectString))
                .AddScoped<DataAccess>()
                .AddScoped<AccountAccess>()
                .AddScoped <CustomerAccess>()
                .AddScoped<ActionAccess>()
                .AddScoped<CarAccess>()
                .AddScoped<BookingsAccess>()
                .AddScoped<SchedulesAccess>()
                .BuildServiceProvider();

            var accountAccess = serviceProvider.GetService<AccountAccess>();
            var customerAccess = serviceProvider.GetService<CustomerAccess>();
            var actionAccess = serviceProvider.GetService<ActionAccess>();
            var carAccess = serviceProvider.GetService<CarAccess>();
            var bookingAccess = serviceProvider.GetService<BookingsAccess>();
            var schedulesAccess = serviceProvider.GetService<SchedulesAccess>();
            //var mainForm = new MainForm(accountAccess, customerAccess, actionAccess, carAccess, bookingAccess, schedulesAccess);
            var homeForm = new HomeForm(customerAccess, accountAccess, actionAccess, carAccess, bookingAccess, schedulesAccess);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            Application.Run(homeForm);
        }
    }

}