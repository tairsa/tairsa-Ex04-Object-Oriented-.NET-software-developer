using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItemListener
    {
        public string Title { get; }

        private readonly List<IMenuItemListener> r_ClickedListeners = new List<IMenuItemListener>();

        private List<IListener<object>> m_ShowVersionListeners;

        public MenuItem(string iTitle)
        {
            Title = iTitle;
        }

        public void AttachListener(IMenuItemListener iListener)
        {
            r_ClickedListeners.Add(iListener);
        }

        public void DetachListener(IMenuItemListener iListener)
        {
            r_ClickedListeners.Remove(iListener);
        }

        public void Draw()
        {
            Console.WriteLine("{0}", Title);
        }

        private void doWhenClick()
        {
            notifyClickListeners();
        }

        private void notifyClickListeners()
        {
            foreach (IMenuItemListener listener in r_ClickedListeners)
            {
                listener.ReportClick();
            }
        }
    }
}