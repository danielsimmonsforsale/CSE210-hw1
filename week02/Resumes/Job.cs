using System;

public class Job()
{
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;
    public void DisplayJob()
    {
        Console.Write($"{_jobTitle} ({_company}) ");
        Console.WriteLine($"{_startYear}-{_endYear}");
    }
}