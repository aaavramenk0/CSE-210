using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Social media manager";
        job1._company = "Kelly Landscapes Management";
        job1._startYear = 2022;
        job1._endYear = 2023;
        job1.DisplayJob();

        Job job2 = new Job();
        job2._jobTitle = "Lawn care technician";
        job2._company = "Kelly Landscapes Management";
        job2._startYear = 2023;
        job2._endYear = 2023;
        job2.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Oleksandr Avramenko";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobs();
    }
}