using System;

class Program
{
    static void Main(string[] args)
    {
        Goal goal = new Goal();
        int userChoice = 0;
        while (userChoice != 6){
            Console.Write("\nMenu options: \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit \nSelect an option from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    goal.AddGoal();
                    break;
                case 2:
                    goal.ListGoals();
                    break;
                case 6:
                    break;
                default: break;
            }
        }
        
    }
}