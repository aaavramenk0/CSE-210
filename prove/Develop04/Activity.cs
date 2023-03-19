public class Activity {
    protected string _activityName;
    protected string _activityDescription;
    protected string _activityDuration;

    public Activity(string name, string description) {
        _activityName = name;
        _activityDescription = description;
    }

    public string GetActivityInfo() {
        Console.Clear();

        return $"Welcome to {_activityName}." + " \n \n" + _activityDescription;
    }

    public void GetReadySpinner() {
        Console.Clear();
        Console.WriteLine("Get ready...");
        for (int i = 0; i < 3; i++) {
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|"); 
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
            
        
    }

    public string GetCompleteMessage(int duration) {
        return $"Well done! \nYou have completed another {_activityDuration} seconds of the {_activityName}";
    }
}