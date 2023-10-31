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
                .BuildServiceProvider();

            var accountAccess = serviceProvider.GetService<AccountAccess>();
            var mainForm = new MainForm(accountAccess);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            Application.Run(mainForm);
        }
    }

}