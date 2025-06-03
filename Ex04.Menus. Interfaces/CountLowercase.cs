using System;

namespace Ex04.Menus.Interfaces
{
    public class CountLowercase : IListener<MenuItem>
    {
        public void Report(MenuItem i_Param)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            int count = 0;
            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"> There are {count} lowercase letters.");
        }
    }
}