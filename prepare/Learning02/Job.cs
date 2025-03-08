
class Job
{
    // Keeps track of company, job title, start year, end year
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // public Job(string company, string jobTitle, int startYear, int endYear)
    // {
    //     _company = company;
    //     _jobTitle = jobTitle;
    //     _startYear = startYear;
    //     _endYear = endYear;


    // }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}
