using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowTime : IListener<MenuItem>
    {
        public void Report(MenuItem i_Param)
        {
            Console.WriteLine($"> Current Time is {DateTime.Now:HH:mm}");
        }
    }
}