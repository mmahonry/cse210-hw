using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    // Extra creative activity: Guided Gratitude visualization
    public class GratitudeActivity : Activity
    {
        private static readonly List<string> _prompts = new List<string>
        {
            "Visualize three things in your life you are grateful for today.",
            "Think of a person who has blessed your life recently.",
            "Think of a challenge that secretly helped you grow.",
            "Recall a simple moment from this week that brought you joy.",
        };

        public GratitudeActivity()
            : base(
                "Gratitude Activity",
                "This activity will guide you to feel more gratitude by reflecting on blessings in your life.")
        {
        }

        protected override void DoActivity()
        {
            Random rand = new Random();

            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine("\nFocus on the following thought:");
            Console.WriteLine($"--- {prompt} ---");
            Console.Write("\nClose your eyes if you wish. You may begin in: ");
            ShowCountdown(5);
            Console.WriteLine();

            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            // We’ll just keep a gentle spinner running while they reflect.
            while (DateTime.Now < endTime)
            {
                Console.Write("Feel your gratitude growing ");
                ShowSpinner(4);
                Console.Write("\r" + new string(' ', 40) + "\r");
            }

            Console.WriteLine("\nTake a deep breath and hold onto that feeling of gratitude.");
        }
    }
}
