using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GetStartedApp.Views;

public partial class StartMenu  : Window
{
    public StartMenu ()
    {
        InitializeComponent();
    }
            private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
}