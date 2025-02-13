using System;
using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace GetStartedApp.ViewModels
{

    
    public class MainWindowViewModel : ViewModelBase
    {
        
        public string Greeting { get; set; } = "KLAWIATURA";
        public string SettingsText { get; set; } = "USTAWIENIA";
        public string LanguageText { get; set; } = "JĘZYK/LANGUAGE";

        public ICommand NavigateToKeyboardCommand { get; }
        public ICommand NavigateToSettingsCommand { get; }
        public ICommand NavigateToLanguageCommand { get; }

        public MainWindowViewModel()
        {
            NavigateToKeyboardCommand = new RelayCommand(NavigateToKeyboard);
            NavigateToSettingsCommand = new RelayCommand(NavigateToSettings);
            NavigateToLanguageCommand = new RelayCommand(NavigateToLanguage);
        }

        private void NavigateToKeyboard()
{
    Console.WriteLine("Navigating to Keyboard Screen");
    Debug.WriteLine("Debug: Navigating to Keyboard Screen");
}
        private void NavigateToSettings() => Console.WriteLine("Navigating to Settings Screen");
        private void NavigateToLanguage() => Console.WriteLine("Navigating to Language Screen");
    }
}
