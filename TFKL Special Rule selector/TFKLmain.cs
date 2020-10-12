using System;
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;

namespace TFKL_Special_Rule_selector
{
    public class TFKLmain
    {
        public static void Main()
        {
            // Version 1.00 - Initial release
            // Version 2.00 - Improved release with text file creation + no same generated special rules
            // Version 2.10 - Fixed version number + added creator string
            string versionNr = "2.10";

            // Program creator
            string creator = "Lyn aka /u/Lyn_The_2nd";

            // Text file paths to use for creating, writing, and opening
            string textDocPath = @"C:\temp\SpecialRules.txt";
            string textDocPath2 = @"/c C:\temp\SpecialRules.txt";

            // Set text color to red
            Console.ForegroundColor = ConsoleColor.Red;

            // Print program creator + version
            Console.WriteLine("TheFiveKageLeague Special Rule selector - version " + versionNr);
            Console.WriteLine("Created by " + creator + " for /r/TheFiveKageLeague");

            // Set text color back to white
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            // Create a new random instance
            Random ruleSelector = new Random();

            // Creating Array with special rules
            String[] specialRules = new String[]
            {
                "5 stars only",                             // Players are only allowed to use 5 star characters or below
                "Akatsuki only",                            // Players are only allowed to use "Akatsuki" affiliation characters
                "Ultimate characters only",                 // Players are only allowed to use ultimate or red ultimate characters
                "Single Target ninjutsu characters only"//,   // Players are only allowed to use characters with a single target ninjutsu
                //"placeholder"                               // Placeholder value to prevent crash on 5 generated rules
            };

            // Generic text
            Console.WriteLine("Hello, Shinobi!");
            Console.WriteLine("How many special rules do you want me to generate? (Max. 5)");
            Console.WriteLine("");

            // Get user input for use in switch statement. Using long to prevent program from crashing if input is out of range
            long userChoice = Convert.ToInt64(Console.ReadLine());

            // Creating switch statement for amount of special rules
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("You have chosen to generate 1 special rule(s)!");
                    Console.WriteLine("Generating rule(s)...");
                    Console.WriteLine("");

                    // Set console output text to green
                    Console.ForegroundColor = ConsoleColor.Green;

                    // Generate a random number in the specialRules array
                    int randomRuleIndex1 = ruleSelector.Next(specialRules.Length);

                    // Print the string that equates to the generated array index
                    Console.WriteLine(specialRules[randomRuleIndex1]);

                    // Reset console output text to default
                    Console.ResetColor();

                    // Create a text file in the chosen path
                    using (StreamWriter sw = File.CreateText(textDocPath))
                    {
                        // Write the genrated special rules to the created text file
                        sw.WriteLine(specialRules[randomRuleIndex1]);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Your special rule(s) has been generated!");
                    Console.WriteLine("A text file containing the special rules has also been created!");
                    Console.WriteLine("It can be found in 'C:/Users/SpecialRules.txt/'");
                    Console.WriteLine("Press 'ENTER' to open the newly created text file.");
                    Console.ReadKey();

                    // Open a cmd.exe process to open the newly created txt file
                    var proc = Process.Start(@"cmd.exe ", textDocPath2);

                    Console.WriteLine("Close the file and press 'ENTER' again to exit the program.");
                    Console.ReadKey();
                    break;



                case 2:
                    Console.WriteLine("You have chosen to generate 2 special rule(s)!");
                    Console.WriteLine("Generating rule(s)...");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;

                    randomRuleIndex1 = ruleSelector.Next(specialRules.Length);
                    int randomRuleIndex2 = ruleSelector.Next(specialRules.Length);

                    //While loops to prevent values from being the same
                    while (randomRuleIndex1 == randomRuleIndex2)
                    {
                        randomRuleIndex1 = ruleSelector.Next(specialRules.Length);
                    }

                    while (randomRuleIndex2 == randomRuleIndex1)
                    {
                        randomRuleIndex2 = ruleSelector.Next(specialRules.Length);
                    }

                    Console.WriteLine(specialRules[randomRuleIndex1]);
                    Console.WriteLine(specialRules[randomRuleIndex2]);

                    Console.ResetColor();

                    using (StreamWriter sw = File.CreateText(textDocPath))
                    {
                        sw.WriteLine(specialRules[randomRuleIndex1]);
                        sw.WriteLine(specialRules[randomRuleIndex2]);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Your special rule(s) has been generated!");
                    Console.WriteLine("A text file containing the special rules has also been created!");
                    Console.WriteLine("It can be found in 'C:/Users/SpecialRules.txt/'");
                    Console.WriteLine("Press 'ENTER' to open the newly created text file.");
                    Console.ReadKey();

                    proc = Process.Start(@"cmd.exe ", textDocPath2);

                    Console.WriteLine("Close the file and press 'ENTER' again to exit the program.");
                    Console.ReadKey();
                    break;



                case 3:
                    Console.WriteLine("You have chosen to generate 3 special rule(s)!");
                    Console.WriteLine("Generating rule(s)...");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;

                    randomRuleIndex1 = ruleSelector.Next(specialRules.Length);
                    randomRuleIndex2 = ruleSelector.Next(specialRules.Length);
                    int randomRuleIndex3 = ruleSelector.Next(specialRules.Length);

                    while (randomRuleIndex1 == randomRuleIndex2 || randomRuleIndex1 == randomRuleIndex3)
                    {
                        randomRuleIndex1 = ruleSelector.Next(specialRules.Length);
                    }

                    while (randomRuleIndex2 == randomRuleIndex1 || randomRuleIndex2 == randomRuleIndex3)
                    {
                        randomRuleIndex2 = ruleSelector.Next(specialRules.Length);
                    }

                    while (randomRuleIndex3 == randomRuleIndex1 || randomRuleIndex3 == randomRuleIndex2)
                    {
                        randomRuleIndex3 = ruleSelector.Next(specialRules.Length);
                    }

                    Console.WriteLine(specialRules[randomRuleIndex1]);
                    Console.WriteLine(specialRules[randomRuleIndex2]);
                    Console.WriteLine(specialRules[randomRuleIndex3]);

                    Console.ResetColor();

                    using (StreamWriter sw = File.CreateText(textDocPath))
                    {
                        sw.WriteLine(specialRules[randomRuleIndex1]);
                        sw.WriteLine(specialRules[randomRuleIndex2]);
                        sw.WriteLine(specialRules[randomRuleIndex3]);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Your special rule(s) has been generated!");
                    Console.WriteLine("A text file containing the special rules has also been created!");
                    Console.WriteLine("It can be found in 'C:/Users/SpecialRules.txt/'");
                    Console.WriteLine("Press 'ENTER' to open the newly created text file.");
                    Console.ReadKey();

                    proc = Process.Start(@"cmd.exe ", textDocPath2);

                    Console.WriteLine("Close the file and press 'ENTER' again to exit the program.");
                    Console.ReadKey();
                    break;



                case 4:
                    Console.WriteLine("You have chosen to generate 4 special rule(s)!");
                    Console.WriteLine("Generating rule(s)...");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;

                    randomRuleIndex1 = ruleSelector.Next(specialRules.Length);
                    randomRuleIndex2 = ruleSelector.Next(specialRules.Length);
                    randomRuleIndex3 = ruleSelector.Next(specialRules.Length);
                    int randomRuleIndex4 = ruleSelector.Next(specialRules.Length);

                    while (randomRuleIndex1 == randomRuleIndex2 || randomRuleIndex1 == randomRuleIndex3 || randomRuleIndex1 == randomRuleIndex4)
                    {
                        randomRuleIndex1 = ruleSelector.Next(specialRules.Length);
                    }

                    while (randomRuleIndex2 == randomRuleIndex1 || randomRuleIndex2 == randomRuleIndex3 || randomRuleIndex1 == randomRuleIndex4)
                    {
                        randomRuleIndex2 = ruleSelector.Next(specialRules.Length);
                    }

                    while (randomRuleIndex3 == randomRuleIndex1 || randomRuleIndex3 == randomRuleIndex2 || randomRuleIndex3 == randomRuleIndex4)
                    {
                        randomRuleIndex3 = ruleSelector.Next(specialRules.Length);
                    }

                    while (randomRuleIndex4 == randomRuleIndex1 || randomRuleIndex4 == randomRuleIndex2 || randomRuleIndex4 == randomRuleIndex3)
                    {
                        randomRuleIndex4 = ruleSelector.Next(specialRules.Length);
                    }

                    Console.WriteLine(specialRules[randomRuleIndex1]);
                    Console.WriteLine(specialRules[randomRuleIndex2]);
                    Console.WriteLine(specialRules[randomRuleIndex3]);
                    Console.WriteLine(specialRules[randomRuleIndex4]);

                    string generatedRules = specialRules[randomRuleIndex1] + System.Environment.NewLine +
                    specialRules[randomRuleIndex2] + System.Environment.NewLine +
                    specialRules[randomRuleIndex3] + System.Environment.NewLine +
                    specialRules[randomRuleIndex4];

                    Console.ResetColor();

                    using (StreamWriter sw = File.CreateText(textDocPath))
                    {
                        sw.WriteLine(specialRules[randomRuleIndex1]);
                        sw.WriteLine(specialRules[randomRuleIndex2]);
                        sw.WriteLine(specialRules[randomRuleIndex3]);
                        sw.WriteLine(specialRules[randomRuleIndex4]);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Your special rule(s) has been generated!");
                    Console.WriteLine("A text file containing the special rules has also been created!");
                    Console.WriteLine("It can be found in 'C:/Users/SpecialRules.txt/'");
                    Console.WriteLine("Press 'ENTER' to open the newly created text file.");
                    Console.ReadKey();

                    proc = Process.Start(@"cmd.exe ", textDocPath2);

                    Console.WriteLine("Close the file and press 'ENTER' again to exit the program.");
                    Console.ReadKey();
                    break;



                case 5:
                    Console.WriteLine("You have chosen to generate 5 special rule(s)!");
                    Console.WriteLine("Generating rule(s)...");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;

                    randomRuleIndex1 = ruleSelector.Next(specialRules.Length);
                    randomRuleIndex2 = ruleSelector.Next(specialRules.Length);
                    randomRuleIndex3 = ruleSelector.Next(specialRules.Length);
                    randomRuleIndex4 = ruleSelector.Next(specialRules.Length);
                    int randomRuleIndex5 = ruleSelector.Next(specialRules.Length);

                    while (randomRuleIndex1 == randomRuleIndex2 || randomRuleIndex1 == randomRuleIndex3 || randomRuleIndex1 == randomRuleIndex4)
                    {
                        randomRuleIndex1 = ruleSelector.Next(specialRules.Length);
                    }

                    while (randomRuleIndex2 == randomRuleIndex1 || randomRuleIndex2 == randomRuleIndex3 || randomRuleIndex1 == randomRuleIndex4)
                    {
                        randomRuleIndex2 = ruleSelector.Next(specialRules.Length);
                    }

                    while (randomRuleIndex3 == randomRuleIndex1 || randomRuleIndex3 == randomRuleIndex2 || randomRuleIndex3 == randomRuleIndex4)
                    {
                        randomRuleIndex3 = ruleSelector.Next(specialRules.Length);
                    }

                    while (randomRuleIndex4 == randomRuleIndex1 || randomRuleIndex4 == randomRuleIndex2 || randomRuleIndex4 == randomRuleIndex3)
                    {
                        randomRuleIndex4 = ruleSelector.Next(specialRules.Length);
                    }

                    while (randomRuleIndex5 == randomRuleIndex1 || randomRuleIndex5 == randomRuleIndex2 || randomRuleIndex5 == randomRuleIndex3 || randomRuleIndex5 == randomRuleIndex4)
                    {
                        randomRuleIndex5 = ruleSelector.Next(specialRules.Length);
                    }

                    Console.WriteLine(specialRules[randomRuleIndex1]);
                    Console.WriteLine(specialRules[randomRuleIndex2]);
                    Console.WriteLine(specialRules[randomRuleIndex3]);
                    Console.WriteLine(specialRules[randomRuleIndex4]);
                    Console.WriteLine(specialRules[randomRuleIndex5]);

                    Console.ResetColor();

                    using (StreamWriter sw = File.CreateText(textDocPath))
                    {
                        sw.WriteLine(specialRules[randomRuleIndex1]);
                        sw.WriteLine(specialRules[randomRuleIndex2]);
                        sw.WriteLine(specialRules[randomRuleIndex3]);
                        sw.WriteLine(specialRules[randomRuleIndex4]);
                        sw.WriteLine(specialRules[randomRuleIndex5]);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Your special rule(s) has been generated!");
                    Console.WriteLine("A text file containing the special rules has also been created!");
                    Console.WriteLine("It can be found in 'C:/Users/SpecialRules.txt/'");
                    Console.WriteLine("Press 'ENTER' to open the newly created text file.");
                    Console.ReadKey();

                    proc = Process.Start(@"cmd.exe ", textDocPath2);

                    Console.WriteLine("Close the file and press 'ENTER' again to exit the program.");
                    Console.ReadKey();
                    break;



                default:
                    Console.WriteLine("Whoops! Looks like you did something wrong.");
                    Console.WriteLine("Please press 'ENTER' to restart the program and try again.");
                    Console.WriteLine("");
                    Console.ReadKey();

                    // Clear the console and start the program again
                    Console.Clear();
                    Main();
                    break;
            }
        }    
    }
}