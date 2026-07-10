using Avalonia;

namespace OppoPodsManager;

static class Program
{
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UseWayland()
            .WithInterFont()
            .LogToTrace();

    public static void Main(string[] args)
        => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
}
