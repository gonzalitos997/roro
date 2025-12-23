using System.Windows.Input;
using BatchProcess3.Core;

namespace BatchProcess3.ViewModels;

/// <summary>
/// ViewModel for the Main Window
/// </summary>
public class MainWindowViewModel : ViewModelBase
{
    #region Private Fields

    private string _welcomeMessage = "Welcome to Avalonia MVVM with Custom Themes!";
    private int _counter = 0;
    private string _currentThemeText = "Light Theme";
    private readonly ThemeManager _themeManager;

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

    /// <summary>
    /// Gets or sets the current theme text
    /// </summary>
    public string CurrentThemeText
    {
        get => _currentThemeText;
        set => SetProperty(ref _currentThemeText, value);
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

    /// <summary>
    /// Command to toggle theme
    /// </summary>
    public ICommand ToggleThemeCommand { get; }

    #endregion

    #region Constructor

    public MainWindowViewModel()
    {
        _themeManager = ThemeManager.Instance;
        
        // Initialize commands
        IncrementCommand = new RelayCommand(OnIncrement);
        ResetCommand = new RelayCommand(OnReset, CanReset);
        ToggleThemeCommand = new RelayCommand(OnToggleTheme);

        // Subscribe to theme changes
        _themeManager.ThemeChanged += OnThemeChanged;
        
        // Set initial theme text
        UpdateThemeText();
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

    private void OnToggleTheme(object? parameter)
    {
        _themeManager.ToggleTheme();
    }

    #endregion

    #region Event Handlers

    private void OnThemeChanged(object? sender, ThemeMode newTheme)
    {
        UpdateThemeText();
        WelcomeMessage = $"Theme changed to {newTheme}!";
    }

    private void UpdateThemeText()
    {
        CurrentThemeText = _themeManager.CurrentTheme == ThemeMode.Light 
            ? "🌞 Light Theme" 
            : "🌙 Dark Theme";
    }

    #endregion
}
