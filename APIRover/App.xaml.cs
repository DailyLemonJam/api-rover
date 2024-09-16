using Microsoft.Extensions.DependencyInjection;
using APIRover.Views;
using Microsoft.Extensions.Hosting;
using System.Windows;
using APIRover.ViewModels;
using APIRover.Models;
using APIRover.Services.HttpService;
using APIRover.DbContext;
using Microsoft.EntityFrameworkCore;

namespace APIRover;

public partial class App : Application
{
    public static IHost? AppHost { get; private set; }

    public App()
    {
        var builder = Host.CreateDefaultBuilder();
        AppHost = builder
            .ConfigureServices(services =>
            {
                services.AddSingleton<MainWindowView>();
                services.AddSingleton<MainWindowViewModel>();
                services.AddSingleton<MainWindowModel>();

                services.AddTransient<IHttpService, HttpService>();

                services.AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseSqlite(); // TODO Configure connection string
                });
            })
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await AppHost!.StartAsync();
        
        var mainWindow = AppHost.Services.GetRequiredService<MainWindowView>();
        mainWindow.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost!.StopAsync();
        base.OnExit(e);
    }
}
