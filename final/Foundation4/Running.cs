public class Running : Activity
{
    public override double GetDistance()
    {
        Console.Write("What is the distance of today Running activity (in km): ");
        _distance = double.Parse(Console.ReadLine());

        return _distance;
    }

    public override double GetSpeed()
    {
        Console.Write("How long did you run today? (in minutes) ");
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