using SportExercicesCalculator.Ascii;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SportExercicesCalculator
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Illustrations.MenuTitle);
            Console.WriteLine("");
            Console.WriteLine(Illustrations.MenuIllustration);
            Console.WriteLine("                                   Welcome to your home sport calculator");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("1. Start calculation");
            Console.WriteLine("2. Quit");
            Console.WriteLine("");

            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "1":
                    //New Calculation
                    Calculator.NewCalculation();
                    break;

                case "2":
                    //Quit the program
                    Environment.Exit(0); ;
                    break;

                default:
                    Console.Clear();
                    ShowMenu();
                    break;
            }
        }
    }
}
