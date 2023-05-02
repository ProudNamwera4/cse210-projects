using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "McNamsAuto";
        job1._endYear = 2022;
        job1._jobTitle = "Web Designer";
        job1._startYear = 2021;

    

        Job job2 = new Job();
        job2._company = "MaEasy";
        job2._endYear = 2023;
        job2._startYear= 2022;
        job2._jobTitle = "Marketer";

       

        Resume myResume = new Resume();
        myResume._name = "Namwera Proud";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();


    }
}