public class ListeningActivity : Activity
{
    public ListeningActivity (string name, string description) : base (name, description)  {

    }

    private string _prompt;
    public string GetPrompt() {
        List<string> _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate? ");
        _prompts.Add("What are personal strengths of yours? ");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random promptIndex = new Random();
        int _prompt = promptIndex.Next(0, _prompts.Count);

        return _prompts[_prompt];
    }
    List<string> _userResponses = new List<string>();
    public void UserResponses (string response, string prompt) {
        _userResponses.Add(response);
        DateTime currentDate = DateTime.Now;
        string currentDateText = currentDate.ToShortDateString();
        string fileName = $"{currentDateText} Listening Activity Responses.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("Prompt: " + prompt);
            outputFile.WriteLine("Response: " + response);
        }
        Console.WriteLine("");
    }
}