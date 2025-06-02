using System;
using Ex04.Menus.Events;


namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            MainMenu topMenu = buildFullMenu();
            topMenu.Show();
        }

        private static MainMenu buildFullMenu()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu",true);

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
