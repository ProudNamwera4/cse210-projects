using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        string choice = "";
        int points = 0;
        string goalName = "";
        string goalDescription = "";
        int bonusPoints = 0;
        int nToComplete =0;
        int totalPoints = 0;
        SimpleGoal simpleGoal = new SimpleGoal(points,goalName,goalDescription);
        EternalGoal etGoal = new EternalGoal(points,goalName,goalDescription);
        ChecklistGoal clGoal = new ChecklistGoal(points,goalName,goalDescription,bonusPoints,nToComplete);
        
        List<Goal> goals = new List<Goal>();

        do{
            Console.WriteLine($"\nYou have {totalPoints} points.");

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
        
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1"){
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string userChoice = Console.ReadLine();
                if (userChoice == "1"){
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();
                    
                    Console.Write("What is a short description of it? ");
                    goalDescription = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    points = int.Parse(Console.ReadLine());

                    SimpleGoal sGoal = new SimpleGoal(points,goalName,goalDescription);
                    goals.Add(sGoal);
                }else if (userChoice == "2"){
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();
                    
                    Console.Write("What is a short description of it? ");
                    goalDescription = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    points = int.Parse(Console.ReadLine());

                    EternalGoal eternalGoal = new EternalGoal(points,goalName,goalDescription);
                    goals.Add(eternalGoal);
                }else if (userChoice == "3"){
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();
                    
                    Console.Write("What is a short description of it? ");
                    goalDescription = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    points = int.Parse(Console.ReadLine());

                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    nToComplete = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bonusPoints = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(points,goalName,goalDescription,bonusPoints,nToComplete);
                    goals.Add(checklistGoal);
                }


            }else if(choice == "2"){
                if (goals.Count()<=0){
                    Console.WriteLine("Your Goals List is empty! Try loading the data if you previously saved them to a file.");
                }else{
                    Console.WriteLine("The goals are: ");

                    for(int i = 0; i< goals.Count(); i++){

                        Console.Write($"{i+1}.");
                        Console.WriteLine(goals[i].ShowGoalList());
                    }
                }

            }else if(choice == "3"){
                Console.WriteLine("What is the filename for the goals file? ");
                string filename = Console.ReadLine();

                
                using (StreamWriter outputFile = new StreamWriter(filename)){
                    outputFile.WriteLine($"Total Points: {totalPoints}");
                    foreach(Goal goal in goals){
                    outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                }
                
            }else if (choice == "4"){
                Console.WriteLine("What is the filename for the goals file? ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                goals.Clear();

                foreach (string line in lines){
                    string[] goalParts = line.Split(",");
                    if (line.Contains("Simple Goal")){
                        Goal goal = simpleGoal.CreateGoal(line);
                        goals.Add(goal);
                    }else if(line.Contains("Eternal Goal")){
                        Goal goal = etGoal.CreateGoal(line);
                        goals.Add(goal);
                    
                    }else if(line.Contains("Checklist Goal")){
                        Goal goal = clGoal.CreateGoal(line);
                        goals.Add(goal);
                    }else if(line.Contains("Total Points")){
                        string[] parts = line.Split(":");
                        totalPoints = int.Parse(parts[1]);
                    }
                }
            }else if(choice =="5"){
                Console.WriteLine("The goals are:");
                for(int i = 0; i <goals.Count(); i++){
                    Console.WriteLine($"    {i+1}. {goals[i].GetGoalName()}");
                }
                Console.Write("Which goal did you accomplish today? ");
                int goalToRecord = int.Parse(Console.ReadLine());
                int goalToRecordIndex = goalToRecord -1;
                int pointsGained = goals[goalToRecordIndex].RecordEvent();
                totalPoints = totalPoints + pointsGained;
                Console.WriteLine($"Congratulations! You have earned {pointsGained}!");
                Console.WriteLine($"You now have {totalPoints}");
            }
        }while(choice != "6");
    }
}
/*-The program lets the user know if they are trying to list 
goals without creating any and hints them to load from a
previously saved file.
-The user can load and save from a file of their choice.*/