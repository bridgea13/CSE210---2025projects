using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Salesforce";
        job1._jobStartYear = 2020;
        job1._jobEndYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._jobCompany = "Apple";
        job2._jobStartYear = 1999;
        job2._jobEndYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Bing Bong"; 

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}