
using System;

namespace SithVsJedi
{
    class Tools
    {
        public static void ColourfulConsole (string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
