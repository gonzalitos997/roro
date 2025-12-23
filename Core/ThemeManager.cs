using System;
using Avalonia;
using Avalonia.Styling;

namespace BatchProcess3.Core;

/// <summary>
/// Manager for application theme switching
/// </summary>
public class ThemeManager
{
    private static ThemeManager? _instance;
    private ThemeMode _currentTheme = ThemeMode.Light;

    public static ThemeManager Instance => _instance ??= new ThemeManager();

    /// <summary>
    /// Gets the current theme mode
    /// </summary>
    public ThemeMode CurrentTheme
    {
        get => _currentTheme;
        private set => _currentTheme = value;
    }

    /// <summary>
    /// Event fired when theme changes
    /// </summary>
    public event EventHandler<ThemeMode>? ThemeChanged;

    private ThemeManager()
    {
    }

    /// <summary>
    /// Switches to the specified theme
    /// </summary>
    /// <param name="theme">Theme to switch to</param>
    public void SwitchTheme(ThemeMode theme)
    {
        CurrentTheme = theme;
        ApplyTheme(theme);
        ThemeChanged?.Invoke(this, theme);
    }

    /// <summary>
    /// Toggles between Light and Dark theme
    /// </summary>
    public void ToggleTheme()
    {
        var newTheme = CurrentTheme == ThemeMode.Light ? ThemeMode.Dark : ThemeMode.Light;
        SwitchTheme(newTheme);
    }

    /// <summary>
    /// Applies the theme by updating resource values
    /// </summary>
    private void ApplyTheme(ThemeMode theme)
    {
        var app = Application.Current;
        if (app == null) return;

        // Update the dynamic resources based on theme
        switch (theme)
        {
            case ThemeMode.Light:
                UpdateResource("PrimaryBrush", "LightPrimaryColor");
                UpdateResource("SecondaryBrush", "LightSecondaryColor");
                UpdateResource("BackgroundBrush", "LightBackgroundColor");
                UpdateResource("SurfaceBrush", "LightSurfaceColor");
                UpdateResource("TextBrush", "LightTextColor");
                UpdateResource("TextSecondaryBrush", "LightTextSecondaryColor");
                UpdateResource("BorderBrush", "LightBorderColor");
                UpdateResource("HoverBrush", "LightHoverColor");
                break;

            case ThemeMode.Dark:
                UpdateResource("PrimaryBrush", "DarkPrimaryColor");
                UpdateResource("SecondaryBrush", "DarkSecondaryColor");
                UpdateResource("BackgroundBrush", "DarkBackgroundColor");
                UpdateResource("SurfaceBrush", "DarkSurfaceColor");
                UpdateResource("TextBrush", "DarkTextColor");
                UpdateResource("TextSecondaryBrush", "DarkTextSecondaryColor");
                UpdateResource("BorderBrush", "DarkBorderColor");
                UpdateResource("HoverBrush", "DarkHoverColor");
                break;
        }
    }

    /// <summary>
    /// Updates a brush resource with a new color
    /// </summary>
    private void UpdateResource(string brushKey, string colorKey)
    {
        var app = Application.Current;
        if (app == null) return;

        if (app.Resources.TryGetResource(colorKey, null, out var colorResource) 
            && colorResource is Avalonia.Media.Color color)
        {
            app.Resources[brushKey] = new Avalonia.Media.SolidColorBrush(color);
        }
    }
}
