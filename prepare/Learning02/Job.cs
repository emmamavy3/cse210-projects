
public class Job
{
    // Keeps track of company, job title, start year, end year
    public string _company = "";
    public string _jobTitle = "";
}
class Resume
{
    // people's names, their jobs
    static void Person()
    {
        Console.Write("What is your name? ");
        string _name = Console.ReadLine();
        Console.Write("What is your job? ");
        string _jobs = Console.ReadLine();
    }
}