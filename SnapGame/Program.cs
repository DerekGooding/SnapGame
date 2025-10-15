using SnapGame.Classes;
using SnapGame.Interfaces;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace SnapGame;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IGameService, GameService>();
        services.AddTransient<SnapGame>();
        using var provider = services.BuildServiceProvider();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var mainForm = provider.GetRequiredService<SnapGame>();
        Application.Run(mainForm);
    }
}