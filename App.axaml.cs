using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BatchProcess3.Core;
using BatchProcess3.ViewModels;

namespace BatchProcess3;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // Setup IoC Container
        SetupIoC();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }

    /// <summary>
    /// Configures the IoC container with application services
    /// </summary>
    private void SetupIoC()
    {
        // Register ViewModels
        IoC.Register(new MainWindowViewModel());

        // Register other services here as needed
        // Example: IoC.Register<IDataService>(new DataService());
    }
}