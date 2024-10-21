using SportExercicesCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportExercicesCalculator
{
    public class Calculator
    {
        public static void NewCalculation()
        {
            // Name

            Console.Clear();
            PrintText.Print("What's your name?");
            Console.WriteLine("");

            string name = Console.ReadLine();

            // Call the sub-functions
            int maximumPushUp = AskPushUp(name);
            AskPlank(name, maximumPushUp);

        }

        public static int AskPushUp(string name)
        {
            Console.Clear();
            PrintText.Print(name + " how many maximum push-up can you do now ?");
            Console.WriteLine("");

            string pushUpInput = Console.ReadLine();

            if (int.TryParse(pushUpInput, out int maximumPushUp))
            {
                if (maximumPushUp < 10)
                {
                    Console.Clear();
                    PrintText.Print("For optimal efficiency, this program recommends you to be able to do at least 10 push-ups before starting it.");
                    Console.WriteLine();
                    PrintText.Print("Press any key...");
                    Console.ReadLine();
                    Console.Clear();
                    Menu.ShowMenu();
                    return -1;  // Returning invalid value to terminate
                }
                else
                {
                    return maximumPushUp;
                }
            }
            else
            {
                Console.Clear();
                PrintText.Print("Invalid input. Please enter a valid number for push-ups.");
                Console.WriteLine();
                PrintText.Print("Press any key to retry...");
                Console.ReadLine();
                Console.Clear();
                return AskPushUp(name);  // Retry
            }
        }


        public static void AskPlank(string name, int maximumPushUp)
        {
            // Plank

            Console.Clear();
            PrintText.Print(name + " how long, at most, can you stay in plank position (in seconds) ?");
            Console.WriteLine("");

            string plankInput = Console.ReadLine();

            if (int.TryParse(plankInput, out int maximumPlank))
            {
                if (maximumPlank < 30)
                {
                    Console.Clear();
                    PrintText.Print("For an optimal efficiency, this program recommand you to be able of staying a minimum of 30s in plank position before starting this program.");
                    Console.WriteLine();
                    PrintText.Print("Press any key...");
                    Console.ReadLine();
                    Console.Clear();
                    Menu.ShowMenu();
                }
                else
                {
                    Console.Clear();
                    PrintText.PrintSlow("Calculation in progress...");
                    Console.WriteLine("");
                    PrintText.PrintInstant("Press any key to get your personnal program training.");
                    Console.ReadLine();
                    YourCalculation(maximumPushUp, maximumPlank, name);
                }
            }
            else
            {
                // If input is not valid
                Console.Clear();
                PrintText.Print("Invalid input. Please enter a valid number for planking.");
                Console.WriteLine();
                PrintText.Print("Press any key to retry...");
                Console.ReadLine();
                Console.Clear();
                AskPlank(name, maximumPushUp);
            }

        }


        public static void YourCalculation(int maximumPushUp, int maximumPlank, string name)
        {

            int pushUpDay1;
            int pushUpDay2;
            int pushUpDay3;
            int pushUpDay4;
            int pushUpDay5;
            int pushUpDay6;
            int pushUpDay7;
            int pushUpDay8;
            int pushUpDay9;
            int pushUpDay10;

            int pushUpDone;

            int plankDay1;
            int plankDay2;
            int plankDay3;
            int plankDay4;
            int plankDay5;
            int plankDay6;
            int plankDay7;
            int plankDay8;
            int plankDay9;
            int plankDay10;

            int plankDone;
            float plankInMinutes;

            // Training Calcul

            pushUpDay1 = maximumPushUp * 50 / 100;
            pushUpDay2 = maximumPushUp * 55 / 100;
            pushUpDay3 = maximumPushUp * 60 / 100;
            pushUpDay4 = maximumPushUp * 65 / 100;
            pushUpDay5 = maximumPushUp * 70 / 100;
            pushUpDay6 = maximumPushUp * 75 / 100;
            pushUpDay7 = maximumPushUp * 80 / 100;
            pushUpDay8 = maximumPushUp * 85 / 100;
            pushUpDay9 = maximumPushUp * 90 / 100;
            pushUpDay10 = maximumPushUp * 95 / 100;

            plankDay1 = maximumPlank * 50 / 100;
            plankDay2 = maximumPlank * 55 / 100;
            plankDay3 = maximumPlank * 60 / 100;
            plankDay4 = maximumPlank * 65 / 100;
            plankDay5 = maximumPlank * 70 / 100;
            plankDay6 = maximumPlank * 75 / 100;
            plankDay7 = maximumPlank * 80 / 100;
            plankDay8 = maximumPlank * 85 / 100;
            plankDay9 = maximumPlank * 90 / 100;
            plankDay10 = maximumPlank * 95 / 100;

            // Total Calcul
            pushUpDone = (pushUpDay1 * 10) + (pushUpDay2 * 10) + (pushUpDay3 * 9) + (pushUpDay4 * 9) + (pushUpDay5 * 8) + (pushUpDay6 * 8) + (pushUpDay7 * 6) + (pushUpDay8 * 6) + (pushUpDay9 * 5) + (pushUpDay10 * 4);
            plankDone = (plankDay1 * 10) + (plankDay2 * 10) + (plankDay3 * 9) + (plankDay4 * 9) + (plankDay5 * 8) + (plankDay6 * 8) + (plankDay7 * 6) + (plankDay8 * 6) + (plankDay9 * 5) + (plankDay10 * 4);
            plankInMinutes = (plankDone / 60);


            Console.Clear();
            Console.WriteLine("YOUR TRAINING PROGRAM:");
            Console.WriteLine("=====================");
            Console.WriteLine("");

            // 1st col
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}", "Day 1", "Day 2", "Day 3", "Day 4");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}", "=======", "=======", "=======", "=======");
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}",
                $"Push-up: {pushUpDay1}x10",
                $"Push-up: {pushUpDay2}x10",
                $"Push-up: {pushUpDay3}x9",
                $"Push-up: {pushUpDay4}x9");
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}",
                $"Plank: {plankDay1}s x10",
                $"Plank: {plankDay2}s x10",
                $"Plank: {plankDay3}s x9",
                $"Plank: {plankDay4}s x9");
            Console.WriteLine();

            // 2nd col
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}", "Day 5", "Day 6", "Day 7", "Day 8");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}", "=======", "=======", "=======", "=======");
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}",
                $"Push-up: {pushUpDay5}x8",
                $"Push-up: {pushUpDay6}x8",
                $"Push-up: {pushUpDay7}x6",
                $"Push-up: {pushUpDay8}x6");
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}",
                $"Plank: {plankDay5}s x8",
                $"Plank: {plankDay6}s x8",
                $"Plank: {plankDay7}s x6",
                $"Plank: {plankDay8}s x6");
            Console.WriteLine();

            // 3rd col
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}", "Day 9", "Day 10", "Day 11", "Day 12");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}", "=======", "=======", "=======", "=======");
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}",
                $"Push-up: {pushUpDay9}x5",
                $"Push-up: {pushUpDay10}x4",
                "Rest",
                "Rest");
            Console.WriteLine("{0,-16} {1,-16} {2,-16} {3,-16}",
                $"Plank: {plankDay9}s x5",
                $"Plank: {plankDay10}s x4",
                "Rest",
                "Rest");
            Console.WriteLine();

            // Total
            Console.WriteLine("=====================");
            Console.WriteLine("");

            Console.Write("Total Push-ups done: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(pushUpDone);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("");
            
            Console.Write("Total Plank done: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(plankInMinutes);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" minutes (" + plankDone + " seconds)");

            // Générer l'horodatage pour le fichier
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            // Nom du fichier avec le nom de l'utilisateur et horodatage
            string fileName = $"{name}_TrainingProgram_{timestamp}.txt";

            // End choice
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1. Save your program (.txt)");
            Console.WriteLine("2. Back to main menu");
            Console.WriteLine("3. Quit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Génération du nom de fichier avec nom de l'utilisateur et horodatage
                string currentTimestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string trainingFileName = $"{name}_TrainingProgram_{currentTimestamp}.txt";

                // Obtenir le chemin vers le bureau de l'utilisateur
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Créer un chemin complet vers le fichier sur le bureau
                string filePath = Path.Combine(desktopPath, trainingFileName);

                // Créer le contenu du fichier qui correspond à l'affichage
                StringBuilder fileContent = new StringBuilder();
                fileContent.AppendLine("YOUR TRAINING PROGRAM:");
                fileContent.AppendLine("=====================");
                fileContent.AppendLine("");
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}", "Day 1", "Day 2", "Day 3", "Day 4"));
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}", "=======", "=======", "=======", "======="));
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}",
                    $"Push-up: {pushUpDay1}x10",
                    $"Push-up: {pushUpDay2}x10",
                    $"Push-up: {pushUpDay3}x9",
                    $"Push-up: {pushUpDay4}x9"));
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}",
                    $"Plank: {plankDay1}s x10",
                    $"Plank: {plankDay2}s x10",
                    $"Plank: {plankDay3}s x9",
                    $"Plank: {plankDay4}s x9"));
                fileContent.AppendLine();
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}", "Day 5", "Day 6", "Day 7", "Day 8"));
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}", "=======", "=======", "=======", "======="));
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}",
                    $"Push-up: {pushUpDay5}x8",
                    $"Push-up: {pushUpDay6}x8",
                    $"Push-up: {pushUpDay7}x6",
                    $"Push-up: {pushUpDay8}x6"));
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}",
                    $"Plank: {plankDay5}s x8",
                    $"Plank: {plankDay6}s x8",
                    $"Plank: {plankDay7}s x6",
                    $"Plank: {plankDay8}s x6"));
                fileContent.AppendLine();
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}", "Day 9", "Day 10", "Day 11", "Day 12"));
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}", "=======", "=======", "=======", "======="));
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}",
                    $"Push-up: {pushUpDay9}x5",
                    $"Push-up: {pushUpDay10}x4",
                    "Rest",
                    "Rest"));
                fileContent.AppendLine(string.Format("{0,-16} {1,-16} {2,-16} {3,-16}",
                    $"Plank: {plankDay9}s x5",
                    $"Plank: {plankDay10}s x4",
                    "Rest",
                    "Rest"));
                fileContent.AppendLine();
                fileContent.AppendLine("=====================");
                fileContent.AppendLine();
                fileContent.AppendLine("Total Push-ups done: " + pushUpDone);
                fileContent.AppendLine("Total Plank done: " + plankDone + "s");

                // Écriture du contenu dans le fichier
                File.WriteAllText(filePath, fileContent.ToString());

                // Message de confirmation
                Console.Clear();
                Console.WriteLine("Your training program has been successfully saved on your desktop!");
                Console.WriteLine("File: " + fileName);
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
                Console.Clear();
                Menu.ShowMenu();
            }
            else if (choice == "2")
            {
                Menu.ShowMenu();
            }
            else if (choice == "3")
            {
                Environment.Exit(0);
            }
        }
    }

}


