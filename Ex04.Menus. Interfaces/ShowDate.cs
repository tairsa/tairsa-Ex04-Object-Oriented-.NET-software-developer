using System;

namespace Ex04.Menus.Interfaces
{
    public class ShowDate : IListener<MenuItem>
    {
        public void Report(MenuItem i_Param)
        {
            Console.WriteLine($"> Current Date is {DateTime.Now:dd/MM/yyyy}");
        }
    }
}