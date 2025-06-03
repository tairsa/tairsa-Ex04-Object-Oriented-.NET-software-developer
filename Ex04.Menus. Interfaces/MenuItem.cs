using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        public string Title { get; }

        private readonly List<IListener<MenuItem>> r_Listeners = new List<IListener<MenuItem>>();

        public MenuItem(string i_Title)
        {
            Title = i_Title;
        }

        public void AddListener(IListener<MenuItem> i_Listener)
        {
            r_Listeners.Add(i_Listener);
        }

        public void RemoveListener(IListener<MenuItem> i_Listener)
        {
            r_Listeners.Remove(i_Listener);
        }

        public void Draw()
        {
            Console.WriteLine("{0}", Title);
        }

        public void AMethodForMenuToTellIWasClicked()
        {
            notifyListeners();
        }

        private void notifyListeners()
        {
            foreach (IListener<MenuItem> listener in r_Listeners)
            {
                listener.Report(this);
            }
        }
    }
}