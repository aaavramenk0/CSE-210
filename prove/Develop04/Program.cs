using System;

/* 
    Showing Creativity and Exceeding Requirements ideas and what has been done :
    1. I developed the function to save user responses at Listening Activity into file.
    2. For future it can include user name and save all activities reports to the files.
*/

class Program
{
    static void Main(string[] args)
    {
        int _menuChoice; int _activityDuration; 
        do
        {
            Console.Clear();
            Console.Write("Menu Options: \n   1. Start Breathing Activity \n   2. Start Reflecting Activity \n   3. Start Listening Activity \n   4. Quit \nSelect a choice from the menu: ");
            _menuChoice = int.Parse(Console.ReadLine());

            switch (_menuChoice)
            {
                case 1 :
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    Console.WriteLine(breathingActivity.GetActivityInfo());
                    Console.Write("\nHow long, in seconds, would you like for your session? ");
                    _activityDuration = int.Parse(Console.ReadLine());
                    breathingActivity.GetReadySpinner();
                    breathingActivity.BreatheInAndOut(_activityDuration);
                    Console.WriteLine(breathingActivity.GetCompleteMessage(_activityDuration));
                    Thread.Sleep(4000);
                    break;
                case 2 :
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    Console.WriteLine(reflectingActivity.GetActivityInfo());
                    Console.Write("\nHow long, in seconds, would you like for your session? ");
                    _activityDuration = int.Parse(Console.ReadLine());
                    reflectingActivity.GetReadySpinner();
                    Console.WriteLine(reflectingActivity.GetPrompt());
                    Console.ReadLine();
                    Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

                    DateTime startTime = DateTime.Now;
                    DateTime endTime = startTime.AddSeconds(5);
                    Console.Write("You may begin in:  ");
                    while (DateTime.Now < endTime) {
                        for (int i = 5; i > 0; i--) {
                            Console.Write(i);
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                        }
                    }
                    Console.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        DateTime start = DateTime.Now;
                        DateTime end = start.AddSeconds(_activityDuration);
                        if (DateTime.Now < end) {
                            Console.Write($"{i+1}. " + reflectingActivity.GetQuestions() + " ");
                            Console.Write("7");
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                            Console.Write("6");
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                            Console.Write("5");
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                            Console.Write("4");
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                            Console.Write("3");
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                            Console.Write("2");
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                            Console.Write("1");
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine(reflectingActivity.GetCompleteMessage(_activityDuration));
                    Thread.Sleep(4000);
                    break;
                case 3 :
                    ListeningActivity listeningActivity = new ListeningActivity("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    Console.WriteLine(listeningActivity.GetActivityInfo());
                    Console.Write("\nHow long, in seconds, would you like for your session? ");
                    _activityDuration = int.Parse(Console.ReadLine());
                    listeningActivity.GetReadySpinner();
                    Console.WriteLine("List as many responses you can to the following prompt: ");
                    string _prompt = listeningActivity.GetPrompt();
                    Console.WriteLine(" --- " + _prompt + " --- ");
                    Console.Write("You may begin in:  ");
                    for (int i = 5; i > 0; i--) {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }
                    Console.WriteLine();
                    DateTime startTimer = DateTime.Now;
                    DateTime endTimer = startTimer.AddSeconds(_activityDuration);
                    
                    while (DateTime.Now < endTimer) {
                        Console.Write(" > ");
                        string _userResponse = Console.ReadLine();
                        listeningActivity.UserResponses(_userResponse, _prompt);
                    }

                    Console.WriteLine(listeningActivity.GetCompleteMessage(_activityDuration));
                    Thread.Sleep(4000);
                    break;
                case 4 : 
                    break;
                
                default: 
                    break;
            }
        } while (_menuChoice != 4);
    }
}