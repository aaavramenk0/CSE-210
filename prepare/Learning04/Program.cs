using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Oleksandr Avramenko", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine("");

        MathAssignment mathAssignment = new MathAssignment("Oleksandr Avramenko", "Multiplication", "Section 7.2", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment writingAssignment = new WritingAssignment("Oleksandr Avramenko", "Math", "History of Multiplication");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}