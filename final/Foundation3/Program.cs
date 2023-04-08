using System;

class Program
{
    static void Main(string[] args)
    {
        int _eventType = 0;
        while (_eventType != 4) {
            Console.Write("1. Lecture \n2. Reception \n3. Outdoor gathering\n Choose the type of the event: ");
            _eventType = int.Parse(Console.ReadLine());

            switch (_eventType)
            {
                case 1:
                    Lectures lecture = new Lectures();
                    lecture.AddLecture();
                    Console.WriteLine("\nStandard details: \n");
                    lecture.GenerateStandardDetails();
                    Console.WriteLine("\nFull details: \n");
                    lecture.GenerateFullDetails();
                    Console.WriteLine("\nShort details: \n");
                    lecture.GenerateShortDetails("Lecture");
                    break;
                case 2: 
                default: break;
            }
        }

    }
}