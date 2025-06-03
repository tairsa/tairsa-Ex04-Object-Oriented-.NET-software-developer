using System;
using System.Collections.Generic;
using Ex04.Menus.Interfaces;
using MainMenu = Ex04.Menus.Events.MainMenu;
using MenuItem = Ex04.Menus.Events.MenuItem;

namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Running Interfaces Menu...");
            Interfaces.MainMenu interfacesMenu = buildInterfacesMenu();
            interfacesMenu.Show();

            Console.WriteLine();
            Console.WriteLine("Running Events Menu...");
            MainMenu eventsMenu = buildEventsMenu();
            eventsMenu.Show();
        }

        private static Interfaces.MainMenu buildInterfacesMenu()
        {
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu("Interfaces Main Menu", true);

            // Submenu 1: Letters and Version
            Interfaces.MenuItem letters = new Interfaces.MenuItem("Letters and Version");
            Interfaces.MenuItem showVersion = new Interfaces.MenuItem("Show Version");
            showVersion.AddListener(new ShowVersion());
            Interfaces.MenuItem countLower = new Interfaces.MenuItem("Count Lowercase Letters");
            countLower.AddListener(new CountLowercase());
            letters.AddListener(new SubMenuLauncher("Letters and Version", new List<Interfaces.MenuItem> { showVersion, countLower }));

            // Submenu 2: Date/Time
            Interfaces.MenuItem dateTime = new Interfaces.MenuItem("Show Current Date/Time");
            Interfaces.MenuItem showDate = new Interfaces.MenuItem("Show Current Date");
            showDate.AddListener(new ShowDate());
            Interfaces.MenuItem showTime = new Interfaces.MenuItem("Show Current Time");
            showTime.AddListener(new ShowTime());
            dateTime.AddListener(new SubMenuLauncher("Show Current Date/Time", new List<Interfaces.MenuItem> { showDate, showTime }));

            mainMenu.AddMenuItem(letters);
            mainMenu.AddMenuItem(dateTime);
            return mainMenu;
        }

        private static MainMenu buildEventsMenu()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu", true);

            // Submenu 1
            MainMenu lettersMenu = new MainMenu("Letters and Version");

            MenuItem showVersionItem = new MenuItem("Show Version");
            showVersionItem.Clicked += showVersion_Clicked;

            MenuItem countLowercaseItem = new MenuItem("Count Lowercase Letters");
            countLowercaseItem.Clicked += countLowercase_Clicked;

            lettersMenu.AddMenuItem(showVersionItem);
            lettersMenu.AddMenuItem(countLowercaseItem);

            MenuItem lettersMenuItem = new MenuItem("Letters and Version");
            lettersMenuItem.Clicked += (i_Sender) => lettersMenu.Show();
            mainMenu.AddMenuItem(lettersMenuItem);

            // Submenu 2
            MainMenu dateTimeMenu = new MainMenu("Show Current Date/Time");

            MenuItem showDateItem = new MenuItem("Show Current Date");
            showDateItem.Clicked += showDate_Clicked;

            MenuItem showTimeItem = new MenuItem("Show Current Time");
            showTimeItem.Clicked += showTime_Clicked;

            dateTimeMenu.AddMenuItem(showDateItem);
            dateTimeMenu.AddMenuItem(showTimeItem);

            MenuItem dateTimeMenuItem = new MenuItem("Show Current Date/Time");
            dateTimeMenuItem.Clicked += (i_Sender) => dateTimeMenu.Show();
            mainMenu.AddMenuItem(dateTimeMenuItem);

            return mainMenu;
        }

        private static void showVersion_Clicked(MenuItem i_Sender)
        {
            Console.WriteLine("App Version: 25.2.4.4480");
        }

        private static void countLowercase_Clicked(MenuItem i_Sender)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            int count = 0;
            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"> There are {count} lowercase letters in your text.");
        }

        private static void showDate_Clicked(MenuItem i_Sender)
        {
            Console.WriteLine($"> Current Date is {DateTime.Now:dd/MM/yyyy}");
        }

        private static void showTime_Clicked(MenuItem i_Sender)
        {
            Console.WriteLine($"> Current Time is {DateTime.Now:HH:mm}");
        }
    }
}