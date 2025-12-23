using System.Windows.Input;
using BatchProcess3.Core;

namespace BatchProcess3.ViewModels;

/// <summary>
/// ViewModel for the Main Window
/// </summary>
public class MainWindowViewModel : ViewModelBase
{
    #region Private Fields

    private string _welcomeMessage = "Welcome to Avalonia MVVM!";
    private int _counter = 0;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the welcome message
    /// </summary>
    public string WelcomeMessage
    {
        get => _welcomeMessage;
        set => SetProperty(ref _welcomeMessage, value);
    }

    /// <summary>
    /// Gets or sets the counter value
    /// </summary>
    public int Counter
    {
        get => _counter;
        set => SetProperty(ref _counter, value);
    }

    #endregion

    #region Commands

    /// <summary>
    /// Command to increment the counter
    /// </summary>
    public ICommand IncrementCommand { get; }

    /// <summary>
    /// Command to reset the counter
    /// </summary>
    public ICommand ResetCommand { get; }

    #endregion

    #region Constructor

    public MainWindowViewModel()
    {
        // Initialize commands
        IncrementCommand = new RelayCommand(OnIncrement);
        ResetCommand = new RelayCommand(OnReset, CanReset);
    }

    #endregion

    #region Command Handlers

    private void OnIncrement(object? parameter)
    {
        Counter++;
        WelcomeMessage = $"Button clicked {Counter} time(s)!";
    }

    private void OnReset(object? parameter)
    {
        Counter = 0;
        WelcomeMessage = "Counter has been reset!";
    }

    private bool CanReset(object? parameter)
    {
        return Counter > 0;
    }

    #endregion
}
