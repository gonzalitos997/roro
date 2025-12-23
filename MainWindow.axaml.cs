using Avalonia.Controls;
using BatchProcess3.ViewModels;

namespace BatchProcess3;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        // Set the DataContext to the ViewModel
        DataContext = new MainWindowViewModel();
    }
}