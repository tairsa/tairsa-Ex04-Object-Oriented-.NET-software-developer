using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        private readonly bool r_IsRootMenu;

        private string Title { get; }

        public MainMenu(string i_Title, bool i_IsRootMenu = false)
        {
            Title = i_Title;
            r_IsRootMenu = i_IsRootMenu;
        }

        public void AddMenuItem(MenuItem i_Item)
        {
            r_MenuItems.Add(i_Item);
        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("{0}", Title);
                Console.WriteLine(new string('-', Title.Length + 8));

                for (int i = 0; i < r_MenuItems.Count; i++)
                {
                    Console.Write($"{i + 1}. ");
                    r_MenuItems[i].Draw();
                }

                string exitOrBack = r_IsRootMenu ? "Exit" : "Back";
                string exitOrBackPrompt = r_IsRootMenu ? "exit" : "back";

                Console.WriteLine("0. {0}", exitOrBack);
                if (r_MenuItems.Count > 0)
                {
                    Console.Write($"Please select an option (1-{r_MenuItems.Count} or 0 to {exitOrBackPrompt}): ");
                }

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice) && choice >= 0 && choice <= r_MenuItems.Count)
                {
                    if (choice == 0)
                    {
                        Console.Clear();
                        return;
                    }

                    MenuItem selectedItem = r_MenuItems[choice - 1];
                    Console.Clear();
                    selectedItem.AMethodForMenuToTellIWasClicked(); 

                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid input. Press any key to try again...");
                    Console.ReadKey();
                }
            }
        }
    }
}
