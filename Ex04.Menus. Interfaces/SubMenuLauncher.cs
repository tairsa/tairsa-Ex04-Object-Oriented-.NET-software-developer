using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenuLauncher : IListener<MenuItem>
    {
        private readonly string r_Title;
        private readonly List<MenuItem> r_SubItems;

        public SubMenuLauncher(string i_Title, List<MenuItem> i_SubItems)
        {
            r_Title = i_Title;
            r_SubItems = i_SubItems;
        }

        public void Report(MenuItem i_MenuItem)
        {
            MainMenu subMenu = new MainMenu(r_Title);
            foreach (MenuItem item in r_SubItems)
            {
                subMenu.AddMenuItem(item);
            }

            subMenu.Show();
        }
    }
}