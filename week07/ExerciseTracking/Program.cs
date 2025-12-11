using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Running: distance en millas
        activities.Add(new Running("03 Nov 2022", 30, 3.0));

        // Cycling: velocidad en mph
        activities.Add(new Cycling("05 Nov 2022", 45, 12.0));

        // Swimming: número de laps
        activities.Add(new Swimming("07 Nov 2022", 25, 40));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
