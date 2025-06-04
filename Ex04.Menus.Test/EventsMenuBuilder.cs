using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    internal static class EventsMenuBuilder
    {
        public static MainMenu Build()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu", true);

            MainMenu lettersMenu = new MainMenu("Letters and Version");

            MenuItem showVersionItem = new MenuItem("Show Version");
            showVersionItem.Clicked += Handlers.ShowVersionClicked;

            MenuItem countLowercaseItem = new MenuItem("Count Lowercase Letters");
            countLowercaseItem.Clicked += Handlers.CountLowercaseClicked;

            lettersMenu.AddMenuItem(showVersionItem);
            lettersMenu.AddMenuItem(countLowercaseItem);

            MenuItem lettersMenuItem = new MenuItem("Letters and Version");
            lettersMenuItem.Clicked += i_Sender => lettersMenu.Show();
            mainMenu.AddMenuItem(lettersMenuItem);

            MainMenu dateTimeMenu = new MainMenu("Show Current Date/Time");

            MenuItem showDateItem = new MenuItem("Show Current Date");
            showDateItem.Clicked += Handlers.ShowDateClicked;

            MenuItem showTimeItem = new MenuItem("Show Current Time");
            showTimeItem.Clicked += Handlers.ShowTimeClicked;

            dateTimeMenu.AddMenuItem(showDateItem);
            dateTimeMenu.AddMenuItem(showTimeItem);

            MenuItem dateTimeMenuItem = new MenuItem("Show Current Date/Time");
            dateTimeMenuItem.Clicked += i_Sender => dateTimeMenu.Show();
            mainMenu.AddMenuItem(dateTimeMenuItem);

            return mainMenu;
        }
    }
}