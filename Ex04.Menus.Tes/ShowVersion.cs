using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowVersion : IListener<MenuItem>
    {
        public void Report(MenuItem i_Param)
        {
            Console.WriteLine("App Version: 25.2.4.4480");
        }
    }
}