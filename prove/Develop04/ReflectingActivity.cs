public class ReflectingActivity : Activity
{
    public ReflectingActivity(string name, string description) : base (name, description){

    }

    public string GetPrompt() {
        Console.Clear();
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        Random promptIndex = new Random();
        int _prompt = promptIndex.Next(0, prompts.Count);
        return $"Consider the following prompt: \n --- {prompts[_prompt]} --- \nWhen you have something in mind, press enter to continue.";
    }

    public string GetQuestions()
    {
        List<string> questionsList = new List<string>();
        questionsList.Add("How did you feel when it was complete? ");
        questionsList.Add("What is your favorite think about this experience? ");
        questionsList.Add("Why was this experience meaningful to you? ");
        questionsList.Add("Have you ever done anything like this before? ");
        questionsList.Add("How did you get started? ");
        questionsList.Add("What made this time different than other times when you were not as successful? ");
        questionsList.Add("What could you learn from this experience that applies to other situations? ");
        questionsList.Add("What did you learn about yourself through this experience? ");
        questionsList.Add("How can you keep this experience in mind in the future? ");

        Random questionIndex = new Random();
        int _questionNumber = questionIndex.Next(0, questionsList.Count);

        return questionsList[_questionNumber];
    }
}