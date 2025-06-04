using System.Collections.Generic;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal static class InterfacesMenuBuilder
    {
        public static MainMenu Build()
        {
            MainMenu mainMenu = new MainMenu("Interfaces Main Menu", true);

            MenuItem letters = new MenuItem("Letters and Version");
            MenuItem showVersion = new MenuItem("Show Version");
            showVersion.AddListener(new ShowVersion());

            MenuItem countLower = new MenuItem("Count Lowercase Letters");
            countLower.AddListener(new CountLowercase());

            letters.AddListener(new SubMenuLauncher("Letters and Version", new List<MenuItem>
        {
            showVersion,
            countLower
        }));

            MenuItem dateTime = new MenuItem("Show Current Date/Time");
            MenuItem showDate = new MenuItem("Show Current Date");
            showDate.AddListener(new ShowDate());

            MenuItem showTime = new MenuItem("Show Current Time");
            showTime.AddListener(new ShowTime());

            dateTime.AddListener(new SubMenuLauncher("Show Current Date/Time", new List<MenuItem>
        {
            showDate,
            showTime
        }));

            mainMenu.AddMenuItem(letters);
            mainMenu.AddMenuItem(dateTime);

            return mainMenu;
        }
    }
}