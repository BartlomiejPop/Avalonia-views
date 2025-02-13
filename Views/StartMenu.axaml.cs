using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GetStartedApp.ViewModels;

namespace GetStartedApp.Views;

public partial class StartMenu  : Window
{
    public StartMenu ()
    {
        InitializeComponent();
        this.DataContext = new MainWindowViewModel(); // Ustawienie DataContext na ViewModel
    }
            private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
}