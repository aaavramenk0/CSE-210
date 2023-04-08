public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public void AddEvent() {
        Console.Write("Enter the name of the event: ");
        _eventTitle = Console.ReadLine();

        Console.Write("Enter the description of the event: ");
        _description = Console.ReadLine();

        Console.Write("Enter the date of the event: ");
        _date = Console.ReadLine();

        Console.Write("Enter the time of the event: ");
        _time = Console.ReadLine();

        Console.Write("Enter the address of the event: ");
        _address = Console.ReadLine();

        // return $"\n > New event is added \n{_eventTitle} \n{_description} \n{_date} \n{_time} \n{_address}";
    }

    public void GenerateStandardDetails() {
        Console.Write($"{_eventTitle}\n{_description}\nOn {_date} at {_time}\n{_address}");
    }

    public void GenerateShortDetails (string type) {
        Console.Write($"{type}\n{_eventTitle}\n{_date}");
    }   

}