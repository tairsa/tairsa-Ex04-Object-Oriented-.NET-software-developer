using System;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    internal class Handlers
    {
        public static void ShowVersionClicked(MenuItem i_Sender)
        {
            Console.WriteLine("App Version: 25.2.4.4480");
        }

        public static void CountLowercaseClicked(MenuItem i_Sender)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            int count = 0;

            if (input != null)
            {
                foreach (char c in input)
                {
                    if (char.IsLower(c))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"> There are {count} lowercase letters in your text.");
        }

        public static void ShowDateClicked(MenuItem i_Sender)
        {
            Console.WriteLine($"> Current Date is {DateTime.Now:dd/MM/yyyy}");
        }

        public static void ShowTimeClicked(MenuItem i_Sender)
        {
            Console.WriteLine($"> Current Time is {DateTime.Now:HH:mm}");
        }

    }
}