using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class CountLowercase : IListener<MenuItem>
    {
        public void Report(MenuItem i_Param)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            int count = 0;

            if(input != null)
            {
                foreach(char c in input)
                {
                    if(char.IsLower(c))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"> There are {count} lowercase letters.");
        }
    }
}