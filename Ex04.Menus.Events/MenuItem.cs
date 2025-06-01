using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    internal class MenuItem
    {
        public string Title { get; }
        public List<MenuItem> SubItems { get; }
        public Action Action { get; }

        public MenuItem(string i_Title, Action i_Action)
        {
            Title = i_Title;
            Action = i_Action;
            SubItems = new List<MenuItem>();
        }

        public void AddSubItem(MenuItem i_SubItem)
        {
            SubItems.Add(i_SubItem);
        }

        public bool IsLeaf => SubItems.Count == 0 && Action != null;
    }
}
