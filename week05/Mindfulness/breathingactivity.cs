using System;

namespace MindfulnessProgram
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base(
                "Breathing Activity",
                "This activity will help you relax by walking you through breathing in and out slowly.\n" +
                "Clear your mind and focus on your breathing.")
        {
        }

        protected override void DoActivity()
        {
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("\nBreathe in... ");
                ShowCountdown(4);

                if (DateTime.Now >= endTime) break;

                Console.Write("Breathe out... ");
                ShowCountdown(4);
            }
        }
    }
}