class Goals 
{
    private List<string> _goals;
    private string _filename;
    private int _totalScore;

    public Goals(string filename)
    {
        _filename = filename;
        _goals = new List<string>();
        _totalScore = 0;
    }
    public void AddGoal(string goal)
    {
        _goals.Add(goal);
    }
    public void LoadGoals()
    {
        if (File.Exists(_filename))
        {
            string[] lines = File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                _goals.Add(line);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    public void SaveGoals()
    {

    }
    public void DisplayGoals()
    {

    }
    public void DisplayScore()
    {

    }
    public void RecordEvent()
    {

    }
    private void ObtainVoid()
    {
        
    }
}