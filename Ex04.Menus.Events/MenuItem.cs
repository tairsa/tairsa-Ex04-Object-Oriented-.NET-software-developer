using System;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private string Title { get; }

        public event Action<MenuItem> Clicked;

        public MenuItem(string i_Title)
        {
            Title = i_Title;
        }

        public void AMethodForMenuToTellIWasClicked()
        {
            OnClicked();
        }

        protected virtual void OnClicked()
        {
            if (Clicked != null)
            {
                Clicked.Invoke(this);
            }
        }

        public void Draw()
        {
            Console.WriteLine("{0}", Title);
        }
    }
}