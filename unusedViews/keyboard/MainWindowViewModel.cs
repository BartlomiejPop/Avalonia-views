using System.Collections.Generic;

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
                new ListElement { Normal = "F3", Shift = "F3", Alt = "F3", ShiftAlt = "F3", WidthMultiplier = 1.0 }
            }
            // Dodaj więcej wierszy w razie potrzeby
        };
    }
}
