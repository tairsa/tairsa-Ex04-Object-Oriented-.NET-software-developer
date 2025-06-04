using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowDate : IListener<MenuItem>
    {
        public void Report(MenuItem i_Param)
        {
            Console.WriteLine($"> Current Date is {DateTime.Now:dd/MM/yyyy}");
        }
    }
}