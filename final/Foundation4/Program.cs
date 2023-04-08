using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running();
        activities.Add(running);

        Cycling cycling = new Cycling();
        activities.Add(cycling);

        Swimming swimming = new Swimming();
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}