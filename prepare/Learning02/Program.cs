using System;

class Program
{
    static void Main(string[] args)
    {
        Job job2 = new Job();
        job2 = new Job();
        job2._company = "JalaSoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2021;
        job2._endYear = 2024;

        Job job1 = new Job();
        job1 = new Job();
        job1._company = "CBA";
        job1._jobTitle = "English teacher";
        job1._startYear = 2006;
        job1._endYear = 2021;

        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);

        //job1.Display();
        //job2.Display();

        Resume myResume = new Resume();
        myResume = new Resume();
        myResume._name = "Rodolfo Ortuño";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Console.WriteLine(myResume._jobs[1]._jobTitle);
        myResume.Display();











    }
}