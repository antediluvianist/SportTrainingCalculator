using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SportExercicesCalculator.Utilities
{
    public static class PrintText
    {
        private static int consoleWidth = Console.WindowWidth;
        private static int currentSpeed = 30; // Vitesse par défaut

        public static void Print(string text)
        {
            string[] words = text.Split(' ');
            int currentLineLength = 0;

            foreach (string word in words)
            {
                // Check if the word fits in the remaining space on the current line
                if (currentLineLength + word.Length + 1 > consoleWidth)
                {
                    Console.WriteLine();
                    currentLineLength = 0;
                }

                // Print the word with a space after it
                foreach (char c in word)
                {
                    Console.Write(c);
                    Thread.Sleep(currentSpeed);
                }

                Console.Write(' ');
                currentLineLength += word.Length + 1;
                Thread.Sleep(currentSpeed);
            }

            Console.WriteLine();
        }

        public static void PrintSlow(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(120); // Vitesse rapide
            }
            Console.WriteLine();
        }

        public static void PrintSpeed(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(10); // Vitesse rapide
            }
            Console.WriteLine();
        }

        public static void PrintInstant(string text)
        {
            string[] words = text.Split(' ');
            int currentLineLength = 0;

            foreach (string word in words)
            {
                // Check if the word fits in the remaining space on the current line
                if (currentLineLength + word.Length + 1 > consoleWidth)
                {
                    Console.WriteLine();
                    currentLineLength = 0;
                }

                // Print the word with a space after it
                foreach (char c in word)
                {
                    Console.Write(c);
                    Thread.Sleep(0);
                }

                Console.Write(' ');
                currentLineLength += word.Length + 1;
                Thread.Sleep(0);
            }

            Console.WriteLine();
        }

        public static void SetPrintSpeed(int speed)
        {
            currentSpeed = speed;
        }

        public static int GetCurrentSpeed()
        {
            return currentSpeed;
        }

        /*
        // Next
        public static void Next()
        {
            Console.ReadKey();
            AudioManager.PlayTestSound();
            Console.Clear();
        }*/
    }
}
