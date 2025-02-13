using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GetStartedApp.Views;

public partial class Keyboard  : UserControl
{
    public Keyboard ()
    {
        InitializeComponent();
    }
            private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
}