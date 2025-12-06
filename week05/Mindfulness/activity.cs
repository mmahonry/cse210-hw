using System;
using System.Threading;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration; // seconds

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string Name => _name;
        public int Duration => _duration;

        // Template method: derived classes override DoActivity
        public void Run()
        {
            DisplayStartingMessage();
            DoActivity();
            DisplayEndingMessage();
        }

        protected abstract void DoActivity();

        protected void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.\n");
            Console.WriteLine(_description);
            Console.WriteLine();

            _duration = AskForDurationInSeconds();

            Console.WriteLine("\nGet ready to begin...");
            ShowSpinner(3);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine("\nWell done!");
            ShowSpinner(2);
            Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
            ShowSpinner(3);
        }

        private int AskForDurationInSeconds()
        {
            while (true)
            {
                Console.Write("How long (in seconds) would you like your session? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int seconds) && seconds > 0)
                {
                    return seconds;
                }

                Console.WriteLine("Please enter a positive whole number.\n");
            }
        }

        protected void ShowSpinner(int seconds)
        {
            string[] spinner = { "|", "/", "-", "\\" };
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            int index = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(spinner[index]);
                Thread.Sleep(250);
                Console.Write("\b \b");
                index = (index + 1) % spinner.Length;
            }
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        /// <summary>
        /// Helper to get a non-repeating random item from a working list.
        /// If the working list becomes empty, it is refilled from the master list.
        /// </summary>
        protected static string GetRandomWithoutRepeat(
            List<string> master,
            List<string> working,
            Random rand)
        {
            if (working.Count == 0)
            {
                working.AddRange(master);
            }

            int index = rand.Next(working.Count);
            string item = working[index];
            working.RemoveAt(index);

            return item;
        }
    }
}
