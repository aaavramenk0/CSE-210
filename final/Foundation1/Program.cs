using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._author = "freeCodeCamp.org";
        video1._title = "C# Tutorial - Full Course for Beginners";
        video1._length = "4:31:08";
        video1._likes = "155k";
        video1._url = "https://www.youtube.com/watch?v=GhQdlIFylQ8";
        video1.AddComment("Pain1272", "Only 1 hour in and I'm learning so much better than any teacher in school I've ever had… you break this down into such an easier way of understanding it");
        video1.AddComment("Marko Obradovic", "I'm a beginner and I've always had a problem understanding classes and objects for some reason. After watching this whole course I feel like I understood more than for the past 2 months of fax + home learning,  now it all makes perfect sense in my head and I want to thank you. Edit: After 4 hours of pure enjoyment and understanding, I felt emotional when the video ended lol");
        video1.AddComment("Hiraeth", "This is THE BEST tutorial I’ve seen of coding in my week of search. You don’t go on and on about words we don’t understand and you actually explain how stuff works! Thank you!");
        Console.WriteLine(video1.GetVideoInfo());
        video1.GetComments();
        
        Video video2 = new Video();
        video2._author = "Fireship";
        video2._title = "10 CSS Pro Tips - Code this, NOT that!";
        video2._length = "9:38";
        video2._likes = "91k";
        video2._url = "https://www.youtube.com/watch?v=Qhaz36TZG5Y&t";
        video2.AddComment("Eeze", "I can't believe the amount of valuable information that you explain in less than 10 minutes, amazing job as always!!");
        video2.AddComment("Robert Szordykowski", "You explained grid in 50 seconds more comprehensibly than other tuts do in an hour. Hats off.");
       
        Console.WriteLine(video2.GetVideoInfo());
        video2.GetComments();
        
        Video video3 = new Video();
        video3._author = "Kevin Stratvert";
        video3._title = "Python for Beginners Tutorial";
        video3._length = "1:03:20";
        video3._likes = "34k";
        video3._url = "https://www.youtube.com/watch?v=b093aqAZiPU";
        video3.AddComment("merley kimani", "Hey Kevin, you make complicated issues really simple. Thank you for your dedication.");
        video3.AddComment("Prabhakar Rao", "I'm in my late 60's with no computer programming background whatsoever yet I found your tutorial well thought out and at a very good pace. Suddenly I'm full of enthusiasm to learn more. Thank you Kevin.");
        video3.AddComment("Bilal", "Hey Kevin, Thanks making this great video. I really enjoyed it. I look forward to more advanced python videos or secondary videos such as projects.  Much appreciated for your time and effort producing these videos.");
        Console.WriteLine(video3.GetVideoInfo());
        video3.GetComments();


    }
}