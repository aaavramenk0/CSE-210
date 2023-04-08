public class Swimming : Activity
{
    int _numberOfLaps;

    public override double GetDistance()
    {
        Console.Write("What many laps you finished today? ");
        _numberOfLaps = int.Parse(Console.ReadLine());
        _distance = _numberOfLaps * 50 / 1000;

        return _distance;
    }

    public override double GetSpeed()
    {
        Console.Write("How long did you swam today? (in minutes) ");
        _length = int.Parse(Console.ReadLine());
        _speed = _distance / _length * 60;

        return _speed;
    }

    public override double GetPace()
    {
        _pace = 60 / _speed;

        return _pace;
    }
}