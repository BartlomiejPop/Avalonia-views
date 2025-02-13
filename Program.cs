using Avalonia;
using System;

namespace GetStartedApp;

sealed class Program
{
    [STAThread]
          public static void Main(string[] args)
        {
            // Wypisanie tekstu do konsoli przy starcie aplikacji
            Console.WriteLine("Aplikacja Avalonia została uruchomiona!");

            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }
        

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}
