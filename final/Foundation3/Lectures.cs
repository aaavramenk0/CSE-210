public class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    public void AddLecture() {
        Event lecture = new Event();
        lecture.AddEvent();

        Console.Write("Enter the speaker for this lecture: ");
        _speaker = Console.ReadLine();

        Console.Write("Enter the maximum capacity for this event: ");
        _capacity = int.Parse(Console.ReadLine());
    }
    public void GenerateFullDetails() {
        GenerateStandardDetails();
        Console.Write($"Lecture \nSpeaker: {_speaker} \nCapacity: {_capacity}");
    }
}