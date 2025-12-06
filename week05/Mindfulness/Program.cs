using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    class Program
    {
        /*
         * EXCEEDING REQUIREMENTS (for full credit):
         * 1. Added a fourth activity: GratitudeActivity.
         * 2. Reflection and listing prompts/questions are chosen without repetition
         *    until all have been used at least once in that session.
         * 3. The program tracks how many times each activity is performed and prints
         *    a summary when the user chooses to quit.
         */

        static void Main(string[] args)
        {
            bool quit = false;
            var activityCounts = new Dictionary<string, int>();

            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Gratitude Activity");
                Console.WriteLine("5. Quit");
                Console.Write("Select a choice from the menu: ");

                string input = Console.ReadLine();
                Console.Clear();

                Activity activity = null;

                switch (input)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        activity = new GratitudeActivity();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option (1-5).");
                        PauseForUser();
                        break;
                }

                if (activity != null)
                {
                    activity.Run();

                    if (!activityCounts.ContainsKey(activity.Name))
                        activityCounts[activity.Name] = 0;

                    activityCounts[activity.Name]++;

                    Console.WriteLine("\nPress Enter to return to the menu.");
                    Console.ReadLine();
                }
            }

            ShowSummary(activityCounts);
        }

        private static void PauseForUser()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        private static void ShowSummary(Dictionary<string, int> counts)
        {
            Console.Clear();
            Console.WriteLine("Thank you for using the Mindfulness Program.\n");

            if (counts.Count == 0)
            {
                Console.WriteLine("You did not complete any activities this session.");
            }
            else
            {
                Console.WriteLine("Session Summary:");
                foreach (var pair in counts)
                {
                    Console.WriteLine($"- {pair.Key}: {pair.Value} time(s)");
                }
            }

            Console.WriteLine("\nPress Enter to close the program.");
            Console.ReadLine();
        }
    }
}
