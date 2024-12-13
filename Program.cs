using sftp_user_creator.config;
using Microsoft.Extensions.DependencyInjection;
using sftp_user_creator.config;
using System;
using System.IO;
using System.Windows.Forms;

namespace sftp_user_creator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            string dataDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
            string configPath = Path.Combine(dataDirectory, "defaults.txt");
            Directory.CreateDirectory(dataDirectory);
            services.AddSingleton<IConfigurationService>(new FileConfigurationService(configPath));
            services.AddTransient<MainForm>();
        }
    }
}