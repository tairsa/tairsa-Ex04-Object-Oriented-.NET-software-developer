using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    internal class MainMenu
    {
        private readonly MenuItem r_Root;

        public MainMenu(MenuItem i_Root)
        {
            r_Root = i_Root;
        }

        public void Show()
        {
            navigateMenu(r_Root);
        }

        private void navigateMenu(MenuItem i_CurrentMenu)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine($"** {i_CurrentMenu.Title} **");
                Console.WriteLine(new string('-', i_CurrentMenu.Title.Length + 6));

                for (int i = 0; i < i_CurrentMenu.SubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {i_CurrentMenu.SubItems[i].Title}");
                }

                Console.WriteLine("0. " + (i_CurrentMenu == r_Root ? "Exit" : "Back"));

                Console.Write("Please enter your choice: ");

                string input = Console.ReadLine();


                if (!int.TryParse(input, out int choice) || choice < 0 || choice > i_CurrentMenu.SubItems.Count)
                {
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    continue;
                }

                if (choice == 0) break;

                MenuItem selected = i_CurrentMenu.SubItems[choice - 1];
                if (selected.IsLeaf)
                {
                    Console.Clear();
                    selected.Action?.Invoke();
                    Console.WriteLine("\nPress any key to return...");
                    Console.ReadKey();
                }
                else
                {
                    navigateMenu(selected);
                }
            }
        }


    }
}
