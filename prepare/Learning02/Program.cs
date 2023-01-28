using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Head Web developer";
        job1._company = "IHC";
        job1._startYear = 2021;
        job1._endYear = "Current";

        Job job2 = new Job();
        job2._jobTitle = "Junior Web designer/developer";
        job2._company = "BrandLume";
        job2._startYear = 2022;
        job2._endYear = "Current";

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Aaron Santos";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}