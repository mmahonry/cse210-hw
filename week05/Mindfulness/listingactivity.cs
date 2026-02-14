using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public class ListingActivity : Activity
    {
        private static readonly List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
            : base(
                "Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        protected override void DoActivity()
        {
            Random rand = new Random();

            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine($"\nList as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");

            Console.Write("\nYou may begin in: ");
            ShowCountdown(5);
            Console.WriteLine();

            int count = 0;
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(response))
                {
                    count++;
                }
            }

            Console.WriteLine($"\nYou listed {count} items.");
        }
    }
}