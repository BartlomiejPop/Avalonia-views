using System.Collections.Generic;
using System;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using System.Data.Common;

namespace GetStartedApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public class ListElement
        {
            public string Normal { get; set; }
            public string Shift { get; set; }
            public string Alt { get; set; }
            public string ShiftAlt { get; set; }
            public double WidthMultiplier { get; set; }
        }

        public class KeyboardScreenViewModel
        {
            public List<List<ListElement>> KeyboardRows { get; set; }

            public KeyboardScreenViewModel()
            {
                KeyboardRows = new List<List<ListElement>>
                {
                    new List<ListElement>
                    {
                        new ListElement { Normal = "Esc", Shift = "Esc", Alt = "Esc", ShiftAlt = "Esc", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "sp", Shift = "sp", Alt = "sp", ShiftAlt = "sp", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F1", Shift = "F1", Alt = "F1", ShiftAlt = "F1", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F2", Shift = "F2", Alt = "F2", ShiftAlt = "F2", WidthMultiplier = 1.0 },
                         new ListElement { Normal = "F3", Shift = "F3", Alt = "F3", ShiftAlt = "F3", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F4", Shift = "F4", Alt = "F4", ShiftAlt = "F4", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "sp", Shift = "sp", Alt = "sp", ShiftAlt = "sp", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F5", Shift = "F5", Alt = "F5", ShiftAlt = "F5", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F6", Shift = "F6", Alt = "F6", ShiftAlt = "F6", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F7", Shift = "F7", Alt = "F7", ShiftAlt = "F7", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F8", Shift = "F8", Alt = "F8", ShiftAlt = "F8", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "sp", Shift = "sp", Alt = "sp", ShiftAlt = "sp", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F9", Shift = "F9", Alt = "F9", ShiftAlt = "F9", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F10", Shift = "F10", Alt = "F10", ShiftAlt = "F10", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F11", Shift = "F11", Alt = "F11", ShiftAlt = "F11", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "F12", Shift = "F12", Alt = "F12", ShiftAlt = "F12", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "sp", Shift = "sp", Alt = "sp", ShiftAlt = "sp", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "PS", Shift = "PS", Alt = "PS", ShiftAlt = "PS", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "SL", Shift = "SL", Alt = "SL", ShiftAlt = "SL", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "PB", Shift = "PB", Alt = "PB", ShiftAlt = "PB", WidthMultiplier = 1.0 },
                    },
                    new List<ListElement>
                    {
                        new ListElement { Normal = "1", Shift = "!", Alt = "1", ShiftAlt = "1", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "2", Shift = "@", Alt = "2", ShiftAlt = "2", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "3", Shift = "#", Alt = "3", ShiftAlt = "3", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "4", Shift = "$", Alt = "4", ShiftAlt = "4", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "5", Shift = "%", Alt = "5", ShiftAlt = "5", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "6", Shift = "^", Alt = "6", ShiftAlt = "6", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "7", Shift = "&", Alt = "7", ShiftAlt = "7", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "8", Shift = "*", Alt = "8", ShiftAlt = "8", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "9", Shift = "(", Alt = "9", ShiftAlt = "9", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "0", Shift = ")", Alt = "0", ShiftAlt = "0", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "-", Shift = "_", Alt = "-", ShiftAlt = "-", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "=", Shift = "+", Alt = "=", ShiftAlt = "=", WidthMultiplier = 1.0 },
                        new ListElement { Normal = "sp", Shift = "sp", Alt = "sp", ShiftAlt = "sp", WidthMultiplier = 1.0 },
                    }
                    // Dodaj więcej wierszy w razie potrzeby
                };
            }
        }

        // Dodanie publicznej właściwości dla KeyboardScreenViewModel
        public KeyboardScreenViewModel KeyboardScreen { get; set; }

        public MainWindowViewModel()
        {
            // Inicjalizacja KeyboardScreen
            KeyboardScreen = new KeyboardScreenViewModel();
        }
    }
}
