using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Events.MenuItem;

namespace Ex04.Menus.Tes
{
    internal class Program
    {
        static void Main()
        {
            //RunInterfaceMenu();

            runDelegateMenu();
        }

        private static void runDelegateMenu()
        {
            var coffee = new Ex04.Menus.Events.MenuItem("Coffee");
            coffee.AddSubItem(new Ex04.Menus.Events.MenuItem("Espresso", () =>
                {
                    Console.WriteLine("Making espresso...");
                }));

            var root = new Ex04.Menus.Events.MenuItem("Drinks");
            root.AddSubItem(coffee);
            root.AddSubItem(new Ex04.Menus.Events.MenuItem("Juice", () =>
                {
                    Console.WriteLine("Pouring juice...");
                }));

            var menu = new Ex04.Menus.Events.MenuItem(root);
            menu.Show();
        }
    }
}

