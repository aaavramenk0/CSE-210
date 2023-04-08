public abstract class Activity
{
    protected double _distance;
    protected string _date;
    protected int _length;
    protected double _speed;
    protected double _pace;
    protected string _activityName;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary() {
        Console.Write("Enter the date of the activity: ");
        _date = Console.ReadLine();
        
        Console.Write("1. Running\n2. Cycling\n3. Swimming \nWhat activity are you doing today? ");
        int activity = int.Parse(Console.ReadLine());
            switch (activity)
            {
                case 1:
                    _activityName = "Running";
                    Running running = new Running();
                    _distance = running.GetDistance();
                    _speed = running.GetSpeed();
                    _pace = running.GetPace();
                    break;
                case 2:
                    _activityName = "Cycling";
                    Cycling cycling = new Cycling();
                    _distance = cycling.GetDistance();
                    _speed = cycling.GetSpeed();
                    _pace = cycling.GetPace();
                    break;
                case 3:
                    _activityName = "Swimming";
                    Swimming swimming = new Swimming();
                    _distance = swimming.GetDistance();
                    _speed = swimming.GetSpeed();
                    _pace = swimming.GetPace();
                    break;
                default:
                    break;
            }
        

        return $"{_date} {_activityName}: Distance {_distance} km, Speed {_speed} kph, Pace {_pace} min per km";
    }
}