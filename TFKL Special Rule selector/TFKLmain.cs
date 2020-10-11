using System;
//using System.IO;
using System.Linq.Expressions;

namespace TFKL_Special_Rule_selector
{
    public class TFKLmain
    {
        public static void Main()
        {
            // Version 1.00 - Initial release
            string versionNr = "1.00";
            Console.WriteLine("TheFiveKageLeague Special Rule selector - version " + versionNr);
            Console.WriteLine("");

            // Create a new random instance
            Random ruleSelector = new Random();

            // Creating Array with special rules
            String[] specialRules = new String[]
            {
                "5 stars only",                             //Players are only allowed to use 5 star characters or below
                "Akatsuki only",                            //Players are only allowed to use "Akatsuki" affiliation characters
                "Ultimate characters only",                 //Players are only allowed to use ultimate or red ultimate characters
                "Single Target ninjutsu characters only"    //Players are only allowed to use characters with a single target ninjutsu
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

                    // Set i to 0, as long as i is lower than userChoice, generate random string from array specialRules
                    for (int i = 0; i < userChoice; i++)
                    {
                        // Generates 
                        int randomRuleIndex = ruleSelector.Next(specialRules.Length);
                        Console.WriteLine(specialRules[randomRuleIndex]);
                    }

                    // Reset console output text to default
                    Console.ResetColor();

                    Console.WriteLine("");
                    Console.WriteLine("Your special rule(s) has been generated!");
                    Console.WriteLine("Please press 'ENTER' to exit the program.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("You have chosen to generate 2 special rule(s)!");
                    Console.WriteLine("Generating rule(s)...");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;

                    for (int i = 0; i < userChoice; i++)
                    {
                        int randomRuleIndex = ruleSelector.Next(specialRules.Length);
                        Console.WriteLine(specialRules[randomRuleIndex]);
                    }

                    Console.ResetColor();

                    Console.WriteLine("");
                    Console.WriteLine("Your special rule(s) has been generated!");
                    Console.WriteLine("Please press 'ENTER' to exit the program.");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("You have chosen to generate 3 special rule(s)!");
                    Console.WriteLine("Generating rule(s)...");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;
                    
                    for (int i = 0; i < userChoice; i++)
                    {
                        int randomRuleIndex = ruleSelector.Next(specialRules.Length);
                        Console.WriteLine(specialRules[randomRuleIndex]);
                    }

                    Console.ResetColor();

                    Console.WriteLine("");
                    Console.WriteLine("Your special rule(s) has been generated!");
                    Console.WriteLine("Please press 'ENTER' to exit the program.");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("You have chosen to generate 4 special rule(s)!");
                    Console.WriteLine("Generating rule(s)...");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;

                    for (int i = 0; i < userChoice; i++)
                    {
                    int randomRuleIndex = ruleSelector.Next(specialRules.Length);
                    Console.WriteLine(specialRules[randomRuleIndex]);
                    }

                    Console.ResetColor();

                    Console.WriteLine("");
                    Console.WriteLine("Your special rule(s) has been generated!");
                    Console.WriteLine("Please press 'ENTER' to exit the program.");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("You have chosen to generate 5 special rule(s)!");
                    Console.WriteLine("Generating rule(s)...");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Green;

                    for (int i = 0; i < userChoice; i++)
                    {
                        int randomRuleIndex = ruleSelector.Next(specialRules.Length);
                        Console.WriteLine(specialRules[randomRuleIndex]);
                    }

                    Console.ResetColor();

                    Console.WriteLine("");
                    Console.WriteLine("Your special rule(s) has been generated!");
                    Console.WriteLine("Please press 'ENTER' to exit the program.");
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