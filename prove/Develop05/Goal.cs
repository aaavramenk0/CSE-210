public class Goal
{
    private List<string> goals = new List<string>();
    private string _goalName;
    private string _description;
    private int _pointsAmount;
    private int _checklistAmount;
    private int _checklistBonus;
    public void AddGoal(){
        int userChoice;
        Console.Write("\nThe types of the goals are: \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal \nWhich type of goal would you like to create? ");
        userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.Write("\nWhat is the name of your goal? ");
                _goalName = Console.ReadLine();

                Console.Write("What is the short description of this goal? ");
                _description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                _pointsAmount = int.Parse(Console.ReadLine());

                goals.Add($"[ ] {_goalName} ({_description})");
                break;
            
            case 2: 
                Console.Write("\nWhat is the name of your goal? ");
                _goalName = Console.ReadLine();

                Console.Write("What is the short description of this goal? ");
                _description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                _pointsAmount = int.Parse(Console.ReadLine());

                goals.Add($"[ ] {_goalName} ({_description})");
                break;

            case 3: 
                Console.Write("\nWhat is the name of your goal? ");
                _goalName = Console.ReadLine();

                Console.Write("What is the short description of this goal? ");
                _description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                _pointsAmount = int.Parse(Console.ReadLine());

                Console.Write("How many times does this goal need to be acomplished for a bonus? ");
                _checklistAmount = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                _checklistBonus = int.Parse(Console.ReadLine());

                goals.Add($"[ ] {_goalName} ({_description}) -- Currently completed: 0/{_checklistAmount}");
                break;
            default: 
                break;
        }
    }

    public void ListGoals() {
        foreach (string goal in goals)
        {
            Console.WriteLine(goal);
        }
    }
}