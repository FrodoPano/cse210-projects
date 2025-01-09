using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsft";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Web developer";
        job2._company = "Dell";
        job2._startYear = 2019;
        job2._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name = "Frodo Pano";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}