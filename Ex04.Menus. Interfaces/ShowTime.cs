using System;

namespace Ex04.Menus.Interfaces
{
    public class ShowTime : IListener<MenuItem>
    {
        public void Report(MenuItem i_Param)
        {
            Console.WriteLine($"> Current Time is {DateTime.Now:HH:mm}");
        }
    }
}